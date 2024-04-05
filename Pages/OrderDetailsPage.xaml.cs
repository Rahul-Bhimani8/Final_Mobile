namespace iStore.Pages;

public partial class OrderDetailsPage : ContentPage
{
    public OrderDetailsPage()
	{
		InitializeComponent();
    }
    private async void OnProductTapped(object sender, EventArgs e)
    {
        var productName = "Dairy Milk";
        // Navigate to details page here
        await Navigation.PushAsync(new DetailsPage(productName));
    }
}