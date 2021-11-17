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
        private readonly HangarCollection hangarCollection; // Объект от класса-коллекции парковок

        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width, pictureBoxHangar.Height);
        }
        private void ReloadLevels()
        {
            int index = listBoxHangars.SelectedIndex;
            listBoxHangars.Items.Clear();
            for (int i = 0; i < hangarCollection.Keys.Count; i++)
            {
                listBoxHangars.Items.Add(hangarCollection.Keys[i]);
            }
            if (listBoxHangars.Items.Count > 0 && (index == -1 || index >= listBoxHangars.Items.Count))
            {
                listBoxHangars.SelectedIndex = 0;
            }
            else if (listBoxHangars.Items.Count > 0 && index > -1 && index < listBoxHangars.Items.Count)
            {
                listBoxHangars.SelectedIndex = index;
            }

        } // Заполнение listBoxLevels


        private void Draw()
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangarCollection[listBoxHangars.SelectedItem.ToString()].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        } //метод отрисовки парковки

        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameHangar.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hangarCollection.AddParking(textBoxNameHangar.Text);
            ReloadLevels();
            Draw();
        } // Обработка нажатия кнопки "Добавить ангар"

        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hangarCollection.DelParking(textBoxNameHangar.Text);
                    ReloadLevels();
                }
            }

        } // Обработка нажатия кнопки "Удалить ангар"

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Warplane(100, 1000, dialog.Color);
                    if (hangarCollection[listBoxHangars.SelectedItem.ToString()] + plane >= 0)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        } //обработка нажатия кнопки "Приземлить военный самолёт"

        private void buttonSetStorm_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new Stormtrooper(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                        if (hangarCollection[listBoxHangars.SelectedItem.ToString()] + plane >= 0)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Парковка переполнена");

                        }
                    }
                }
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                if (listBoxHangars.SelectedIndex > -1 && maskedTextBox.Text != "")
                {

                    var plane = hangarCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (plane != null)
                    {
                        FormPlane form = new FormPlane();
                        form.SetPlane(plane);
                        form.ShowDialog();
                    }
                    Draw();
                }
            }
        } // Обработка нажатия кнопки "Забрать"


        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        } // Метод обработки выбора элемента на listBoxLevels
    }
}

