using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba_1
{
	public class Stormtrooper : Warplane
	{ 
		public Color DopColor { private set; get; } /// Дополнительный цвет
		public bool Wings { private set; get; }/// Признак наличия крыльев
		public bool Gun { private set; get; }  /// Признак наличия пушек
		public bool Turbo { private set; get; }/// Признак наличия ускорения

		public Stormtrooper(int maxSpeed, float weight, Color mainColor, Color dopColor, bool wings, bool gun, bool turbo) : base(maxSpeed, weight, mainColor, 100, 60)
		{
			DopColor = dopColor;
			Wings = wings;
			Gun = gun;
			Turbo = turbo;
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen2 = new Pen(DopColor);
			pen2.Width = 2.0f;
			Brush fill3 = new SolidBrush(Color.FromArgb(109, 54, 54));
			Brush fill4 = new SolidBrush(Color.FromArgb(239, 52, 62));
			Brush fill5 = new SolidBrush(Color.FromArgb(240, 96, 0));

			if (Gun)
			{ //пушки
				g.DrawEllipse(pen2, _startPosX + 40, _startPosY - 30, 40, 20);
				g.FillEllipse(fill3, _startPosX + 40, _startPosY - 30, 40, 20);
				g.DrawEllipse(pen2, _startPosX + 45, _startPosY - 50, 27, 15);
				g.FillEllipse(fill3, _startPosX + 45, _startPosY - 50, 27, 15);
				g.DrawEllipse(pen2, _startPosX + 40, _startPosY + 40, 40, 20);
				g.FillEllipse(fill3, _startPosX + 40, _startPosY + 40, 40, 20);
				g.DrawEllipse(pen2, _startPosX + 45, _startPosY + 65, 27, 15);
				g.FillEllipse(fill3, _startPosX + 45, _startPosY + 65, 27, 15);
			}

			base.DrawTransport(g);

			if (Turbo)
			{
				PointF p1 = new PointF(_startPosX + 190, _startPosY);
				PointF p2 = new PointF(_startPosX + 220, _startPosY - 8);
				PointF p3 = new PointF(_startPosX + 190, _startPosY + 30);
				PointF[] pol6 =
				{
					 p1,
					 p2,
					 p3,
				};
				g.DrawPolygon(pen2, pol6);
				g.FillPolygon(fill5, pol6);

				p1 = new PointF(_startPosX + 190, _startPosY + 30);
				p2 = new PointF(_startPosX + 220, _startPosY + 38);
				p3 = new PointF(_startPosX + 190, _startPosY);
				PointF[] pol7 =
				{
					 p1,
					 p2,
					 p3,
				};
				g.DrawPolygon(pen2, pol7);
				g.FillPolygon(fill5, pol7);

				p1 = new PointF(_startPosX + 190, _startPosY);
				p2 = new PointF(_startPosX + 240, _startPosY + 15);
				p3 = new PointF(_startPosX + 190, _startPosY + 30);
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


