namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public List<string> TestItems { get; set; } = [];
    
    public MainPage()
    {
        InitializeComponent();

        for (int i = 0; i < 30; i++)
        {
            TestItems.Add("Test Test Test Test Test Test Test Test Test Test Test Test Test Test");
        }
        
        BindingContext = this;
    }
}