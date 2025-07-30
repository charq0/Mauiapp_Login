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

    }
}