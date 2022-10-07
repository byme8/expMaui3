using expMaui3.Controls;
namespace expMaui3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var chips = Enumerable
            .Range(0, 10)
            .Select(o => new Chips()
            {
                Items = Enumerable
                    .Range(0, 10)
                    .Select(oo => $"Test {o}{oo}")
                    .ToArray()
            })
            .ToArray();

        var stack = new VerticalStackLayout();
        foreach (var chip in chips)
        {
            stack.Children.Add(chip);
        }

        ContentView.Content = stack;
    }
}