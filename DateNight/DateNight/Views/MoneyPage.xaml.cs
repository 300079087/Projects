namespace DateNight.Views;

public partial class MoneyPage : ContentPage
{
	public MoneyPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        try
        {
            lblDisplay.Text = App.DateCalc.GetTotalCost();
        }
        catch (Exception ex)
        {
            lblDisplay.Text = "$0.00";
            DisplayAlert("Error", ex.Message, "Ok");
        };
        
    }

}
