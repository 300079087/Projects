namespace HelloWorld;

public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		if (lblDisplay.Text == "Hello World!")
		{
			lblDisplay.Text = "Joe's cool.";
		}
		else
		{
			lblDisplay.Text = "Hello World!";
		}
    }
}


