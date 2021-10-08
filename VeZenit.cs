using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyLab
{
	class VeZenit : BroneCar
	{
		public Color DopColor { private set; get; }
		private bool Weapon;
		private bool Head;

		public VeZenit(int maxSpeed, float weight, Color mainColor, Color dopColor, bool weapon, bool head) 
			: base(maxSpeed, weight, mainColor, true)
		{
			DopColor = dopColor;
			Weapon = weapon;
			Head = head;
		}

		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(MainColor, 1);
			Brush brAdd = new SolidBrush(DopColor);
			base.DrawTransport(g);

			Pen vih = new Pen(MainColor, 5);
			g.DrawLine(vih, _startPosX + 7, _startPosY + 20, _startPosX + 7, _startPosY + 50);
			g.FillRectangle(brAdd, new Rectangle((int)_startPosX + 45, (int)_startPosY + 20, 60, 25));
			g.FillRectangle(brAdd, new Rectangle((int)_startPosX, (int)_startPosY + 45, 160, 35));
			if (Weapon)
			{
				Pen weaponPen = new Pen(DopColor, 5);
				g.DrawLine(weaponPen, (int)_startPosX + 100, (int)_startPosY + 30, (int)_startPosX + 165, (int)_startPosY + 17);
				g.DrawLine(weaponPen, (int)_startPosX + 50, (int)_startPosY + 30, (int)_startPosX - 15, (int)_startPosY + 17);
			}
			if (Head)
			{
				g.FillEllipse(brAdd, new Rectangle((int)_startPosX + 60, (int)_startPosY, 20, 20));
			}
		}
	}
}
