namespace APPDoceria.Paginas;

public partial class BrigadeiroPage : ContentPage
{
	public BrigadeiroPage()
	{
		InitializeComponent();
	}
    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }
}