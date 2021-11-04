using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace laba_1
{
    public class Parking<T> where T: class,ITransport
    {
        private readonly List<T> _places; // список объектов, которые храним
        private readonly int _maxCount; // максимальное количество мест на парковке
        private readonly int pictureWidht; //ширина отрисовки окна
        private readonly int pictureHeight; //высота отрисовки окна
        private readonly int _placeSizeWidht = 280; //ширина парковочного места
        private readonly int _placeSizeHeight = 240; //высота парковочного места

        public Parking(int picWidht, int picHeight) {
            int widht = picWidht / _placeSizeWidht;
            int height = picHeight / _placeSizeHeight;
            _maxCount = widht * height;
            pictureWidht = picWidht;
            pictureHeight = picHeight;
            _places = new List<T>();
        } //конструктор

        public static int operator +(Parking<T> p, T plane) {
            if (p._places.Count >= p._maxCount)
                return -1;
            p._places.Add(plane);
            return p._places.Count;
        } //перегрузка оператора сложения

        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 && index > p._places.Count)
            {
                return null;
            }
            T plane = p._places[index];
            p._places.RemoveAt(index);
            return plane;

        }//перегрузка оператора вычитания

        public void Draw(Graphics g) {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++) {
                _places[i].SetPosition(4 + i % 3 * _placeSizeWidht, i / 3 * _placeSizeHeight + 4, pictureWidht, pictureHeight);
                _places[i].DrawTransport(g);
            }
        } //метод отрисовки парковки

        private void DrawMarking(Graphics g) {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidht / _placeSizeWidht; i++) {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidht, j * _placeSizeHeight, i * _placeSizeWidht + _placeSizeWidht / 3, j * _placeSizeHeight);
                }//линия разметки места
                g.DrawLine(pen, i * _placeSizeWidht, 0, i * _placeSizeWidht, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

    }
}
