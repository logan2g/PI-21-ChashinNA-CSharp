using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace MyLab
{
	class Zenit
	{
		private float _startPosX;
		private float _startPosY;
		private int _pictureWidth;
		private int _pictureHeight;
		private readonly int carWidth = 160;
		private readonly int carHeight = 87;
		private bool Armor;
		private bool Weapon;
		private bool Head;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public Color DopColor { private set; get; }

		public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool armor, bool weapon, bool head)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			Armor = armor;
			Weapon = weapon;
			Head = head;
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}

		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
					{
						_startPosX += step;
					}
					break;
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				case Direction.Up:
					if (_startPosY - step > 20)
					{
						_startPosY -= step;
					}
					break;
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - carHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}

		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor, 1);
			Brush brMain = new SolidBrush(MainColor);
			Brush brAdd = new SolidBrush(DopColor);
			g.DrawRectangle(pen, new Rectangle((int)_startPosX + 5, (int)_startPosY + 50, 150, 40));
			//Большие колеса
			g.DrawEllipse(pen, (int)_startPosX + 6, (int)_startPosY + 53, 35, 35);
			g.DrawEllipse(pen, (int)_startPosX + 120, (int)_startPosY + 53, 35, 35);
			//Маленькие колесики
			g.DrawEllipse(pen, (int)_startPosX + 45, (int)_startPosY + 70, 20, 20);
			g.DrawEllipse(pen, (int)_startPosX + 70, (int)_startPosY + 70, 20, 20);
			g.DrawEllipse(pen, (int)_startPosX + 95, (int)_startPosY + 70, 20, 20);
			Pen vih = new Pen(MainColor, 5);
			g.DrawLine(vih, _startPosX + 7, _startPosY, _startPosX + 7, _startPosY + 30);
			if (Armor)
			{
				g.FillRectangle(brAdd, new Rectangle((int)_startPosX + 45, (int)_startPosY, 60, 25));
				g.FillRectangle(brAdd, new Rectangle((int)_startPosX, (int)_startPosY + 25, 160, 35));
			}
			else
			{
				g.DrawRectangle(pen, new Rectangle((int)_startPosX + 45, (int)_startPosY, 60, 25));
				g.DrawRectangle(pen, new Rectangle((int)_startPosX, (int)_startPosY + 25, 160, 35));
			}
			if (Weapon)
			{
				Pen weaponPen = new Pen(DopColor, 5);
				g.DrawLine(weaponPen, (int)_startPosX + 100, (int)_startPosY + 10, (int)_startPosX + 165, (int)_startPosY - 3);
				g.DrawLine(weaponPen, (int)_startPosX + 50, (int)_startPosY + 10, (int)_startPosX - 15, (int)_startPosY - 3);
			}
			if (Head)
			{
				g.FillEllipse(brAdd, new Rectangle((int)_startPosX + 60, (int)_startPosY - 19, 20, 20));
			}
		}
	}
}
