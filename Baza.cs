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
            parkingColl = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        private readonly ParkingCollection parkingColl;

        private void ReloadLevels()
        {
            int index = lBParking.SelectedIndex;
            lBParking.Items.Clear();
            for (int i = 0; i < parkingColl.Keys.Count; i++)
            {
                lBParking.Items.Add(parkingColl.Keys[i]);
            }
            if (lBParking.Items.Count > 0 && (index == -1 || index >= lBParking.Items.Count))
            {
                lBParking.SelectedIndex = 0;
            }
            else if (lBParking.Items.Count > 0 && index > -1 && index <lBParking.Items.Count)
            {
                lBParking.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (lBParking.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingColl[lBParking.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void btnParkAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBParkName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingColl.AddParking(tBParkName.Text);
            ReloadLevels();
        }

        private void btnRemovePark_Click(object sender, EventArgs e)
        {
            if (lBParking.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { lBParking.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    parkingColl.DelParking(lBParking.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void btnParkBronCar_Click(object sender, EventArgs e)
        {
            if (lBParking.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new BroneCar(100, 1000, dialog.Color, false);
                    if (parkingColl[lBParking.SelectedItem.ToString()] + car)
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

        private void btnParkZenit_Click(object sender, EventArgs e)
        {
            if (lBParking.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new VeZenit(100, 1000, dialog.Color, dialogDop.Color, true, true);
                        if (parkingColl[lBParking.SelectedItem.ToString()] + car)
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
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            if (lBParking.SelectedIndex > -1 && mTBLot.Text != "")
            {
                var car = parkingColl[lBParking.SelectedItem.ToString()] - Convert.ToInt32(mTBLot.Text);
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

        private void lBParking_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
