namespace GameEngine;

public partial class ProfilPage : ContentPage
{
	public ProfilPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("", "Вы действительно хотите изменить?", "Нет", "Ок");
    }
}