namespace MahjongComp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnAddClicked(object? sender, EventArgs e)
	{
		int num1 = int.Parse(InputText1.Text);
		int num2 = int.Parse(InputText2.Text);
		int sum = num1 + num2;
		CounterLbl.Text = $"Sum: {sum}";
	}
}
