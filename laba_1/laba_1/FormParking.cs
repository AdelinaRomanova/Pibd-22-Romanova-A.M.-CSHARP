using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba_1
{
    public partial class FormParking : Form
    {
        private readonly Parking<Warplane> parking; //объект от класса парковки

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Warplane>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        } //метод отрисовки парковки

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Warplane(100, 1000, dialog.Color);
                int place = parking + plane;
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
                    int place = parking + plane;
                    Draw();
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = parking - Convert.ToInt32(maskedTextBox.Text);
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

