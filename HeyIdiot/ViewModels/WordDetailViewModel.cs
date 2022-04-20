using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using HeyIdiot.Models;
using Xamarin.Forms;

namespace HeyIdiot.ViewModels
{
  [QueryProperty(nameof(Name), nameof(Name))]
  public class WordDetailViewModel : BaseViewModel
  {
    private string _name;
    private List<string> _definitions = new List<string>();

    public string Name
    {
      get => this._name;
      set
      {
        SetProperty(ref this._name, value);
        LoadDefinitions();
      }
    }

    public List<string> Definitions
    {
      get => this._definitions;
      set => SetProperty(ref this._definitions, value);
    }

    private async void LoadDefinitions()
    {
      try
      {
        var response = await this.WordDataStore.SearchWordAsync(this.Name);


        this.Definitions.Add("A person of low general intelligence.");
        this.Definitions.Add("A person who makes stupid decisions; a fool.");
      }
      catch (Exception ex)
      {
        Debug.WriteLine($"Failed to search word: {ex.Message}");
      }
    }
  }
}
