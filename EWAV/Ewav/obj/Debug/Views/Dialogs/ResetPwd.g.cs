﻿#pragma checksum "C:\_CODE\EVAW-CC-TEMP\Ewav\Ewav\Views\Dialogs\ResetPwd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "55C7068FE4AC6D2868AFF10C0218A999"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace EWAV {
    
    
    public partial class ResetPwd : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel spMsg;
        
        internal System.Windows.Controls.TextBlock tbErrorMsg;
        
        internal System.Windows.Controls.StackPanel spFormatError;
        
        internal System.Windows.Controls.TextBlock passwordLengthMsg;
        
        internal System.Windows.Controls.TextBlock passwordTypeMsg;
        
        internal System.Windows.Controls.TextBlock puncMsg;
        
        internal System.Windows.Controls.Grid grdPwd;
        
        internal System.Windows.Controls.PasswordBox tbNewPwd;
        
        internal System.Windows.Controls.PasswordBox tbConfirmPwd;
        
        internal System.Windows.Controls.Button OKButton1;
        
        internal System.Windows.Controls.StackPanel spMsg_Success;
        
        internal System.Windows.Controls.Button btnBegin;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/EWAVD3;component/Views/Dialogs/ResetPwd.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.spMsg = ((System.Windows.Controls.StackPanel)(this.FindName("spMsg")));
            this.tbErrorMsg = ((System.Windows.Controls.TextBlock)(this.FindName("tbErrorMsg")));
            this.spFormatError = ((System.Windows.Controls.StackPanel)(this.FindName("spFormatError")));
            this.passwordLengthMsg = ((System.Windows.Controls.TextBlock)(this.FindName("passwordLengthMsg")));
            this.passwordTypeMsg = ((System.Windows.Controls.TextBlock)(this.FindName("passwordTypeMsg")));
            this.puncMsg = ((System.Windows.Controls.TextBlock)(this.FindName("puncMsg")));
            this.grdPwd = ((System.Windows.Controls.Grid)(this.FindName("grdPwd")));
            this.tbNewPwd = ((System.Windows.Controls.PasswordBox)(this.FindName("tbNewPwd")));
            this.tbConfirmPwd = ((System.Windows.Controls.PasswordBox)(this.FindName("tbConfirmPwd")));
            this.OKButton1 = ((System.Windows.Controls.Button)(this.FindName("OKButton1")));
            this.spMsg_Success = ((System.Windows.Controls.StackPanel)(this.FindName("spMsg_Success")));
            this.btnBegin = ((System.Windows.Controls.Button)(this.FindName("btnBegin")));
        }
    }
}

