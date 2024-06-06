namespace APPDoceria.Paginas;

public partial class TrufasPage : ContentPage
{
	public TrufasPage()
	{
		InitializeComponent();
	}
    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }
}