using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsStormtrooper
{
    public class Hangar<T> where T : class, ITransport
    {
        private readonly T[] _places; //массив объектов, которые храним
        private readonly int pictureWidht; 
        private readonly int pictureHeight; 
        private readonly int _placeSizeWidht = 280;
        private readonly int _placeSizeHeight = 240;

        public Hangar(int picWidht, int picHeight)
        {
            int widht = picWidht / _placeSizeWidht;
            int height = picHeight / _placeSizeHeight;
            _places = new T[widht * height];
            pictureWidht = picWidht;
            pictureHeight = picHeight;
        } //конструктор

        public static int operator +(Hangar<T> p, T plane)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = plane;
                    p._places[i].SetPosition(8 + i % 3 * p._placeSizeWidht, i / 3 * p._placeSizeHeight + 5, p.pictureWidht, p.pictureHeight);
                    return i;
                }
            }
            return -1;
        } //перегрузка оператора сложения

        public static T operator -(Hangar<T> p, int index)
        {
            if (index > 0 && index < p._places.Length)
            {
                if (p._places[index] != null)
                {
                    T plane = p._places[index];
                    p._places[index] = null;
                    return plane;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }//перегрузка оператора вычитания

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        } //метод отрисовки парковки

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidht / _placeSizeWidht; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidht, j * _placeSizeHeight, i * _placeSizeWidht + _placeSizeWidht / 3, j * _placeSizeHeight);
                }//линия разметки места
                g.DrawLine(pen, i * _placeSizeWidht, 0, i * _placeSizeWidht, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

    }
}