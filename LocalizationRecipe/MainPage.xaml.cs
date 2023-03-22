using LocalizationRecipe.Resources.Strings;

namespace LocalizationRecipe;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        OutputLabel.Text = AppResources.Greeting;
    }
}
