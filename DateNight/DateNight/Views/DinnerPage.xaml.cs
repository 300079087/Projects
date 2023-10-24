namespace DateNight.Views;

public partial class DinnerPage : ContentPage
{
	public DinnerPage()
	{
		InitializeComponent();
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        App.DateCalc.DinnerCost = txtDinner.Text;

    }
}
