namespace AvaloniaStylesApp.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    
    public string SwitchTheme => "Switch theme";
    public string LabelWithStyle => "Label with style";
    public string LabelWithTheme => "Label with theme";
    public string ButtonWithStyle => "Button with style";
    public string ButtonWithTheme => "Button with theme";
    
    public string [] Themes => new [] {"System","Light", "Dark"};
    public string SelectedTheme { get; set; } = "System";
}