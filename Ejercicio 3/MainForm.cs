using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_3
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void Btn_imagenClick(object sender, EventArgs e)
		{
			pic_imagen.Image = Image.FromFile("C:\\Users\\IPPESSI\\Downloads\\}cartel.jpg");
		}

	}
}
