using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpaysFoodhouse
{
    public partial class DeliveryOrders : UserControl
    {
        public DeliveryOrders()
        {
            InitializeComponent();
        }

        private void clicked(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 153, 0);
            btn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void otherClicked()
        {
            btn_Fulfilled.BackColor = Color.FromArgb(230, 230, 230);
            btn_Fulfilled.ForeColor = Color.FromArgb(0, 0, 0);
            btn_Active.BackColor = Color.FromArgb(230, 230, 230);
            btn_Active.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void btn_Fulfilled_Click(object sender, EventArgs e)
        {
            otherClicked();
            clicked(btn_Fulfilled);
        }

        
        private void btn_Active_Click(object sender, EventArgs e)
        {
            otherClicked();
            clicked(btn_Active);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
