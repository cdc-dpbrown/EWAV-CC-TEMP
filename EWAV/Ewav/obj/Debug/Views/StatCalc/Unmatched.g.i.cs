﻿#pragma checksum "C:\_CODE\EVAW-CC-TEMP\Ewav\Ewav\Views\StatCalc\Unmatched.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94AABB0174FB2C51D09CF6798FD20C24"
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
    
    
    public partial class Unmatched : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard expand;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid GadgetWindow;
        
        internal System.Windows.Shapes.Rectangle GWindow;
        
        internal System.Windows.Controls.TextBlock GName;
        
        internal System.Windows.Shapes.Rectangle GHeader;
        
        internal System.Windows.Controls.Button ResizeButton;
        
        internal System.Windows.Controls.Button CloseButton1;
        
        internal System.Windows.Controls.Grid GadgetContentGrid;
        
        internal System.Windows.Controls.StackPanel pnlMainContent;
        
        internal System.Windows.Controls.StackPanel unmatched;
        
        internal System.Windows.Controls.ComboBox cbxConfidenceLevelU;
        
        internal System.Windows.Controls.TextBox txtPowerU;
        
        internal System.Windows.Controls.TextBox txtRatioControlsExposedU;
        
        internal System.Windows.Controls.TextBox txtPctControlsExposedU;
        
        internal System.Windows.Controls.TextBox txtOddsRatioU;
        
        internal System.Windows.Controls.TextBox txtPctCasesWithExposureU;
        
        internal System.Windows.Controls.TextBlock txtKelseyCasesU;
        
        internal System.Windows.Controls.TextBlock txtKelseyControlsU;
        
        internal System.Windows.Controls.TextBlock txtKelseyTotalU;
        
        internal System.Windows.Controls.TextBlock txtFleissCasesU;
        
        internal System.Windows.Controls.TextBlock txtFleissControlsU;
        
        internal System.Windows.Controls.TextBlock txtFleissTotalU;
        
        internal System.Windows.Controls.TextBlock txtFleissCCCasesU;
        
        internal System.Windows.Controls.TextBlock txtFleissCCControlsU;
        
        internal System.Windows.Controls.TextBlock txtFleissCCTotalU;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/EWAVD3;component/Views/StatCalc/Unmatched.xaml", System.UriKind.Relative));
            this.expand = ((System.Windows.Media.Animation.Storyboard)(this.FindName("expand")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.GadgetWindow = ((System.Windows.Controls.Grid)(this.FindName("GadgetWindow")));
            this.GWindow = ((System.Windows.Shapes.Rectangle)(this.FindName("GWindow")));
            this.GName = ((System.Windows.Controls.TextBlock)(this.FindName("GName")));
            this.GHeader = ((System.Windows.Shapes.Rectangle)(this.FindName("GHeader")));
            this.ResizeButton = ((System.Windows.Controls.Button)(this.FindName("ResizeButton")));
            this.CloseButton1 = ((System.Windows.Controls.Button)(this.FindName("CloseButton1")));
            this.GadgetContentGrid = ((System.Windows.Controls.Grid)(this.FindName("GadgetContentGrid")));
            this.pnlMainContent = ((System.Windows.Controls.StackPanel)(this.FindName("pnlMainContent")));
            this.unmatched = ((System.Windows.Controls.StackPanel)(this.FindName("unmatched")));
            this.cbxConfidenceLevelU = ((System.Windows.Controls.ComboBox)(this.FindName("cbxConfidenceLevelU")));
            this.txtPowerU = ((System.Windows.Controls.TextBox)(this.FindName("txtPowerU")));
            this.txtRatioControlsExposedU = ((System.Windows.Controls.TextBox)(this.FindName("txtRatioControlsExposedU")));
            this.txtPctControlsExposedU = ((System.Windows.Controls.TextBox)(this.FindName("txtPctControlsExposedU")));
            this.txtOddsRatioU = ((System.Windows.Controls.TextBox)(this.FindName("txtOddsRatioU")));
            this.txtPctCasesWithExposureU = ((System.Windows.Controls.TextBox)(this.FindName("txtPctCasesWithExposureU")));
            this.txtKelseyCasesU = ((System.Windows.Controls.TextBlock)(this.FindName("txtKelseyCasesU")));
            this.txtKelseyControlsU = ((System.Windows.Controls.TextBlock)(this.FindName("txtKelseyControlsU")));
            this.txtKelseyTotalU = ((System.Windows.Controls.TextBlock)(this.FindName("txtKelseyTotalU")));
            this.txtFleissCasesU = ((System.Windows.Controls.TextBlock)(this.FindName("txtFleissCasesU")));
            this.txtFleissControlsU = ((System.Windows.Controls.TextBlock)(this.FindName("txtFleissControlsU")));
            this.txtFleissTotalU = ((System.Windows.Controls.TextBlock)(this.FindName("txtFleissTotalU")));
            this.txtFleissCCCasesU = ((System.Windows.Controls.TextBlock)(this.FindName("txtFleissCCCasesU")));
            this.txtFleissCCControlsU = ((System.Windows.Controls.TextBlock)(this.FindName("txtFleissCCControlsU")));
            this.txtFleissCCTotalU = ((System.Windows.Controls.TextBlock)(this.FindName("txtFleissCCTotalU")));
        }
    }
}

