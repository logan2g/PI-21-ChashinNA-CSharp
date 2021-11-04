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
    public partial class FormCarConfig : Form
    {
        public FormCarConfig()
        {
            InitializeComponent();
            btnCancel.Click += (object sender, EventArgs e) => { Close(); };
            pRed.MouseDown += panelColor_MouseDown;
            pYellow.MouseDown += panelColor_MouseDown;
            pBlack.MouseDown += panelColor_MouseDown;
            pWhite.MouseDown += panelColor_MouseDown;
            pGray.MouseDown += panelColor_MouseDown;
            pOrange.MouseDown += panelColor_MouseDown;
            pGreen.MouseDown += panelColor_MouseDown;
            pBlue.MouseDown += panelColor_MouseDown;
        }

        BroneCar car = null;
        private event Action<BroneCar> eventAddCar;

        public void AddEvent(Action<BroneCar> ev)
        {
            eventAddCar += ev;
        }

        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pBpreview.Width, pBpreview.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(15, 10, pBpreview.Width, pBpreview.Height);
                car.DrawTransport(gr);
                pBpreview.Image = bmp;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void lBase_MouseDown(object sender, MouseEventArgs e)
        {
            lBase.DoDragDrop(lBase.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void lAdditional_MouseDown(object sender, MouseEventArgs e)
        {
            lAdditional.DoDragDrop(lAdditional.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pPicBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pPicBox_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Бронемашина":
                    car = new BroneCar((int)nUDMaxSpeed.Value, (int)nUDWeight.Value, Color.White, false);
                    break;
                case "Зенитка":
                    car = new BroneZenit((int)nUDMaxSpeed.Value, (int)nUDWeight.Value, Color.White, Color.Black, cBweapon.Checked, cBhead.Checked);
                    break;
            }
            DrawCar();
        }

        private void lMainCol_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lMainCol_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }

        private void lDopCol_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is BroneZenit)
                {
                    (car as BroneZenit).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();
        }
    }
}
