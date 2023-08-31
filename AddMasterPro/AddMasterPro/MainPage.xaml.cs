namespace AddMasterPro;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		Title = "Add Master Pro";
	}

    void AddClick(System.Object sender, System.EventArgs e)
    {
        double dblNum1, dblNum2;

        Double.TryParse(txtNum1.Text, out dblNum1);
        Double.TryParse(txtNum2.Text, out dblNum2);

        lblAnswer.Text = (dblNum1 + dblNum2).ToString();
    }

    void ClearClick(System.Object sender, System.EventArgs e)
    {
        txtNum1.Text = "";
        txtNum2.Text = "";
        lblAnswer.Text = "0";
    }
}


