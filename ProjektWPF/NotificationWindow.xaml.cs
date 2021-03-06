﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ProjektWPF
{
    /// <summary>
    /// Interaction logic for NotificationWindow.xaml
    /// </summary>
    public partial class NotificationWindow : Window
    {
        SoundPlayer s1;
        public NotificationWindow()
        {
            InitializeComponent();
            s1 = new SoundPlayer(Path.Combine(Environment.CurrentDirectory, @"alarm.wav"));
            s1.Play();
        }

        private void CloseNotificationWindow(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            s1.Stop();
            this.Close();
        }
    }
}
