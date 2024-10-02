namespace MauiControls.Pages;

public partial class MauiEditControls : ContentPage
{
	public MauiEditControls()
	{
		InitializeComponent();
        this.BindingContext = this;
        this.IsBusy = false;
        BtnLogin.Clicked += BtnLogin_Clicked;
	}

    private async void BtnLogin_Clicked(object? sender, EventArgs e)
    {
        this.IsBusy = true;

        await Task.Delay(8000);

        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    //private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    string oldText = e.OldTextValue;
    //    string newText = e.NewTextValue;
    //    string myText = entry1.Text;

    //    await DisplayAlert("Entry1 - TextChanged", $"{oldText}" + $" - {newText} - {myText}", "Ok");
    //}

    //private async void entry1_Completed(object sender, EventArgs e)
    //{
    //    string text = (sender as Entry).Text;
    //    await DisplayAlert("Entry1 - Completed", $"{text}", "Ok");

    //}

    //private async void Button_Clicked(object sender, EventArgs e)
    //{
    //    await progressBar.ProgressTo(0.90, 1000, Easing.Linear);
    //}
}