using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Styling;
using AvaloniaStylesApp.Themes;
using FluentAvalonia.Styling;
using FluentAvalonia.UI.Controls;

namespace AvaloniaStylesApp.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    private void ThemeComboBox_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if(sender is not FAComboBox { SelectedItem: string theme }) return;
        var app = (App)Application.Current!;
        app.RequestedThemeVariant= theme switch
        {
            "System" => ThemeVariant.Default,
            "Light" => ThemeVariant.Light,
            "Dark" => ThemeVariant.Dark,
            "HighContrast" => FluentAvaloniaTheme.HighContrastTheme,
            "Custom" => ThemeVariants.Custom,
            _ => throw new ArgumentOutOfRangeException(nameof(theme), theme, null)
        };
    }
}