using System;
using System.Collections.Generic;
using HeyIdiot.ViewModels;
using HeyIdiot.Views;
using Xamarin.Forms;

namespace HeyIdiot
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
