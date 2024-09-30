namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage = new NavigationPage(new MinhaPagina());

            //navPage.BarBackground = Colors.Aquamarine;
            //navPage.BarTextColor = Colors.DarkSlateBlue;

            MainPage = new NavigationPage(new AbsoluteLayoutDemo());
        }
    }
}
