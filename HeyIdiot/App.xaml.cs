using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HeyIdiot.Services;
using HeyIdiot.Views;
using System.Net.Http;
using HeyIdiot.ViewModels;

namespace HeyIdiot
{
  public partial class App : Application
  {

    public App()
    {
      InitializeComponent();

      DependencyService.Register<WordDetailViewModel>();

      DependencyService.Register<MockDataStore>();
      DependencyService.Register<WordDataStore>();

      DependencyService.Register<HttpClient>();


      MainPage = new AppShell();
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
  }
}
