using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MyLab
{
    public partial class FormZenit : Form
    {
        public FormZenit()
        {
            InitializeComponent();
        }

        private ITransport zenitka;

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxZenit.Width, pictureBoxZenit.Height);
            Graphics gr = Graphics.FromImage(bmp);
            zenitka.DrawTransport(gr);
            pictureBoxZenit.Image = bmp;
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "btnUp":
                    zenitka.MoveTransport(Direction.Up);
                    break;
                case "btnDown":
                    zenitka.MoveTransport(Direction.Down);
                    break;
                case "btnLeft":
                    zenitka.MoveTransport(Direction.Left);
                    break;
                case "btnRight":
                    zenitka.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

		private void btnCreateZenit_Click(object sender, EventArgs e)
		{
            Random rnd = new Random();
            zenitka = new VeZenit(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Green, true, true);
            zenitka.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxZenit.Width, pictureBoxZenit.Height);
            Draw();
        }

		private void btnCreateBrone_Click(object sender, EventArgs e)
		{
            Random rnd = new Random();
            zenitka = new BroneCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, false);
            zenitka.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxZenit.Width, pictureBoxZenit.Height);
            Draw();
        }
	}
}