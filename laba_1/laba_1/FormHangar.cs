using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsStormtrooper
{
    public partial class FormHangar : Form
    {
        private readonly HangarCollection hangarCollection; // Объект от класса-коллекции парковок
        private readonly Logger logger; // Логгер

        public FormHangar()
        {
            InitializeComponent();
            hangarCollection = new HangarCollection(pictureBoxHangar.Width, pictureBoxHangar.Height);
            logger = LogManager.GetCurrentClassLogger();

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
                MessageBox.Show("Введите название ангара", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили ангар {textBoxNameHangar.Text}");
            hangarCollection.AddParking(textBoxNameHangar.Text);
            ReloadLevels();
            Draw();
        } // Обработка нажатия кнопки "Добавить ангар"
        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            if (listBoxHangars.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить ангар { listBoxHangars.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили ангар{listBoxHangars.SelectedItem.ToString()}");
                    hangarCollection.DelParking(textBoxNameHangar.Text);
                    ReloadLevels();
                }
            }

        } // Обработка нажатия кнопки "Удалить ангар"
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                if (listBoxHangars.SelectedIndex > -1 && maskedTextBox.Text != "")
                {
                    try
                    {
                        var plane = hangarCollection[listBoxHangars.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                        if (plane != null)
                        {
                            FormPlane form = new FormPlane();
                            form.SetPlane(plane);
                            form.ShowDialog();

                            logger.Info($"Изъят самолёт {plane} с места{maskedTextBox.Text}");

                        }
                        Draw();
                    }
                    catch (HangarNotFoundException ex)
                    {
                        logger.Warn($"Попытка забрать самолёт с не существующего места");
                        MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        logger.Warn($"Неизвестная неудачная попытка забрать самолёт");
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        } // Обработка нажатия кнопки "Забрать"
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку{listBoxHangars.SelectedItem.ToString()}");
            Draw();
        } // Метод обработки выбора элемента на listBoxLevels
        private void buttonCreatePlane_Click(object sender, EventArgs e)
        {
            var formPlaneConfig = new FormPlaneConfig();
            formPlaneConfig.AddEvent(AddPlane);
            formPlaneConfig.Show(); // вызов второй формы, не блокируя первую
        } // Обработка нажатия кнопки "Приземлить самолёт"
        private void AddPlane(Vehicle plane)
        {
            if (plane != null && listBoxHangars.SelectedIndex > -1)
            {
                try
                {
                    if (((hangarCollection[listBoxHangars.SelectedItem.ToString()]) + plane ) != -1)
                    {
                        Draw();
                        logger.Info($"Добавлен самолёт {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Самолёт не удалось приземлить");
                    }
                }
                catch (PlaneNullException ex) {
                    logger.Warn($"Попытка приземлить неопознанный объект");
                    MessageBox.Show(ex.Message, "Неопознанный объект", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (HangarOverflowException ex)
                {
                    logger.Warn($"Попытка приземлить самолёт в уже заполненный ангар");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка приземлить самолёт в ангар");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }// Метод добавления машины
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка сохранения файла");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangarCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    logger.Warn($"Попытка найти не существующий фаил для загрузки");
                    MessageBox.Show(ex.Message, "Фаил отсутсвует", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (FileFormatException ex)
                {
                    logger.Warn($"Попытка загрузки файла с неверным форматом");
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (TypeLoadException ex)
                {
                    logger.Warn($"Попытка загрузки в депо неизвестного типа обЪекта(ов)");
                    MessageBox.Show(ex.Message, "Неверный тип загружаемого объекта", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn($"Неизвестная неудачная попытка загрузки файла");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

