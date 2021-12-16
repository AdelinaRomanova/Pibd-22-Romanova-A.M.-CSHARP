using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsStormtrooper
{
	public class Stormtrooper : Warplane, IEquatable<Stormtrooper>
	{
		public Color DopColor { private set; get; }
		public bool Gun { private set; get; }  /// Признак наличия пушек
		public bool Turbo { private set; get; }/// Признак наличия ускорения

		public Stormtrooper(int maxSpeed, float weight, Color mainColor, Color dopColor, bool gun, bool turbo)
			: base(maxSpeed, weight, mainColor, 100, 60)
		{
			DopColor = dopColor;
			Gun = gun;
			Turbo = turbo;
		}

		public Stormtrooper(string info) : base(info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 6)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				DopColor = Color.FromName(strs[3]);
				Gun = Convert.ToBoolean(strs[4]);
				Turbo = Convert.ToBoolean(strs[5]);
			}
		}
		public override void DrawTransport(Graphics g)
		{
			base.DrawTransport(g);
			Pen pen2 = new Pen(Color.Black);
			pen2.Width = 2.0f;
			Brush fill3 = new SolidBrush(DopColor);
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

			base.DrawTransport(g);

			if (Turbo)
			{
				PointF p1 = new PointF(_startPosX + 220, _startPosY + 100);
				PointF p2 = new PointF(_startPosX + 250, _startPosY + 92);
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
				g.FillPolygon(fill3, pol8);
			}
		}

		public void SetDopColor(Color color)
		{
			DopColor = color;
		} // Смена дополнительного цвета

		public override string ToString()
		{
			return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Gun}{separator}{Turbo}";
		}

		public bool Equals(Stormtrooper other)
		{
			if (other == null)
			{
				return false;
			}
			if (GetType().Name != other.GetType().Name)
			{
				return false;
			}
			if (DopColor != other.DopColor)
			{
				return false;
			}
			if (Gun != other.Gun)
			{
				return false;
			}
			if (Turbo != other.Turbo)
			{
				return false;
			}
			return true;
		}

		public override bool Equals(Object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is Stormtrooper planeObj))
			{
				return false;
			}
			else
			{
				return Equals(planeObj);
			}
		}
	}
}


