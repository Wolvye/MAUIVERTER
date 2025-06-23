using MAUIVERTER.MVVM.ViewModels;

namespace MAUIVERTER.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}
}