﻿#pragma checksum "D:\Minh Thái\My Documents\University HCMUS\WP8 Apps\GoMusic\GoMusic\GoMusic\Views\LightTheme\MainPage_List.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FFFE6FC1BD357E0AC280326CB545341C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
using GoMusic.Controls;
using Microsoft.Expression.Shapes;
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
using Telerik.Windows.Controls;


namespace GoMusic.Views.LightTheme {
    
    
    public partial class MainPage_List : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard DiskSpin;
        
        internal System.Windows.Media.Animation.Storyboard Loading;
        
        internal System.Windows.Media.Animation.Storyboard Intro;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup ExitConfirm;
        
        internal System.Windows.VisualState GridExitOpened;
        
        internal System.Windows.VisualState GridExitClosed;
        
        internal System.Windows.VisualStateGroup TrayVolumeStates;
        
        internal System.Windows.VisualState TrayVolumeOpened;
        
        internal System.Windows.VisualState TrayVolumeClosed;
        
        internal System.Windows.Controls.Grid grid_Tray;
        
        internal System.Windows.Controls.Grid grid_TrayInfo;
        
        internal Coding4Fun.Toolkit.Controls.SuperImage ImageTrayCover;
        
        internal System.Windows.Documents.Run RunSong;
        
        internal System.Windows.Documents.Run RunArtist;
        
        internal System.Windows.Controls.Button ButtonTrayPrevious;
        
        internal System.Windows.Controls.Button ButtonTrayPlay;
        
        internal System.Windows.Controls.Button ButtonTrayPause;
        
        internal System.Windows.Controls.Button ButtonTrayNext;
        
        internal System.Windows.Controls.Grid grid_TrayVolume;
        
        internal System.Windows.Controls.TextBlock TextBlockVolume;
        
        internal System.Windows.Controls.Slider SliderVolume;
        
        internal System.Windows.Controls.Button ButtonTrayVolumeClose;
        
        internal System.Windows.Controls.Grid grid_MainContent;
        
        internal System.Windows.Controls.Grid grid_Home;
        
        internal System.Windows.Controls.ListBox ImageBar;
        
        internal System.Windows.Controls.ListBoxItem ListBoxSong;
        
        internal GoMusic.Controls.PathControl PathSong;
        
        internal GoMusic.Controls.PathControl PathArtist;
        
        internal GoMusic.Controls.PathControl PathAlbum;
        
        internal GoMusic.Controls.PathControl PathPlaylist;
        
        internal Microsoft.Phone.Controls.Pivot PivotHome;
        
        internal Microsoft.Phone.Controls.PivotItem PivotItemSongs;
        
        internal Telerik.Windows.Controls.RadJumpList rad_List;
        
        internal Microsoft.Phone.Controls.PivotItem PivotItemArtist;
        
        internal Telerik.Windows.Controls.RadJumpList rad_GridArtist;
        
        internal Microsoft.Phone.Controls.PivotItem PivotItemAlbum;
        
        internal Telerik.Windows.Controls.RadJumpList rad_GridAlbum;
        
        internal Microsoft.Phone.Controls.PivotItem PivotItemPlaylist;
        
        internal Telerik.Windows.Controls.RadJumpList rad_ListPlaylist;
        
        internal System.Windows.Controls.TextBlock tb_Status;
        
        internal System.Windows.Controls.Button ButtonSearch;
        
        internal System.Windows.Controls.Button ButtonSettings;
        
        internal System.Windows.Controls.Grid grid_Loading;
        
        internal Microsoft.Expression.Shapes.Arc arc;
        
        internal System.Windows.Controls.Grid grid_Exit;
        
