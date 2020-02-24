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
    public partial class SummaryControl : UserControl
    {
        private static SummaryControl _instance;
        public static SummaryControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SummaryControl();
                return _instance;
            }
        }
        public SummaryControl()
        {
            InitializeComponent();
        }
    }
}
