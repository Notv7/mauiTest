namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count--;

            if (count == 11)
                CounterBtn.Text = $"touched {count} time";
            else
                CounterBtn.Text = $"Touched {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
