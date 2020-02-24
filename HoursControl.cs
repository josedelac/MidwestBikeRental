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

    public partial class HoursControl : UserControl
    {
        private static HoursControl _instance;
        public static HoursControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HoursControl();
                return _instance;
            }
        }
        public HoursControl()
        {
            InitializeComponent();
        }
    }
}
