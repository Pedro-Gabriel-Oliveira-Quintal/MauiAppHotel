using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new ContratacaoHospedagem();
    }
}