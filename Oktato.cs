using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_DataBinding_DataGrid_Auto
{
	public enum Nem
	{
		férfi = 1,
		nő
	};
	public class Oktató
	{
		public String Név { get; set; }
		public Nem Nem { get; set; }
		public Boolean VanFokozat { get; set; }
		public Uri Honlap { get; set; }
		public ImageSource Kép { get; set; } 
	}
}
