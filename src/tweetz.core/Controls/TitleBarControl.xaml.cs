﻿using System.Windows.Controls;
using System.Windows.Input;

namespace tweetz.core.Controls
{
    public partial class TitleBarControl : UserControl
    {
        public TitleBarControl()
        {
            InitializeComponent();
        }

        private void ExecuteCloseCommand(object sender, MouseButtonEventArgs e)
        {
            ApplicationCommands.Close.Execute(null, this);
        }
    }
}