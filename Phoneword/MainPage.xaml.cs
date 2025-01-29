namespace Phoneword
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public string UserName { get; set; } = "Alberto";

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count+=5;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
