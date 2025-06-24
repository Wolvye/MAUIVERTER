using MAUIVERTER.MVVM.ViewModels;

namespace MAUIVERTER.MVVM.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConverterviewModel();
	}



    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        var viewModel=
            (ConverterviewModel)BindingContext;
        viewModel.Convert();
    }
}