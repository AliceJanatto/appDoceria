namespace APPDoceria.Paginas;

public partial class KitsPage : ContentPage
{
	public KitsPage()
	{
		InitializeComponent();
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }
}