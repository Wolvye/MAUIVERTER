using MAUIVERTER.MVVM.Views;

namespace MAUIVERTER
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new ConverterView());
        }
    }
}