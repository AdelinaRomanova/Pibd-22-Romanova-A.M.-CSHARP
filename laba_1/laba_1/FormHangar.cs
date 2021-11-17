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
    public partial class FormHangar : Form
    {
        private readonly Hangar<Warplane> hangar; //объект от класса парковки

        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<Warplane>(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        } //метод отрисовки парковки

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Warplane(100, 1000, dialog.Color);
                int place = hangar + plane;
                Draw();
            } //обработка нажатия кнопки "Приземлить военный самолёт"
        }

        private void buttonSetStorm_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Stormtrooper(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    int place = hangar + plane;
                    Draw();
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = hangar - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}

