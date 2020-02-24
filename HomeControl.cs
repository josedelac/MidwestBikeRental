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
    public partial class HomeControl : UserControl
    {
        private static HomeControl _instance;
        public static HomeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeControl();
                return _instance;
            }
        }
        public HomeControl()
        {
            InitializeComponent();
        }
    }
}
