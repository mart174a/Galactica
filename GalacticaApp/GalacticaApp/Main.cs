using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalacticaApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadForm(new Form2(new SolarSystemData()));
        }

        //Grap and Move
        private bool mouseDown;
        private Point lastLocation;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //Close
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new Form2(new SolarSystemData()));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new Form1(new SolarSystemData()));
        }

        void LoadForm(Form form)
        {
            if(this.mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }
    }
}
