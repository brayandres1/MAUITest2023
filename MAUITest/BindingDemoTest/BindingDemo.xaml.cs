namespace MAUITest.BindingDemoTest;

public partial class BindingDemo : ContentPage
{
	public BindingDemo()
	{
		InitializeComponent();
	}

    private void btnOk_Clicked(object sender, EventArgs e)
    {
		var person = new Person
		{
			Name = "Andres Velez",
			Phone = "+57 314 577 7162",
			Address = "Calle Luna Calle Sol"
		};

		BindingContext = person;
		//lblName.SetBinding(Label.TextProperty, "Name");

		//var personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//lblName.SetBinding(Label.TextProperty, personBinding);

	}
}