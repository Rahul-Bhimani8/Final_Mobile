namespace iStore.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();


        PopulateInventorySummary();


        PopulateRecentActivity();


        PopulateRecentItems();


        PopulateStockLevels();
    }
    private void PopulateInventorySummary()
    {
        //itemsCountLabel.Text = "Items: 100";
        //foldersCountLabel.Text = "Folders: 20";
        //totalQuantityLabel.Text = "Total Quantity: 500";
        // totalValueLabel.Text = "$10,000"; // Placeholder for total value
    }

    private void PopulateRecentActivity()
    {

        // recentActivityListView.ItemsSource = GetRecentActivityItems();
    }

    private void PopulateRecentItems()
    {

        // recentItemsListView.ItemsSource = GetRecentItems();
    }

    private void PopulateStockLevels()
    {

        // stockLevelsChart.Chart = GetStockLevelsChart();
    }
}