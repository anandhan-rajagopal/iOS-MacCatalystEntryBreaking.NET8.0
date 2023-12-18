namespace MacEntrySample
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
            entry.Text = "Text Updated from Code Behind but color doest not applied";
        }
    }

}
