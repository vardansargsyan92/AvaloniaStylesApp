namespace AvaloniaStylesApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting
    {
        get => "Welcome to Avalonia!";
    }

    public string SwitchTheme
    {
        get => "Switch theme";
    }

    public string LabelWithStyle
    {
        get => "Label with style";
    }

    public string LabelWithTheme
    {
        get => "Label with theme";
    }

    public string ButtonWithStyle
    {
        get => "Button with style";
    }

    public string ButtonWithTheme
    {
        get => "Button with theme";
    }

    public string[] Themes
    {
        get => new[] { "System", "Light", "Dark", "HighContrast", "Custom" };
    }

    public string SelectedTheme { get; set; } = "System";
}