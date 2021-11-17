﻿using System;
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
        private Stormtrooper storm;
        public FormPlane()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
			storm.DrawTransport(gr);
            pictureBoxPlane.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
			storm = new Stormtrooper();
			storm.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.FromArgb(64, 0, 0), true, true, true);
			storm.SetPosition(rnd.Next(10, 400), rnd.Next(10, 400), pictureBoxPlane.Width, pictureBoxPlane.Height);
            Draw();
        }

		private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					if (storm != null)
					{
						storm.MoveTransport(Direction.Up);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonDown":
					if (storm != null)
					{
						storm.MoveTransport(Direction.Down);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonLeft":
					if (storm != null)
					{
						storm.MoveTransport(Direction.Left);
					}
					else
					{
						MessageBox.Show("Сначала создайте объект!");
						return;
					}
					break;
				case "buttonRight":
					if (storm != null)
					{
						storm.MoveTransport(Direction.Right);
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
