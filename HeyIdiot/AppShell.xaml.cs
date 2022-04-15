using System;
using System.Collections.Generic;
using HeyIdiot.ViewModels;
using HeyIdiot.Views;
using Xamarin.Forms;

namespace HeyIdiot
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(WordDetailPage), typeof(WordDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
