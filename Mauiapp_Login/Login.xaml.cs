namespace Mauiapp_Login;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();


	}	

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button btn = (Button)sender;
		if (txt_senha.IsPassword == true)
		{
			txt_senha.IsPassword = false;
		}
		else
		{
			txt_senha.IsPassword = true;
		}
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		try
		{
			List<DadosUuarios> listausuarios = new List<DadosUuarios>()
			{
				new DadosUuarios()
				{
					Usuario="Joao",
					Senha="1234"

				},
				new DadosUuarios()
				{
					Usuario="Maria",
					Senha="4321"
				}
			};
			DadosUuarios dadosdigitados= new DadosUuarios()
			{
				Usuario= txt_nome.Text,
				Senha= txt_senha.Text
			};
			if (listausuarios.Any(i => dadosdigitados.Usuario == i.Usuario && dadosdigitados.Senha == i.Senha))
			{
				SecureStorage.Default.SetAsync("usuario_logado", dadosdigitados.Usuario);
				App.Current.MainPage = new Protegida();
			}
			else
			{
				throw new Exception("Usuario ou senha incorretos");
			}

		}
		catch (Exception ex) 
		{
			DisplayAlert("Ops", ex.Message, "Fechar");
		
		}
    }
}