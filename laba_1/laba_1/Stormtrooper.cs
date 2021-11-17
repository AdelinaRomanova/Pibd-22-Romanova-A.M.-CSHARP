using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsStormtrooper
{
	class Stormtrooper
	{
		private float _startPosX; 
		private float _startPosY;
		private int _pictureWidth;
		private int _pictureHeight;
		private readonly int planeWidth = 250;
		private readonly int planeHeight = 230;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; } 
		public Color DopColor { private set; get; } 
		public bool Wings { private set; get; }/// Признак наличия крыльев
		public bool Gun { private set; get; }  /// Признак наличия пушек
		public bool Turbo { private set; get; }/// Признак наличия ускорения
		public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool wings, bool gun, bool turbo)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			Wings = wings;
			Gun = gun;
			Turbo = turbo;
		}
		//Установка позиции автомобиля
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		//Изменение направления пермещения
		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - planeWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - planeHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		//Отрисовка штурмовика
		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor);
			pen.Width = 1.0f;
			Pen pen2 = new Pen(DopColor);
			pen2.Width = 2.0f;
			Brush br2 = new SolidBrush(DopColor);
			Brush fill = new SolidBrush(Color.FromArgb(0, 0, 0));
			Brush fill2 = new SolidBrush(Color.FromArgb(127, 127, 127));
			Brush fill3 = new SolidBrush(Color.FromArgb(109, 54, 54));
			Brush fill4 = new SolidBrush(Color.FromArgb(239, 52, 62));
			Brush fill5 = new SolidBrush(Color.FromArgb(240, 96, 0));

			if (Gun)
			{ //пушки
				g.DrawEllipse(pen2, _startPosX + 70, _startPosY + 70, 40, 20);
				g.FillEllipse(fill3, _startPosX + 70, _startPosY + 70, 40, 20);
				g.DrawEllipse(pen2, _startPosX + 75, _startPosY + 50, 27, 15);
				g.FillEllipse(fill3, _startPosX + 75, _startPosY + 50, 27, 15);
				g.DrawEllipse(pen2, _startPosX + 70, _startPosY + 140, 40, 20);
				g.FillEllipse(fill3, _startPosX + 70, _startPosY + 140, 40, 20);
				g.DrawEllipse(pen2, _startPosX + 75, _startPosY + 165, 27, 15);
				g.FillEllipse(fill3, _startPosX + 75, _startPosY + 165, 27, 15);
			}

			if (Wings)
			{
				g.FillRectangle(fill2, _startPosX + 30, _startPosY + 100, 190, 30); // корпус
				g.DrawRectangle(pen, _startPosX + 30, _startPosY + 100, 190, 30);

				PointF p1 = new PointF(_startPosX, _startPosY + 115);
				PointF p2 = new PointF(_startPosX + 30, _startPosY + 130);
				PointF p3 = new PointF(_startPosX + 30, _startPosY + 100);
				PointF[] pol1 =
					{
					p1,
					p2,
					p3,
				};
				g.FillPolygon(fill, pol1);

				p1 = new PointF(_startPosX + 90, _startPosY + 100);
				p2 = new PointF(_startPosX + 90, _startPosY);
				p3 = new PointF(_startPosX + 100, _startPosY);
				PointF p4 = new PointF(_startPosX + 120, _startPosY + 100);
				PointF[] pol2 =
				{
					 p1,
					 p2,
					 p3,
					 p4,
				};
				g.FillPolygon(fill2, pol2);
				g.DrawPolygon(pen, pol2);


				p1 = new PointF(_startPosX + 90, _startPosY + 130);
				p2 = new PointF(_startPosX + 90, _startPosY + 230);
				p3 = new PointF(_startPosX + 100, _startPosY + 230);
				p4 = new PointF(_startPosX + 120, _startPosY + 130);
				PointF[] pol3 =
				{
					 p1,
					 p2,
					 p3,
					 p4,
				};
				g.FillPolygon(fill2, pol3);
				g.DrawPolygon(pen, pol3);

				p1 = new PointF(_startPosX + 180, _startPosY + 100);
				p2 = new PointF(_startPosX + 180, _startPosY + 80);
				p3 = new PointF(_startPosX + 220, _startPosY + 45);
				p4 = new PointF(_startPosX + 220, _startPosY + 100);
				PointF[] pol4 =
				{
					 p1,
					 p2,
					 p3,
					 p4,
				};
				g.FillPolygon(fill2, pol4);
				g.DrawPolygon(pen, pol4);

				p1 = new PointF(_startPosX + 180, _startPosY + 130);
				p2 = new PointF(_startPosX + 180, _startPosY + 150);
				p3 = new PointF(_startPosX + 220, _startPosY + 185);
				p4 = new PointF(_startPosX + 220, _startPosY + 130);
				PointF[] pol5 =
				{
					 p1,
					 p2,
					 p3,
					 p4,
				};
				g.FillPolygon(fill2, pol5);
				g.DrawPolygon(pen, pol5);
			}

			if (Turbo)
			{
				PointF p1 = new PointF(_startPosX + 220, _startPosY + 100);
				PointF p2 = new PointF(_startPosX + 250, _startPosY +92);
				PointF p3 = new PointF(_startPosX + 220, _startPosY + 130);
				PointF[] pol6 =
				{
					 p1,
					 p2,
					 p3,
				};
				g.DrawPolygon(pen2, pol6);
				g.FillPolygon(fill5, pol6);

				p1 = new PointF(_startPosX + 220, _startPosY + 130);
				p2 = new PointF(_startPosX + 250, _startPosY + 138);
				p3 = new PointF(_startPosX + 220, _startPosY + 100);
				PointF[] pol7 =
				{
					 p1,
					 p2,
					 p3,
				};
				g.DrawPolygon(pen2, pol7);
				g.FillPolygon(fill5, pol7);

				p1 = new PointF(_startPosX + 220, _startPosY + 100);
				p2 = new PointF(_startPosX + 270, _startPosY + 115);
				p3 = new PointF(_startPosX + 220, _startPosY + 130);
				PointF[] pol8 =
				{
					 p1,
					 p2,
					 p3,
				};
				g.DrawPolygon(pen2, pol8);
				g.FillPolygon(fill4, pol8);
			}
		}
	}
}


