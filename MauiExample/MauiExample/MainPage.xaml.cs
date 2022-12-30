using MauiExample.Helpers;

namespace MauiExample;

public partial class MainPage : ContentPage
{
	int count = 0;
	Logger logger = new Logger() { EnabledLevel = LogLevel.Warning };

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var time = DateTime.Now;
		count++;

		if (count == 1)
        {
            CounterBtn.Text = $"Clicked {count} times";
            logger.LogMessage(LogLevel.Trace, $"Information Level. CurrentTime: {time}. This is an information notice. It won't be printed.");
        }
        else if (count < 5)
        {
            CounterBtn.Text = $"Clicked {count} times. don't overdo it!";
            logger.LogMessage(LogLevel.Warning, $"Warning Level. CurrentTime: {time}. This is an warning for clicking {count} times. It will be printed.");
        }
        else if (count < 10)
		{
			CounterBtn.Text = $"Clicked {count} times. You asked for it!";
            logger.LogMessage(LogLevel.Error, $"Error Level. CurrentTime: {time}. This is an error for clicking {count} times. It will be printed.");
        }
        else
		{
            CounterBtn.Text = $"Clicked {count} times. fatality!!!";
            logger.LogMessage(LogLevel.Error, $"Critical Level. CurrentTime: {time}. This is an error for clicking {count} times. Unacceptable! It will be printed.");
        }


        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

