﻿#pragma checksum "C:\_CODE\EVAW-CC-TEMP\Ewav\Ewav\Views\Gadgets\GadgetFilterControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D8C05A19746269FADD657B08CC5F58F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EWAV;
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
    
    
    public partial class GadgetFilterControl : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel pnlGuidedMode;
        
        internal System.Windows.Controls.ScrollViewer scroll_content;
        
        internal System.Windows.Controls.StackPanel pnlContainer;
        
        internal EWAV.EWAVFilter FilterCtrl;
        
        internal System.Windows.Controls.StackPanel pnlBtns;
        
        internal System.Windows.Controls.Button btnApply;
        
        internal System.Windows.Controls.Button btnClear;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.ComboBox cmbAssignValue;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/EWAVD3;component/Views/Gadgets/GadgetFilterControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pnlGuidedMode = ((System.Windows.Controls.StackPanel)(this.FindName("pnlGuidedMode")));
            this.scroll_content = ((System.Windows.Controls.ScrollViewer)(this.FindName("scroll_content")));
            this.pnlContainer = ((System.Windows.Controls.StackPanel)(this.FindName("pnlContainer")));
            this.FilterCtrl = ((EWAV.EWAVFilter)(this.FindName("FilterCtrl")));
            this.pnlBtns = ((System.Windows.Controls.StackPanel)(this.FindName("pnlBtns")));
            this.btnApply = ((System.Windows.Controls.Button)(this.FindName("btnApply")));
            this.btnClear = ((System.Windows.Controls.Button)(this.FindName("btnClear")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.cmbAssignValue = ((System.Windows.Controls.ComboBox)(this.FindName("cmbAssignValue")));
        }
    }
}
