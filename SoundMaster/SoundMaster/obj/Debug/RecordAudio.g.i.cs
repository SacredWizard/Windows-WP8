﻿#pragma checksum "C:\Users\Rakesh\documents\visual studio 2012\Projects\SoundMaster\SoundMaster\RecordAudio.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7EF546FE7E400AFDAEC3FCF59707B57A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SoundMaster {
    
    
    public partial class RecordAudio : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard RotateCircle;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.MediaElement AudioPlayer;
        
        internal System.Windows.Controls.Grid ReelGrid;
        
        internal System.Windows.Controls.Button PlayAudio;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SoundMaster;component/RecordAudio.xaml", System.UriKind.Relative));
            this.RotateCircle = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RotateCircle")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.AudioPlayer = ((System.Windows.Controls.MediaElement)(this.FindName("AudioPlayer")));
            this.ReelGrid = ((System.Windows.Controls.Grid)(this.FindName("ReelGrid")));
            this.PlayAudio = ((System.Windows.Controls.Button)(this.FindName("PlayAudio")));
        }
    }
}

