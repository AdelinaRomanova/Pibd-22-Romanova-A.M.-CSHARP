using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStormtrooper
{
    public partial class FormPlane : Form
    {
        private ITransport plane;
        public FormPlane()
        {
            InitializeComponent();
        }
		//метод отрисовки самолёта
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane.DrawTransport(gr);
            pictureBoxPlane.Image = bmp;
        }
		//Обработка нажатия кнопки "Создать самолёт"
		private void buttonCreatePlane_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			plane = new Warplane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
			plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width,pictureBoxPlane.Height);
			Draw();
		}
		//Обработка нажатия кнопки "Создать штурмовик"
		private void buttonCreateStormtrooper_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			plane = new Stormtrooper(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.FromArgb(64, 0, 0), true, true, true);
			plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlane.Width,pictureBoxPlane.Height);
			Draw();
		}
		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					if (plane != null)
					{
						plane.MoveTransport(Direction.Up);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonDown":
					if (plane != null)
					{
						plane.MoveTransport(Direction.Down);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonLeft":
					if (plane != null)
					{
						plane.MoveTransport(Direction.Left);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonRight":
					if (plane != null)
					{
						plane.MoveTransport(Direction.Right);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
			}
			Draw();
		}

       
    }
}
