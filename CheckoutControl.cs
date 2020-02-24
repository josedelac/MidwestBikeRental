using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRentalSim
{
    public partial class CheckoutControl : UserControl
    {
        private static CheckoutControl _instance;
        public static CheckoutControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CheckoutControl();
                return _instance;
            }
        }
        public CheckoutControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
