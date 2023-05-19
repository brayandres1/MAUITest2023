namespace MAUITest;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		labelSlider.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        labelSlider.Text = stepper.Value.ToString();
    }
}