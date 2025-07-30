namespace Mauiapp_Login;

public partial class Protegida : ContentPage
{
	public Protegida()
	{
		InitializeComponent();
		string? usuario_logado = null;

		Task.Run(async () =>
		{
			usuario_logado = await SecureStorage.Default.GetAsync("usuario_logado");
			usuario_text.Text = $"Bem vindo, {usuario_logado}";
		});
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		bool confirmar = await DisplayAlert("Desconectar", "Tem certeza que deseja desconectar?", "Sim", "Não");
		if (confirmar) {
			SecureStorage.Default.Remove("usuario_logado");
			App.Current.MainPage= new Login();
		
		}

    }
}