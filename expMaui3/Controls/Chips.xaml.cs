namespace expMaui3.Controls;

public partial class Chips
{
	public static readonly BindableProperty ItemsProperty =
		BindableProperty.Create(nameof(Items), typeof(string[]), typeof(Chips));

	public string[] Items
	{
		get => (string[])GetValue(ItemsProperty);
		set => SetValue(ItemsProperty, value);
	}

	public Chips()
	{
		InitializeComponent();
	}
}