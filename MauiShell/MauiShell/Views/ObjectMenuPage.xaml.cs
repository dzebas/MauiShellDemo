using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShell.Views;

public partial class ObjectMenuPage : ContentPage
{
    public ObjectMenuPage()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("NoTabBarPage");
    }
}