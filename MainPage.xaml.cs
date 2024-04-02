namespace DiceRollerActivity
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSortear(object sender, EventArgs e)
        {
            double numeroDado = SortearDado();
            sorteadoDado.Text = numeroDado.ToString();
        }
        
        private double SortearDado()
        {
            double valorDado = Convert.ToDouble(ValueDice.Text);
            if (int.TryParse(ValueDice.Text, out int limite))
            {
                Random rand = new Random();
                int numeroSorteado = rand.Next(1, limite + 1);
                valorDado = numeroSorteado;
            }
            return valorDado;

        }
    }

}
