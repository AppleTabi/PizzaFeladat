using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
		private void buttonOsszegzes_Click(object sender, EventArgs e)
		{
			string teszta = listBoxTesztak.SelectedItem?.ToString() ?? "(Nem választottál tésztát)";
			string meret = comboBoxMeret.SelectedItem?.ToString() ?? "(Nem választottál méretet)";

			List<string> feltetek = new List<string>();
			if (checkBoxSajt.Checked) feltetek.Add("Sajt");
			if (checkBoxSonka.Checked) feltetek.Add("Sonka");
			if (checkBoxGomba.Checked) feltetek.Add("Gomba");
			if (checkBoxOlivabogyo.Checked) feltetek.Add("Olívabogyó");
			if (checkBoxKukorica.Checked) feltetek.Add("Kukorica");

			string feltetSzoveg = feltetek.Count > 0 ? string.Join(", ", feltetek) : "(Nincs plusz feltét)";
			string atvetel = radioButtonHazhoz.Checked ? "Házhozszállítás" : (radioButtonSzemelyes.Checked ? "Személyes átvétel" : "(Nincs megadva)");

			string osszegzes = $"Tészta: {teszta}\nMéret: {meret}\nFeltétek: {feltetSzoveg}\nÁtvételi mód: {atvetel}";
			labelOsszegzes.Text = osszegzes;
		}
	}
}