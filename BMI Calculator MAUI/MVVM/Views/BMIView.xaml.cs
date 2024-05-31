using BMI_Calculator_MAUI.MVVM.ViewModels;

namespace BMI_Calculator_MAUI.MVVM.Views;

public partial class BMIView : ContentPage
{
    public BMIView()
    {
        InitializeComponent();
        BindingContext = new BMIViewModel();
    }
}