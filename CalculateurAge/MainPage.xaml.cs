namespace CalculateurAge
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculerClicked(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryNom.Text))
            {
                DisplayAlert("Erreur", "Entrer un Nom", "OK");
                return;
            }
            DateTime d = pickerDate.Date;
            int age = DateTime.Today.Year - d.Year;

            if (d.Date > DateTime.Today.AddYears(-age)) age--;

            lblResultat.Text = $"{entryNom.Text}, Vous avez {age} ans";
            lblResultat.IsVisible = true;
            //count++;

            //if (count == 1)
            //    btnCalculer.Text = $"Clicked {count} time";
            //else
            //    btnCalculer.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(btnCalculer.Text);
        }
    }
}
