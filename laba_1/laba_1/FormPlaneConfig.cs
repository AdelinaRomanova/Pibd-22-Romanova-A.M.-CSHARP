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
    public partial class FormPlaneConfig : Form
    {
        Vehicle plane = null;
        private event Action<Vehicle> eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();
            panelColorBlack.MouseDown += panelColor_MouseDown;
            panelColorTomato.MouseDown += panelColor_MouseDown;
            panelColorOrange.MouseDown += panelColor_MouseDown;
            panelColorBlue.MouseDown += panelColor_MouseDown;
            panelColorGreen.MouseDown += panelColor_MouseDown;
            panelColorGold.MouseDown += panelColor_MouseDown;
            panelColorWhite.MouseDown += panelColor_MouseDown;
            panelColorPink.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        } // Добавление события
        private void labelWarplane_MouseDown(object sender, MouseEventArgs e)
        {
            labelWarplane.DoDragDrop(labelWarplane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        } // передаём информацию при нажатии на "Военный самолёт"
        private void labelStormtrooper_MouseDown(object sender, MouseEventArgs e)
        {
            labelStormtrooper.DoDragDrop(labelStormtrooper.Text, DragDropEffects.Move | DragDropEffects.Copy);
        } // передаём информацию при нажатии на "Штурмовик"
        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        } // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный самолёт":
                    plane = new Warplane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Pink);
                    break;
                case "Штурмовик":
                    plane = new Stormtrooper((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Pink, Color.Purple,checkBoxGuns.Checked, checkBoxTurbo.Checked);
                    break;
            }
            DrawPlane();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        } // Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        } // Принимаем основной цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null && plane is Stormtrooper)
            {
                (plane as Stormtrooper).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }
        private void buttonAddPlane_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }
    }
}