        internal System.Windows.Controls.Button ButtonExitCancel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/GoMusic;component/Views/LightTheme/MainPage_List.xaml", System.UriKind.Relative));
            this.DiskSpin = ((System.Windows.Media.Animation.Storyboard)(this.FindName("DiskSpin")));
            this.Loading = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Loading")));
            this.Intro = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Intro")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ExitConfirm = ((System.Windows.VisualStateGroup)(this.FindName("ExitConfirm")));
            this.GridExitOpened = ((System.Windows.VisualState)(this.FindName("GridExitOpened")));
            this.GridExitClosed = ((System.Windows.VisualState)(this.FindName("GridExitClosed")));
            this.TrayVolumeStates = ((System.Windows.VisualStateGroup)(this.FindName("TrayVolumeStates")));
            this.TrayVolumeOpened = ((System.Windows.VisualState)(this.FindName("TrayVolumeOpened")));
            this.TrayVolumeClosed = ((System.Windows.VisualState)(this.FindName("TrayVolumeClosed")));
            this.grid_Tray = ((System.Windows.Controls.Grid)(this.FindName("grid_Tray")));
            this.grid_TrayInfo = ((System.Windows.Controls.Grid)(this.FindName("grid_TrayInfo")));
            this.ImageTrayCover = ((Coding4Fun.Toolkit.Controls.SuperImage)(this.FindName("ImageTrayCover")));
            this.RunSong = ((System.Windows.Documents.Run)(this.FindName("RunSong")));
            this.RunArtist = ((System.Windows.Documents.Run)(this.FindName("RunArtist")));
            this.ButtonTrayPrevious = ((System.Windows.Controls.Button)(this.FindName("ButtonTrayPrevious")));
            this.ButtonTrayPlay = ((System.Windows.Controls.Button)(this.FindName("ButtonTrayPlay")));
            this.ButtonTrayPause = ((System.Windows.Controls.Button)(this.FindName("ButtonTrayPause")));
            this.ButtonTrayNext = ((System.Windows.Controls.Button)(this.FindName("ButtonTrayNext")));
            this.grid_TrayVolume = ((System.Windows.Controls.Grid)(this.FindName("grid_TrayVolume")));
            this.TextBlockVolume = ((System.Windows.Controls.TextBlock)(this.FindName("TextBlockVolume")));
            this.SliderVolume = ((System.Windows.Controls.Slider)(this.FindName("SliderVolume")));
            this.ButtonTrayVolumeClose = ((System.Windows.Controls.Button)(this.FindName("ButtonTrayVolumeClose")));
            this.grid_MainContent = ((System.Windows.Controls.Grid)(this.FindName("grid_MainContent")));
            this.grid_Home = ((System.Windows.Controls.Grid)(this.FindName("grid_Home")));
            this.ImageBar = ((System.Windows.Controls.ListBox)(this.FindName("ImageBar")));
            this.ListBoxSong = ((System.Windows.Controls.ListBoxItem)(this.FindName("ListBoxSong")));
            this.PathSong = ((GoMusic.Controls.PathControl)(this.FindName("PathSong")));
            this.PathArtist = ((GoMusic.Controls.PathControl)(this.FindName("PathArtist")));
            this.PathAlbum = ((GoMusic.Controls.PathControl)(this.FindName("PathAlbum")));
            this.PathPlaylist = ((GoMusic.Controls.PathControl)(this.FindName("PathPlaylist")));
            this.PivotHome = ((Microsoft.Phone.Controls.Pivot)(this.FindName("PivotHome")));
            this.PivotItemSongs = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PivotItemSongs")));
            this.rad_List = ((Telerik.Windows.Controls.RadJumpList)(this.FindName("rad_List")));
            this.PivotItemArtist = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PivotItemArtist")));
            this.rad_GridArtist = ((Telerik.Windows.Controls.RadJumpList)(this.FindName("rad_GridArtist")));
            this.PivotItemAlbum = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PivotItemAlbum")));
            this.rad_GridAlbum = ((Telerik.Windows.Controls.RadJumpList)(this.FindName("rad_GridAlbum")));
            this.PivotItemPlaylist = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("PivotItemPlaylist")));
            this.rad_ListPlaylist = ((Telerik.Windows.Controls.RadJumpList)(this.FindName("rad_ListPlaylist")));
            this.tb_Status = ((System.Windows.Controls.TextBlock)(this.FindName("tb_Status")));
            this.ButtonSearch = ((System.Windows.Controls.Button)(this.FindName("ButtonSearch")));
            this.ButtonSettings = ((System.Windows.Controls.Button)(this.FindName("ButtonSettings")));
            this.grid_Loading = ((System.Windows.Controls.Grid)(this.FindName("grid_Loading")));
            this.arc = ((Microsoft.Expression.Shapes.Arc)(this.FindName("arc")));
            this.grid_Exit = ((System.Windows.Controls.Grid)(this.FindName("grid_Exit")));
            this.ButtonExitCancel = ((System.Windows.Controls.Button)(this.FindName("ButtonExitCancel")));
        }
    }
}

