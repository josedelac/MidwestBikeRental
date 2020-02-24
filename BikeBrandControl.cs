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
    public partial class BikeBrandControl : UserControl
    {
        private static BikeBrandControl _instance;
        public static BikeBrandControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BikeBrandControl();
                return _instance;
            }
        }

        public BikeBrandControl()
        {
            InitializeComponent();
        }

        private void BikeBrandControl_Load(object sender, EventArgs e)
        {

        }
    }
}
