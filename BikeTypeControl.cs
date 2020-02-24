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
    public partial class BikeTypeControl : UserControl 
    {
        private static BikeTypeControl _instance;
        public static BikeTypeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BikeTypeControl();
                return _instance;
            }
        }

        public BikeTypeControl()
        {
            InitializeComponent();
        }

        private void SingleBikeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TandemBikeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
