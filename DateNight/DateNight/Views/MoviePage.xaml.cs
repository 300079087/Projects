namespace DateNight.Views;

public partial class MoviePage : ContentPage
{
	public MoviePage()
	{
		InitializeComponent();
	}

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        App.DateCalc.MovieCost = txtMovie.Text;

    }
}
