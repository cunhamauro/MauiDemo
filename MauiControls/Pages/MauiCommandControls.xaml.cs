namespace MauiControls.Pages;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
		InitializeComponent();
	}

    private async void btnDemo_Clicked(object sender, EventArgs e)
    {
		await lblDemo.RelRotateTo(360, 2000);
		await DisplayAlert("Button", "Task completed","OK");
    }

    private async void btnImgDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 5000);
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = sender as RadioButton;
        if (selectedRadioButton != null && lblPets2 != null)
        {
            lblPets2.Text = $"Selected: {selectedRadioButton.Value}";
            lblPets2.FontSize = 20;
        }
    }

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = sender as SearchBar;
        await DisplayAlert("...Searching...", $"{searchBar.Text}", "Ok");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", "Touched element", "Ok");
    }
}