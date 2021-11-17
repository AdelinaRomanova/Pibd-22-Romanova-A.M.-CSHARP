﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper
{
    public abstract class Vehicle : ITransport
    {
		protected float _startPosX;
		protected float _startPosY;
		protected int _pictureWidth;
		protected int _pictureHeight;

		public int MaxSpeed { protected set; get; }
		public float Weight { protected set; get; }
		public Color MainColor { protected set; get; } 
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
