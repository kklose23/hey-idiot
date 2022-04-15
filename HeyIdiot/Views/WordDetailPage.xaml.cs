using System;
using System.Collections.Generic;
using HeyIdiot.ViewModels;
using Xamarin.Forms;

namespace HeyIdiot.Views
{
    public partial class WordDetailPage : ContentPage
    {
        public WordDetailPage()
        {
            InitializeComponent();
            
            BindingContext = new WordDetailViewModel();
        }
    }
}
