namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void segundo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Materias.SegundoAno());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void primeiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Materias.PrimeiroAno());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void terceiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Materias.TerceiroAno());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
