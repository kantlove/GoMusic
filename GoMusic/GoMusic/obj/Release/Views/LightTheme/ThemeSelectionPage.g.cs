﻿#pragma checksum "D:\Minh Thái\My Documents\University HCMUS\WP8 Apps\GoMusic\GoMusic\GoMusic\Views\LightTheme\ThemeSelectionPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "852ADF99878EFCDE8987C8BA7C9E4179"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GoogleAds;
using Microsoft.Phone.Controls;
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


namespace GoMusic.Views.LightTheme {
    
    
    public partial class ThemeSelectionPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal GoogleAds.AdView adDuplexAd;
        
        internal System.Windows.Controls.Grid grid_MainContent;
        
        internal System.Windows.Controls.Grid GridStatus;
        
        internal System.Windows.Controls.TextBlock tb_Status;
        
        internal System.Windows.Controls.Grid gridLight;
        
        internal System.Windows.Controls.Grid gridDark;
        
        internal System.Windows.Controls.Grid gridLightSquare;
        
        internal System.Windows.Controls.Grid gridDarkSquare;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/GoMusic;component/Views/LightTheme/ThemeSelectionPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.adDuplexAd = ((GoogleAds.AdView)(this.FindName("adDuplexAd")));
            this.grid_MainContent = ((System.Windows.Controls.Grid)(this.FindName("grid_MainContent")));
            this.GridStatus = ((System.Windows.Controls.Grid)(this.FindName("GridStatus")));
            this.tb_Status = ((System.Windows.Controls.TextBlock)(this.FindName("tb_Status")));
            this.gridLight = ((System.Windows.Controls.Grid)(this.FindName("gridLight")));
            this.gridDark = ((System.Windows.Controls.Grid)(this.FindName("gridDark")));
            this.gridLightSquare = ((System.Windows.Controls.Grid)(this.FindName("gridLightSquare")));
            this.gridDarkSquare = ((System.Windows.Controls.Grid)(this.FindName("gridDarkSquare")));
        }
    }
}

