using System.Globalization;

namespace RP_shiftly
{
    public partial class MainPage : ContentPage    // partial = trieda je rozdelena na viacere subory 
    {
        public MainPage()
        {
            InitializeComponent();     // metoda na stavanie - neodstanovat 

            Hodiny();
            Sekundy();

        }
        private void Hodiny()
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");  // armadny cas (ak USA = hh:mm:ss)
            DateLabel.Text = DateTime.Now.ToString("dddd, d. MMMM yyyy", new CultureInfo("sk-SK")); // ked tam nie je , new CultureInfo("sk-SK")) tak je to po anj
        }
        private void Sekundy()
        {
            var timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (sender, e) => Hodiny();
            timer.Start();
        }

        // zatial takto, potom prepajanie :

        private async void KliknutiePrihlasenia(object sender, EventArgs e)
        {
            // sem neskor prida overenie z databazy
            await DisplayAlert("Prihlásenie", "Zatiaľ len", "OK");
        }

        private async void KliknutieRegistracie(object sender, EventArgs e)
        {
            // sem neskor prida otvorenie registracneho formulara
            await DisplayAlert("Registrácia", "Neskor registracnz formular", "OK");
        }
        private async void StlacenieNastavenii(object sender, EventArgs e)
        {
            // sem neskor prida otvorenie registracneho formulara
            await DisplayAlert("Nastavenia", "Nastavenia farieb a to este domyslim", "OK");
        }
    }
}
