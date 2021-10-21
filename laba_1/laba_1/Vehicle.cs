using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public abstract class Vehicle : ITransport
    {
		protected float _startPosX; /// Левая координата отрисовки штурмовика
		protected float _startPosY;/// Правая кооридната отрисовки штурмовика
		protected int _pictureWidth;/// Ширина окна отрисовки
		protected int _pictureHeight;/// Высота окна отрисовки

		public int MaxSpeed { private set; get; }/// Максимальная скорость
		public float Weight { private set; get; }/// Вес штурмовика
		public Color MainColor { private set; get; } /// Основной цвет штурмовика
		public void SetPosition(int x, int y, int width, int height) {
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		abstract public void MoveTransport(Direction direction);
		abstract public void DrawTransport(Graphics g);


	}
}
