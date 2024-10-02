namespace BillSplitter
{

    public partial class MainPage : ContentPage
    {
        decimal bill;
        int tip;
        int numPeople = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void txtConta_Completed(object sender, EventArgs e)
        {
            bill = decimal.Parse(txtConta.Text);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            //Total gorjeta
            var totalTip =
                 (bill * tip) / 100;


            var tipPerPerson = (totalTip / numPeople);
            lblGorjetaPessoa.Text = $"{tipPerPerson:C}";

            //Subtotal
            var subtotal = (bill / numPeople);
            lblSubtotal.Text = $"{subtotal:C}";

            //Total
            var totalPerPerson =
                 (bill + totalTip) / numPeople;
            lblTotal.Text = $"{totalPerPerson:C}";
        }

        private void sldGorjeta_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tip = (int)sldGorjeta.Value;
            lblGorjeta.Text = $"Tip: {tip}%";
            CalculateTotal();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = (Button)sender;
                var percentage =
                     int.Parse(btn.Text.Replace("%", ""));
                sldGorjeta.Value = percentage;
            }
        }

        private void btnMenos_Clicked(object sender, EventArgs e)
        {
            if (numPeople > 1)
            {
                numPeople--;
            }
            lblNoPessoas.Text = numPeople.ToString();
            CalculateTotal();
        }

        private void btnMais_Clicked(object sender, EventArgs e)
        {
            numPeople++;
            lblNoPessoas.Text = numPeople.ToString();
            CalculateTotal();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            bill = 0.00m;
            tip = 0;
            txtConta.Text = "";
            sldGorjeta.Value = 0;
            lblNoPessoas.Text = "1";
            numPeople = 1;
            CalculateTotal();
        }
    }
}