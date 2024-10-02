using System.Text.Json;

namespace MauiResources
{
    public partial class MainPage : ContentPage
    {
        Person person;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadMauiAsset();
        }

        async Task LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("demo.json");
            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();

            var person = JsonSerializer.Deserialize<Person>(contents);

            BindingContext = person;
        }
    }

}

public class Person
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int Age { get; set; }

    public string? Photo { get; set; }
}
