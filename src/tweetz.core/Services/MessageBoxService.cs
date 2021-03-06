﻿using System.Threading.Tasks;
using System.Windows;
using tweetz.core.Infrastructure;

namespace tweetz.core.Services
{
    public class MessageBoxService : IMessageBoxService
    {
        public void ShowMessageBox(string message)
        {
            var caption = (string)Application.Current.FindResource("title");
            MessageBox.Show(message, caption);
        }

        public Task ShowMessageBoxAsync(string message)
        {
            return Task.Run(() => ShowMessageBox(message));
        }
    }
}