﻿using System.Windows;

namespace Baku.VMagicMirrorConfig
{
    public partial class LayoutSettingWindow : Window
    {
        public LayoutSettingWindow() => InitializeComponent();

        private void OnClickOk(object sender, RoutedEventArgs e)
            => DialogResult = true;
    }
}
