using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalSim
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ContactButton_Click(object sender, EventArgs e)
        {

        }

        private void HourseButton_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HoursControl.Instance))
            {
                panel3.Controls.Add(HoursControl.Instance);
                HoursControl.Instance.Dock = DockStyle.Fill;
                HoursControl.Instance.BringToFront();
            }
            else
                HoursControl.Instance.BringToFront();
        }
    

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(HomeControl.Instance))
            {
                panel3.Controls.Add(HomeControl.Instance);
                HomeControl.Instance.Dock = DockStyle.Fill;
                HomeControl.Instance.BringToFront();
            }
            else
                HoursControl.Instance.BringToFront();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BikeTypeButton_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(BikeTypeControl.Instance))
            {
                panel3.Controls.Add(BikeTypeControl.Instance);
                BikeTypeControl.Instance.Dock = DockStyle.Fill;
                BikeTypeControl.Instance.BringToFront();
            }
            else
                BikeTypeControl.Instance.BringToFront();
        }



        private void bikeTypeCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void BrandButton_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(BikeBrandControl.Instance))
            {
                panel3.Controls.Add(BikeBrandControl.Instance);
                BikeBrandControl.Instance.Dock = DockStyle.Fill;
                BikeBrandControl.Instance.BringToFront();
            }
            else
                BikeBrandControl.Instance.BringToFront();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(SummaryControl.Instance))
            {
                panel3.Controls.Add(SummaryControl.Instance);
                SummaryControl.Instance.Dock = DockStyle.Fill;
                SummaryControl.Instance.BringToFront();
            }
            else
                SummaryControl.Instance.BringToFront();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(CheckoutControl.Instance))
            {
                panel3.Controls.Add(CheckoutControl.Instance);
                CheckoutControl.Instance.Dock = DockStyle.Fill;
                CheckoutControl.Instance.BringToFront();
            }
            else
                CheckoutControl.Instance.BringToFront();
        }

        private void homeControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
