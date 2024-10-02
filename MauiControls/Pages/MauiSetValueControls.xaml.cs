using System.Globalization;

namespace MauiControls.Pages;

public partial class MauiSetValueControls : ContentPage
{
	public MauiSetValueControls()
	{
		InitializeComponent();
	}

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
            await DisplayAlert("CheckBox", "Selected", "OK");
        }
		else
		{
             await DisplayAlert("CheckBox", "Unselected", "OK");
        }
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Selected", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Unselected", "OK");
        }
    }

    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Selected", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Unselected", "OK");
        }
    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblSlider.Text = Math.Round(slider1.Value, 2).ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblStepper.Text = $"Valor do Stepper {stepper1.Value}";
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch", "On", "OK");
        }
        else
        {
            await DisplayAlert("Switch", "Off", "OK");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-PT");
        var date = (sender as DatePicker).Date;

        var selectedDate = date.ToString("d", culture);

        await DisplayAlert("Selected Date: ", selectedDate, "Ok");
    }

    private async void time1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (time1 != null)
        {
            var selectedTime = time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Selected Time: ", selectedTime, "Ok");
        }
    }
}