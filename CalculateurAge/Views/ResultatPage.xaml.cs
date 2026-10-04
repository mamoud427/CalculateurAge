namespace CalculateurAge.Views;

[QueryProperty(nameof(Nom), "nom")]
[QueryProperty(nameof(Age), "age")]

public partial class ResultatPage : ContentPage
{
	public ResultatPage()
	{
		InitializeComponent();
	}
}