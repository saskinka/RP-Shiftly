using Microsoft.Extensions.DependencyInjection;

namespace RP_shiftly
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            UserAppTheme = AppTheme.Light;     // iba meni vzhlad na svetlo 
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}