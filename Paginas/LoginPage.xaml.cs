namespace APPDoceria.Paginas;
using APPDoceria.Model;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email, senha);
        if (usuario != null)
        {
            await DisplayAlert("Sucesso", "Login efetuado com sucesso", "OK");
            await Navigation.PushAsync(new AppShell());
            App.Usuario = usuario;
        }
        else
        {
            await DisplayAlert("Erro", "Usuario ou senha inválidos / vazios", "OK");
            return;
        }
    }

    private async void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditaUsuario());
    }
}