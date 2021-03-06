﻿#pragma checksum "C:\TFSCode\EWAV\Ewav\Ewav\Views\Gadgets\LinearRegression.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D8C0C1E5C6F8189072AA61EEF58E2B97"
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


namespace Ewav {
    
    
    public partial class LinearRegression : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid GadgetWindow;
        
        internal System.Windows.Shapes.Rectangle GWindow;
        
        internal System.Windows.Controls.TextBlock GName;
        
        internal System.Windows.Shapes.Rectangle GHeader;
        
        internal System.Windows.Controls.Button FilterButton;
        
        internal System.Windows.Controls.Button HeaderButton;
        
        internal System.Windows.Controls.Button ResizeButton;
        
        internal System.Windows.Controls.Button CloseButton;
        
        internal System.Windows.Controls.Grid GadgetContentGrid;
        
        internal System.Windows.Controls.Expander gadgetExpander;
        
        internal System.Windows.Controls.Grid grdRegressProperties;
        
        internal System.Windows.Controls.ComboBox cbxFieldOutcome;
        
        internal System.Windows.Controls.ComboBox cbxFields;
        
        internal System.Windows.Controls.ListBox lbxOtherFields;
        
        internal System.Windows.Controls.ComboBox cbxFieldWeight;
        
        internal System.Windows.Controls.ComboBox cbxConf;
        
        internal System.Windows.Controls.CheckBox checkboxNoIntercept;
        
        internal System.Windows.Controls.CheckBox checkboxIncludeMissing;
        
        internal System.Windows.Controls.Button btnMakeDummy;
        
        internal System.Windows.Controls.ListBox lbxDummyTerms;
        
        internal System.Windows.Controls.ListBox lbxInteractionTerms;
        
        internal System.Windows.Controls.Button btnMakeInteractionTerms;
        
        internal System.Windows.Controls.Button btnRemoveDummy;
        
        internal System.Windows.Controls.Button btnRemoveInteraction;
        
        internal System.Windows.Controls.Button btnRemoveVariables;
        
        internal System.Windows.Controls.Button btnRun;
        
        internal System.Windows.Controls.Button btnReset;
        
        internal System.Windows.Controls.StackPanel spContent;
        
        internal System.Windows.Controls.TextBlock txtGadgetDescription;
        
        internal System.Windows.Controls.StackPanel pnlStatus;
        
        internal System.Windows.Controls.StackPanel pnlStatusTop;
        
        internal System.Windows.Controls.Image ErrorIcon;
        
        internal System.Windows.Controls.TextBlock txtStatus;
        
        internal System.Windows.Controls.StackPanel pnlContent;
        
        internal System.Windows.Controls.Grid grdRegress;
        
        internal System.Windows.Controls.TextBlock txtCorrelation;
        
        internal System.Windows.Controls.Grid grdParameters;
        
        internal System.Windows.Controls.TextBlock txtRegressionDf;
        
        internal System.Windows.Controls.TextBlock txtRegressionSumOfSquares;
        
        internal System.Windows.Controls.TextBlock txtRegressionMeanSquare;
        
        internal System.Windows.Controls.TextBlock txtRegressionFstatistic;
        
        internal System.Windows.Controls.TextBlock txtResidualsDf;
        
        internal System.Windows.Controls.TextBlock txtResidualsSumOfSquares;
        
        internal System.Windows.Controls.TextBlock txtResidualsMeanSquare;
        
        internal System.Windows.Controls.TextBlock txtTotalDf;
        
