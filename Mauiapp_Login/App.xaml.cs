namespace Mauiapp_Login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            string? usuario_log = null;
            MainPage = new Login();

            Task.Run(async () =>
            {
                usuario_log = await SecureStorage.Default.GetAsync("usuario_logado");

                if (usuario_log != null)
                    {
                  
                        MainPage= new Protegida();
                    }
            });
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;
            return window;
        }
    }
    
}