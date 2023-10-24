namespace DateNight.Views;

public partial class CoffeePage : ContentPage
{
	public CoffeePage()
	{
		InitializeComponent();
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        App.DateCalc.CoffeeCost = txtCoffee.Text;

    }


}
