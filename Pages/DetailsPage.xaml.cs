namespace iStore.Pages;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(string productName)
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}