using BMI_Calculator_MAUI.MVVM.Views;

namespace BMI_Calculator_MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BMIView();
        }
    }
}
