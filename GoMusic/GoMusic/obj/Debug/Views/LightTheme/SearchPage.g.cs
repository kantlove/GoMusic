﻿#pragma checksum "D:\Minh Thái\My Documents\University HCMUS\WP8 Apps\GoMusic\GoMusic\GoMusic\Views\LightTheme\SearchPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D78F684D3D25B7760485031682E0CB57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
using GoMusic.Controls;
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


namespace GoMusic {
    
    
    public partial class SearchPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup TrayVolumeStates;
        
        internal System.Windows.VisualState TrayVolumeOpened;
        
        internal System.Windows.VisualState TrayVolumeClosed;
        
        internal System.Windows.Controls.TextBlock tb_Status;
        
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
        
        internal Telerik.Windows.Controls.RadTextBox RadSearchBox;
        
        internal System.Windows.Controls.Grid grid_Recent;
        
        internal System.Windows.Controls.ListBox ListRecent;
        
        internal System.Windows.Controls.ListBox ImageBar;
        
        internal System.Windows.Controls.ListBoxItem ListBoxSong;
        
        internal GoMusic.Controls.PathControl PathSong;
        
        internal GoMusic.Controls.PathControl PathArtist;
        
        internal GoMusic.Controls.PathControl PathAlbum;
        
        internal GoMusic.Controls.PathControl PathPlaylist;
        
        internal System.Windows.Controls.Grid grid_SearchResult;
        
        internal Microsoft.Phone.Controls.Pivot PivotHome;
        
        internal Telerik.Windows.Controls.RadDataBoundListBox rad_SongResultList;
        
        internal Telerik.Windows.Controls.RadDataBoundListBox rad_ArtistResultList;
        
        internal Telerik.Windows.Controls.RadDataBoundListBox rad_AlbumResultList;
        
        internal Telerik.Windows.Controls.RadDataBoundListBox rad_PlaylistResultList;
        
        internal System.Windows.Controls.ProgressBar ProgessBarLoading;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/GoMusic;component/Views/LightTheme/SearchPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TrayVolumeStates = ((System.Windows.VisualStateGroup)(this.FindName("TrayVolumeStates")));
            this.TrayVolumeOpened = ((System.Windows.VisualState)(this.FindName("TrayVolumeOpened")));
            this.TrayVolumeClosed = ((System.Windows.VisualState)(this.FindName("TrayVolumeClosed")));
            this.tb_Status = ((System.Windows.Controls.TextBlock)(this.FindName("tb_Status")));
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
            this.RadSearchBox = ((Telerik.Windows.Controls.RadTextBox)(this.FindName("RadSearchBox")));
            this.grid_Recent = ((System.Windows.Controls.Grid)(this.FindName("grid_Recent")));
            this.ListRecent = ((System.Windows.Controls.ListBox)(this.FindName("ListRecent")));
            this.ImageBar = ((System.Windows.Controls.ListBox)(this.FindName("ImageBar")));
            this.ListBoxSong = ((System.Windows.Controls.ListBoxItem)(this.FindName("ListBoxSong")));
            this.PathSong = ((GoMusic.Controls.PathControl)(this.FindName("PathSong")));
            this.PathArtist = ((GoMusic.Controls.PathControl)(this.FindName("PathArtist")));
            this.PathAlbum = ((GoMusic.Controls.PathControl)(this.FindName("PathAlbum")));
            this.PathPlaylist = ((GoMusic.Controls.PathControl)(this.FindName("PathPlaylist")));
            this.grid_SearchResult = ((System.Windows.Controls.Grid)(this.FindName("grid_SearchResult")));
            this.PivotHome = ((Microsoft.Phone.Controls.Pivot)(this.FindName("PivotHome")));
            this.rad_SongResultList = ((Telerik.Windows.Controls.RadDataBoundListBox)(this.FindName("rad_SongResultList")));
            this.rad_ArtistResultList = ((Telerik.Windows.Controls.RadDataBoundListBox)(this.FindName("rad_ArtistResultList")));
            this.rad_AlbumResultList = ((Telerik.Windows.Controls.RadDataBoundListBox)(this.FindName("rad_AlbumResultList")));
            this.rad_PlaylistResultList = ((Telerik.Windows.Controls.RadDataBoundListBox)(this.FindName("rad_PlaylistResultList")));
            this.ProgessBarLoading = ((System.Windows.Controls.ProgressBar)(this.FindName("ProgessBarLoading")));
        }
    }
}

