using Microsoft.Win32;
using ProSoft.Services;
using System;
using System.Timers;

namespace ProSoft.Services
{
    public class MessageService
    {
        public event Action<string, ToastLevel>? OnShow;

        public void ShowToast(string message, ToastLevel level)
        {
            OnShow?.Invoke(message, level);
        }
    }
}