﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyLab
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 140;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        private bool CheckFreePlace(int index)
        {
            return _places[index] == null;
        }

        public static int operator +(Parking<T> p, T car)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = car;
                    p._places[i].SetPosition(20 + i % 4 * _placeSizeWidth, i / 4 * _placeSizeHeight + 15, p.pictureWidth, p.pictureHeight);
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places[index] = null;
                return car;
            }
            return null;
        }

        public static bool operator ==(Parking<T> p1, Parking<T> p2)
        {
            return p1.getUsedLots() == p2.getUsedLots();
        }

        public static bool operator !=(Parking<T> p1, Parking<T> p2)
        {
            return p1.getUsedLots() != p2.getUsedLots();
        }

        public int getUsedLots()
        {
            int cnt = 0;
            for(int i = 0; i < _places.Length; i++)
            {
                if (!CheckFreePlace(i)) cnt++;
            }
            return cnt;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места 
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *_placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
