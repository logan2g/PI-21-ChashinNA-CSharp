using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLab
{
    public partial class Baza : Form
    {
        public Baza()
        {
            InitializeComponent();
            parking = new Parking<BroneCar>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private readonly Parking<BroneCar> parking;

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void btnParkBronCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new BroneCar(100, 1000, dialog.Color, false);
                if ((parking + car) > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void btnParkZenit_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new VeZenit(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if ((parking + car) > -1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if (mTBLot.Text != "")
            {
                var car = parking - Convert.ToInt32(mTBLot.Text);
                if (car != null)
                {
                    FormZenit form = new FormZenit();
                    form.setZenit(car);
                    form.ShowDialog();
                }
                mTBLot.Text = "";
                Draw();
            }
        }
    }
}
