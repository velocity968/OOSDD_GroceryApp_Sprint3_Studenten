using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
	public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    private void OnGroceryItemSelected(object sender, SelectionChangedEventArgs e)
    {
        ((CollectionView)sender).SelectedItem = null;
    }

}