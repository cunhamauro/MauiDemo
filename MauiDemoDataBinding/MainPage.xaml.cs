using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    var product = new Product
        //    {
        //        Name = "Samsung S24",
        //        Price = 800.00m,
        //        Stock = 9,
        //    };

        //    //Binding productBinding = new Binding();
        //    //productBinding.Source = product;
        //    //productBinding.Path = "Name";

        //    //lblName.SetBinding(Label.TextProperty, productBinding);

        //    Binding nameBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Name",
        //        StringFormat = "Product: {0}"
        //    };

        //    lblName.SetBinding(Label.TextProperty, nameBinding);

        //    Binding priceBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Price",
        //        StringFormat = "Price: {0}"
        //    };

        //    lblPrice.SetBinding(Label.TextProperty, priceBinding);

        //    Binding stockBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Stock",
        //        StringFormat = "Stock: {0}"
        //    };

        //    lblStock.SetBinding(Label.TextProperty, stockBinding);
        //}
    }

}
