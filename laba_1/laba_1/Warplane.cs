using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba_1
{
	public class Warplane : Vehicle
	{
		protected readonly int planeWidth = 220;
		protected readonly int planeHeight = 130;
		public Warplane(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		protected Warplane(int maxSpeed, float weight, Color mainColor, int planeWidth, int planeHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.planeWidth = planeWidth;
			this.planeHeight = planeHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step  + 70 < _pictureWidth - planeWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX + step - 30 > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY + step - 100 > 0) 
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step + 30 < _pictureHeight - planeHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor);
			pen.Width = 1.0f;
			Brush fill = new SolidBrush(Color.FromArgb(0, 0, 0));
			Brush fill2 = new SolidBrush(Color.FromArgb(127, 127, 127));

			g.FillRectangle(fill2, _startPosX, _startPosY, 190, 30); // корпус
			g.DrawRectangle(pen, _startPosX, _startPosY, 190, 30);

			PointF p1 = new PointF(_startPosX - 30, _startPosY + 15);
			PointF p2 = new PointF(_startPosX, _startPosY + 30);
			PointF p3 = new PointF(_startPosX, _startPosY);
			PointF[] pol1 =
				{
					p1,
					p2,
					p3,
				};
			g.FillPolygon(fill, pol1);

			p1 = new PointF(_startPosX + 60, _startPosY);
			p2 = new PointF(_startPosX + 60, _startPosY - 100);
			p3 = new PointF(_startPosX + 70, _startPosY - 100);
			PointF p4 = new PointF(_startPosX + 90, _startPosY);
			PointF[] pol2 =
			{
					 p1,
					 p2,
					 p3,
					 p4,
				};
			g.FillPolygon(fill2, pol2);
			g.DrawPolygon(pen, pol2);


			p1 = new PointF(_startPosX + 60, _startPosY + 30);
			p2 = new PointF(_startPosX + 60, _startPosY + 130);
			p3 = new PointF(_startPosX + 70, _startPosY + 130);
			p4 = new PointF(_startPosX + 90, _startPosY + 30);
			PointF[] pol3 =
			{
					 p1,
					 p2,
					 p3,
					 p4,
				};
			g.FillPolygon(fill2, pol3);
			g.DrawPolygon(pen, pol3);

			p1 = new PointF(_startPosX + 150, _startPosY);
			p2 = new PointF(_startPosX + 150, _startPosY - 20);
			p3 = new PointF(_startPosX + 190, _startPosY - 55);
			p4 = new PointF(_startPosX + 190, _startPosY);
			PointF[] pol4 =
			{
					 p1,
					 p2,
					 p3,
					 p4,
				};
			g.FillPolygon(fill2, pol4);
			g.DrawPolygon(pen, pol4);

			p1 = new PointF(_startPosX + 150, _startPosY + 30);
			p2 = new PointF(_startPosX + 150, _startPosY + 50);
			p3 = new PointF(_startPosX + 190, _startPosY + 85);
			p4 = new PointF(_startPosX + 190, _startPosY + 30);
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
	}
}
        



