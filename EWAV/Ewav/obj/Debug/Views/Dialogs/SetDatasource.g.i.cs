﻿#pragma checksum "C:\_CODE\EVAW-CC-TEMP\Ewav\Ewav\Views\Dialogs\SetDatasource.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "467E54CC5A78B0E826CE385CF4BBFFCB"
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
    
    
    public partial class SetDatasource : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel spMsg;
        
        internal System.Windows.Controls.TextBlock tbSaveError;
        
        internal System.Windows.Controls.StackPanel spOpen;
        
        internal System.Windows.Controls.ComboBox cboDatasoures;
        
        internal System.Windows.Controls.Button btnSetDB;
        
        internal System.Windows.Controls.Button btnCancel;
        
        internal System.Windows.Controls.Grid waitCursor;
        
        internal System.Windows.Controls.BusyIndicator BusyIndicator;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/EWAVD3;component/Views/Dialogs/SetDatasource.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.spMsg = ((System.Windows.Controls.StackPanel)(this.FindName("spMsg")));
            this.tbSaveError = ((System.Windows.Controls.TextBlock)(this.FindName("tbSaveError")));
            this.spOpen = ((System.Windows.Controls.StackPanel)(this.FindName("spOpen")));
            this.cboDatasoures = ((System.Windows.Controls.ComboBox)(this.FindName("cboDatasoures")));
            this.btnSetDB = ((System.Windows.Controls.Button)(this.FindName("btnSetDB")));
            this.btnCancel = ((System.Windows.Controls.Button)(this.FindName("btnCancel")));
            this.waitCursor = ((System.Windows.Controls.Grid)(this.FindName("waitCursor")));
            this.BusyIndicator = ((System.Windows.Controls.BusyIndicator)(this.FindName("BusyIndicator")));
        }
    }
}

