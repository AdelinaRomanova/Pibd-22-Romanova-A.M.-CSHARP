using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace laba_1
{
    public class Parking<T> where T: class,ITransport
    {
        private readonly T[] _places; //массив объектов, которые храним
        private readonly int pictureWidht; //ширина отрисовки окна
        private readonly int pictureHeight; //высота отрисовки окна
        private readonly int _placeSizeWidht = 190; //ширина парковочного места
        private readonly int _placeSizeHeight = 120; //высота парковочного места

        public Parking(int picWidht, int picHeight) {
            int widht = picWidht / _placeSizeWidht;
            int height = picHeight / _placeSizeHeight;
            _places = new T[widht * height];
            pictureWidht = picWidht;
            pictureHeight = picHeight;
        } //конструктор

        public static bool operator +(Parking<T> p, T plane) {
            for (int i = 0; i < p._places.Length; i++) {
                if (p._places[i] == null)
                {
                    p._places[i] = plane;
                    return true;
                }
            }
            return false;
        } //перегрузка оператора сложения

        public static T operator -(Parking<T> p, int index) {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (i == index) { }
                T plane = p._places[index];
                p._places[i] = null;
                return plane;
            }
            return null;
        } //перегрузка оператора вычитания

        public void Draw(Graphics g) {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++) {
                _places[i]?.DrawTransport(g);
            }
        } //метод отрисовки парковки

        private void DrawMarking(Graphics g) {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidht / _placeSizeWidht; i++) { 
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidht, j * _placeSizeHeight, i *
                   _placeSizeWidht + _placeSizeWidht / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidht, 0, i * _placeSizeWidht,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

    }
}
