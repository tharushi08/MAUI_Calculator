namespace simpleCalculator;

public partial class MainPage : ContentPage
{
	int currentState = 1;
	string operatorMath;
	double firsNum, secondNum;


	public MainPage()
	{
		InitializeComponent();
	}

	void OnClear(object sender, EventArgs e)
	{

	}

	void OnSquareRoot(object sender, EventArgs e)
	{

	}

	void OnNumberSelection (object sender, EventArgs e)
	{
		Button button = (Button)sender;
		string btnPressed = button.Text;

		if(this.result.Text == "0" || currentState < 0)
		{
			this.result.Text =  string.Empty;
			if (currentState < 0)
				currentState *= -1;
			
		}

		this.result.Text = btnPressed;
		double number;
		if(double.TryParse(this.result.Text,out number))
		{

		}
	}


}