        internal System.Windows.Controls.TextBlock txtTotalSumOfSquares;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Ewav;component/Views/Gadgets/LinearRegression.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.GadgetWindow = ((System.Windows.Controls.Grid)(this.FindName("GadgetWindow")));
            this.GWindow = ((System.Windows.Shapes.Rectangle)(this.FindName("GWindow")));
            this.GName = ((System.Windows.Controls.TextBlock)(this.FindName("GName")));
            this.GHeader = ((System.Windows.Shapes.Rectangle)(this.FindName("GHeader")));
            this.FilterButton = ((System.Windows.Controls.Button)(this.FindName("FilterButton")));
            this.HeaderButton = ((System.Windows.Controls.Button)(this.FindName("HeaderButton")));
            this.ResizeButton = ((System.Windows.Controls.Button)(this.FindName("ResizeButton")));
            this.CloseButton = ((System.Windows.Controls.Button)(this.FindName("CloseButton")));
            this.GadgetContentGrid = ((System.Windows.Controls.Grid)(this.FindName("GadgetContentGrid")));
            this.gadgetExpander = ((System.Windows.Controls.Expander)(this.FindName("gadgetExpander")));
            this.grdRegressProperties = ((System.Windows.Controls.Grid)(this.FindName("grdRegressProperties")));
            this.cbxFieldOutcome = ((System.Windows.Controls.ComboBox)(this.FindName("cbxFieldOutcome")));
            this.cbxFields = ((System.Windows.Controls.ComboBox)(this.FindName("cbxFields")));
            this.lbxOtherFields = ((System.Windows.Controls.ListBox)(this.FindName("lbxOtherFields")));
            this.cbxFieldWeight = ((System.Windows.Controls.ComboBox)(this.FindName("cbxFieldWeight")));
            this.cbxConf = ((System.Windows.Controls.ComboBox)(this.FindName("cbxConf")));
            this.checkboxNoIntercept = ((System.Windows.Controls.CheckBox)(this.FindName("checkboxNoIntercept")));
            this.checkboxIncludeMissing = ((System.Windows.Controls.CheckBox)(this.FindName("checkboxIncludeMissing")));
            this.btnMakeDummy = ((System.Windows.Controls.Button)(this.FindName("btnMakeDummy")));
            this.lbxDummyTerms = ((System.Windows.Controls.ListBox)(this.FindName("lbxDummyTerms")));
            this.lbxInteractionTerms = ((System.Windows.Controls.ListBox)(this.FindName("lbxInteractionTerms")));
            this.btnMakeInteractionTerms = ((System.Windows.Controls.Button)(this.FindName("btnMakeInteractionTerms")));
            this.btnRemoveDummy = ((System.Windows.Controls.Button)(this.FindName("btnRemoveDummy")));
            this.btnRemoveInteraction = ((System.Windows.Controls.Button)(this.FindName("btnRemoveInteraction")));
            this.btnRemoveVariables = ((System.Windows.Controls.Button)(this.FindName("btnRemoveVariables")));
            this.btnRun = ((System.Windows.Controls.Button)(this.FindName("btnRun")));
            this.btnReset = ((System.Windows.Controls.Button)(this.FindName("btnReset")));
            this.spContent = ((System.Windows.Controls.StackPanel)(this.FindName("spContent")));
            this.txtGadgetDescription = ((System.Windows.Controls.TextBlock)(this.FindName("txtGadgetDescription")));
            this.pnlStatus = ((System.Windows.Controls.StackPanel)(this.FindName("pnlStatus")));
            this.pnlStatusTop = ((System.Windows.Controls.StackPanel)(this.FindName("pnlStatusTop")));
            this.ErrorIcon = ((System.Windows.Controls.Image)(this.FindName("ErrorIcon")));
            this.txtStatus = ((System.Windows.Controls.TextBlock)(this.FindName("txtStatus")));
            this.pnlContent = ((System.Windows.Controls.StackPanel)(this.FindName("pnlContent")));
            this.grdRegress = ((System.Windows.Controls.Grid)(this.FindName("grdRegress")));
            this.txtCorrelation = ((System.Windows.Controls.TextBlock)(this.FindName("txtCorrelation")));
            this.grdParameters = ((System.Windows.Controls.Grid)(this.FindName("grdParameters")));
            this.txtRegressionDf = ((System.Windows.Controls.TextBlock)(this.FindName("txtRegressionDf")));
            this.txtRegressionSumOfSquares = ((System.Windows.Controls.TextBlock)(this.FindName("txtRegressionSumOfSquares")));
            this.txtRegressionMeanSquare = ((System.Windows.Controls.TextBlock)(this.FindName("txtRegressionMeanSquare")));
            this.txtRegressionFstatistic = ((System.Windows.Controls.TextBlock)(this.FindName("txtRegressionFstatistic")));
            this.txtResidualsDf = ((System.Windows.Controls.TextBlock)(this.FindName("txtResidualsDf")));
            this.txtResidualsSumOfSquares = ((System.Windows.Controls.TextBlock)(this.FindName("txtResidualsSumOfSquares")));
            this.txtResidualsMeanSquare = ((System.Windows.Controls.TextBlock)(this.FindName("txtResidualsMeanSquare")));
            this.txtTotalDf = ((System.Windows.Controls.TextBlock)(this.FindName("txtTotalDf")));
            this.txtTotalSumOfSquares = ((System.Windows.Controls.TextBlock)(this.FindName("txtTotalSumOfSquares")));
            this.waitCursor = ((System.Windows.Controls.Grid)(this.FindName("waitCursor")));
            this.BusyIndicator = ((System.Windows.Controls.BusyIndicator)(this.FindName("BusyIndicator")));
        }
    }
}

