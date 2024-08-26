namespace MauiDrawing;

public partial class testview : ContentPage
{
	public testview()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
         Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}
