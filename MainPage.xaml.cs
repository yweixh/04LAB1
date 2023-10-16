namespace MauiApp4;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public void OnVerticalStart(object sender, EventArgs args)
	{
		target.VerticalOptions = LayoutOptions.Start;
	}
    public void OnVerticalCenter(object sender, EventArgs args)
    {
        target.VerticalOptions = LayoutOptions.Center;
    }
    public void OnVerticalEnd(object sender, EventArgs args)
    {
        target.VerticalOptions = LayoutOptions.End;
    }
    public void OnHorizontalStart(object sender, EventArgs args)
    {
        target.HorizontalOptions = LayoutOptions.Start;
    }
    public void OnHorizontalCenter(object sender, EventArgs args)
    {
        target.HorizontalOptions = LayoutOptions.Center;
    }
    public void OnHorizontalEnd(object sender, EventArgs args)
    {
        target.HorizontalOptions = LayoutOptions.End;
    }
}

