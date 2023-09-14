namespace TimerPro;
using TimerPro.Custom;

public partial class MainPage : ContentPage
{
    TimerLogic timerlogic;
    bool isRunning;

	public MainPage()
	{
		InitializeComponent();
		Title = "TimerPro";
        timerlogic = new TimerLogic();
	}

    [Obsolete]
    void Start_Clicked(System.Object sender, System.EventArgs e)
    {
        btnStart.IsEnabled = false;
        btnStop.IsEnabled = true;
        isRunning = true;

        Device.StartTimer(TimeSpan.FromSeconds(1), () => {
            if (isRunning)
            {
                timerlogic.SetTickCounter();
                lblDisplay.Text = timerlogic.GetFormatedString();
            }

            return isRunning;
        });
    }

    void Stop_Clicked(System.Object sender, System.EventArgs e)
    {
        btnStart.IsEnabled = true;
        btnStop.IsEnabled = false;
        isRunning = false;
    }

    void Reset_Clicked(System.Object sender, System.EventArgs e)
    {
        isRunning = false;
        timerlogic.Reset();
        lblDisplay.Text = timerlogic.GetFormatedString();
    }
}


