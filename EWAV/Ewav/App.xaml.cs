﻿using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using EWAV.ViewModels;
using System;
using System.ServiceModel.DomainServices.Client.ApplicationServices;
using EWAV.Web.Services;
using System.Windows.Navigation;

using System.Collections.Generic;
using System.Reflection;

namespace EWAV
{
    public partial class App : Application
    {
        EWAVD3.WebContext webCtx = null;

        public App()
        {
            this.Startup += this.Application_Startup;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ApplicationViewModel.Instance.AuthenticationMode = e.InitParams["AuthenticationMode"].ToString();
            ApplicationViewModel.Instance.KeyForUserPasswordSalt = e.InitParams["KeyForUserPasswordSalt"].ToString();
            ApplicationViewModel.Instance.KeyForBingMaps = e.InitParams["KeyForBingMaps"].ToString();
            ApplicationViewModel.Instance.EnableExceptionDetail = Convert.ToBoolean(e.InitParams["EnableExceptionDetail"].ToString());
            ApplicationViewModel.Instance.SendEmailOnException = Convert.ToBoolean(e.InitParams["SendEmailOnException"].ToString());
            ApplicationViewModel.Instance.IsEpiWebIntegrationEnabled = Convert.ToBoolean(e.InitParams["IsEpiWebIntegrationEnabled"].ToString());
            ApplicationViewModel.Instance.DemoMode = Convert.ToBoolean(e.InitParams["DemoMode"]);
            ApplicationViewModel.Instance.DemoModeUser = e.InitParams["DemoModeUser"].ToString();
            ApplicationViewModel.Instance.DemoModePassword = e.InitParams["DemoModePassword"].ToString();

            Assembly assembly = Assembly.GetExecutingAssembly();
            string fullversion = assembly.FullName.Split(',')[1];
            string version = fullversion.Split('=')[1];

            ApplicationViewModel.Instance.ClientAssemblyVersion = version;

            Uri uri = HtmlPage.Document.DocumentUri;

            string queryString = uri.Query;

            if (queryString.Length != 0)
            {
                Dictionary<string, string> queryParameters = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

                string[] querySegments = queryString.Split('&');
                foreach (string segment in querySegments)
                {
                    string[] parts = segment.Split('=');
                    if (parts.Length > 0)
                    {
                        string key = parts[0].Trim(new char[] { '?', ' ' });
                        string val = parts[1].Trim();

                        queryParameters.Add(key, val);
                    }
                }

                if (queryParameters.ContainsKey("canvasguid"))
                {
                    string guidCandidate = queryParameters["canvasguid"].ToString();

                    Regex guidRegEx = new Regex(@"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$");

                    if (guidRegEx.IsMatch(guidCandidate))
                    {

                        ApplicationViewModel.Instance.UrlHasCanvasGUID = true;
                        ApplicationViewModel.Instance.CanvasGUIDFromUrl = new Guid(guidCandidate);


                    }
                }

            }

            HtmlDocument htd = HtmlPage.Document;

            DashboardMainPage dmp = new DashboardMainPage();

            this.RootVisual = dmp;

            dmp.FullScreenButton.Click += delegate (Object s, RoutedEventArgs args)
            {
                this.Host.Content.IsFullScreen = !this.Host.Content.IsFullScreen;
            };
        }


        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // If the app is running outside of the debugger then report the exception using
            // a ChildWindow control.
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                // NOTE: This will allow the application to continue running after an exception has been thrown
                // but not handled. 
                // For production applications this error handling should be replaced with something that will 
                // report the error to the website and stop the application.
                e.Handled = true;
                ChildWindow errorWin = new ErrorWindow(e.ExceptionObject);
                errorWin.Show();
            }
        }
    }
}