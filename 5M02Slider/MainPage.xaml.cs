namespace _5M02Slider
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void onSliderChanged(object sender, EventArgs e)
        {
            lblNapis.FontSize = slSlider.Value;
            lblInfo.Text = $"rozmiar czcionki: {slSlider.Value}";
        }
        private void onBtnClicked(object sender, EventArgs e)
        {
            slSlider.Value = 30;
        }
    }

}
