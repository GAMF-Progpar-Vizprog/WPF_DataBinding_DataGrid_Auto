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

namespace WPF_DataBinding_DataGrid_Auto;

public partial class MainWindow : Window
{
	private List<Oktató> Oktatók;
	public MainWindow()
	{
		InitializeComponent();
		Oktatók = new List<Oktató>();
		Feltölt();
		dgAdatok.ItemsSource = Oktatók;

	}
	private void Feltölt()
	{
		var ims = (new ImageSourceConverter()).ConvertFromString("pack://application:,,,/Kepek/pacman-145855_640.png") as ImageSource;

		Oktatók.Add(new Oktató
		{
			Név = "Kutató József",
			Nem = Nem.férfi,
			VanFokozat = false,
			Honlap = new Uri("http://kutatojozsef.hu"),
			Kép = ims
		});
		ims = (new ImageSourceConverter()).ConvertFromString("pack://application:,,,/Kepek/pacman-145859_640.png") as ImageSource;
		Oktatók.Add(new Oktató
		{
			Név = "Kutató Jolán",
			Nem = Nem.nő,
			VanFokozat = true,
			Honlap = new Uri("http://kutatojolan.hu"),
			Kép = ims
		});
		ims = (new ImageSourceConverter()).ConvertFromString("pack://application:,,,/Kepek/viking-149113_640.png") as ImageSource;
		Oktatók.Add(new Oktató
		{
			Név = "Kutató Gerzson",
			Nem = Nem.férfi,
			VanFokozat = true,
			Honlap = new Uri("http://kutatogerzson.hu"),
			Kép = ims
		});
	}
}