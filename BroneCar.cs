using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyLab
{
	class BroneCar : VeBron
	{
		private readonly int carWidth = 160;
		private readonly int carHeight = 107;
		private bool delta;

		public BroneCar(int maxSpeed, float weight, Color mainColor, bool needDelta)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			delta = needDelta;
		}

		public override void MoveTransport(Direction direction)
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
					if (_startPosY - step > 0)
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

		public override void DrawTransport(Graphics g)
		{
			int y_offset = 0;
			if(delta) { y_offset = 20; }
			Pen pen = new Pen(MainColor, 1);
			Brush brMain = new SolidBrush(MainColor);
			g.DrawRectangle(pen, new Rectangle((int)_startPosX + 5, (int)_startPosY + 50 + y_offset, 150, 40));
			//Большие колеса
			g.DrawEllipse(pen, (int)_startPosX + 6, (int)_startPosY + 53 + y_offset, 35, 35);
			g.DrawEllipse(pen, (int)_startPosX + 120, (int)_startPosY + 53 + y_offset, 35, 35);
			//Маленькие колесики
			g.DrawEllipse(pen, (int)_startPosX + 45, (int)_startPosY + 70 + y_offset, 20, 20);
			g.DrawEllipse(pen, (int)_startPosX + 70, (int)_startPosY + 70 + y_offset, 20, 20);
			g.DrawEllipse(pen, (int)_startPosX + 95, (int)_startPosY + 70 + y_offset, 20, 20);
			//Броня
			g.DrawRectangle(pen, new Rectangle((int)_startPosX + 45, (int)_startPosY + y_offset, 60, 25));
			g.DrawRectangle(pen, new Rectangle((int)_startPosX, (int)_startPosY + 25 + y_offset, 160, 35));
			
		}
	}
}
