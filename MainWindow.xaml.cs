using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Pizza
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

		private void buttonOsszegzes_Click(object sender, RoutedEventArgs e)
		{
			string teszta = listBoxTesztak.SelectedItem?.ToString() ?? "(Nem választottál tésztát)";
			string meret = (comboBoxMeret.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "(Nem választottál méretet)";

			List<string> feltetek = new List<string>();
			if (checkBoxSajt.IsChecked == true) feltetek.Add("Sajt");
			if (checkBoxSonka.IsChecked == true) feltetek.Add("Sonka");
			if (checkBoxGomba.IsChecked == true) feltetek.Add("Gomba");
			if (checkBoxOlivabogyo.IsChecked == true) feltetek.Add("Olívabogyó");
			if (checkBoxKukorica.IsChecked == true) feltetek.Add("Kukorica");

			string feltetSzoveg = feltetek.Count > 0 ? string.Join(", ", feltetek) : "(Nincs plusz feltét)";
			string atvetel = radioButtonHazhoz.IsChecked == true ? "Házhozszállítás"
				: radioButtonSzemelyes.IsChecked == true ? "Személyes átvétel"
				: "(Nincs megadva)";

			string osszegzes = $"Tészta: {teszta}\nMéret: {meret}\nFeltétek: {feltetSzoveg}\nÁtvételi mód: {atvetel}";
			labelOsszegzes.Content = osszegzes;
		}
	}
}