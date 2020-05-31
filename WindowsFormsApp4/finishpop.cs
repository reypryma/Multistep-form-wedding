using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FinishForm : Form
    {
        public FinishForm()
        {
            InitializeComponent();
        }


        private void BtnOkClick(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(this, true);
            this.Close();
            this.Dispose();
        }


        private void FinishForm_Load(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(this);
        }

    }
}
