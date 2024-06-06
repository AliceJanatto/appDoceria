namespace APPDoceria.Paginas;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}
    

    private async void btnKits_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KitsPage());
    }

    private async void btnBrigadeiros_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BrigadeiroPage());
    }

    private async void btnBolos_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BolosPage());
    }

    private async void btntrufas_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TrufasPage());
    }
}