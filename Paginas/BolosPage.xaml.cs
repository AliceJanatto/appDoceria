namespace APPDoceria.Paginas;

public partial class BolosPage : ContentPage
{
	public BolosPage()
	{
		InitializeComponent();
	}
    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }
}