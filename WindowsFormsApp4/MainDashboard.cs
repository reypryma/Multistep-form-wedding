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
    public partial class MainDashboard : Form
    {
        private readonly NikahEntities _dbNikah;
        public MainDashboard()
        {
            InitializeComponent();
            _dbNikah = new NikahEntities();
        }

        private void DataPenggunnaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            var planningList = _dbNikah.Plannings.Select(q => new { 
                NikahAddress = q.NikahAddress,
                NikahPhone = q.NikahPhone, 
                NikahDate = q.NikahDate, 
                PasanganPria = q.PasanganPria, 
                PasanganWanita = q.PasanganWanita, 
                CatatSaksiSatu = q.CatatSaksiSatu,
                CatatSaksiDua = q.CatatSaksiDua
            }).ToList();

            PlanningDataView.DataSource = planningList;
            PlanningDataView.Columns[0].HeaderText = "Alamat";
            PlanningDataView.Columns[1].HeaderText = "Nomor Telepon";
            PlanningDataView.Columns[2].HeaderText = "Tanggal Nikah";
            PlanningDataView.Columns[3].HeaderText = "Broom NIK";
            PlanningDataView.Columns[4].HeaderText = "Bride NIK";
            PlanningDataView.Columns[5].HeaderText = "Wakil Saksi satu";
            PlanningDataView.Columns[6].HeaderText = "Wakil Saksi Dua";
            var totalOfColumns = PlanningDataView.ColumnCount;
            hscroll.Maximum = totalOfColumns-1;
        
        }

        private void mainPage_Click(object sender, EventArgs e)
        {

        }

        private void menuUtamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPages.SetPage(mainPage);
        }

        private void dataNikahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPages.SetPage(planPage);
        }

        private void PlanningDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //PlanningDataView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1);
        }

        private void PlanningDataView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int sno = 1;
            string ID = "ID";
            string headerID = "ID";

            if (PlanningDataView.Columns.Contains(ID))
                PlanningDataView.Columns.Remove(ID);
            {
                PlanningDataView.Columns.Add(ID, headerID);
            }


            PlanningDataView.Columns[ID].DisplayIndex = 0;

            foreach (DataGridViewRow row in PlanningDataView.Rows)
            {
                row.Cells[0].Value = sno++;
            }

            //PlanningDataView.AutoResizeColumns();

            //foreach (DataGridViewRow row in PlanningDataView.Rows)
            //{
            //    PlanningDataView.Rows[0].HeaderCell.Value = string.Format("{0}  ", row.Index + 1).ToString();
            //    row.Height = 25;
            //}
        }

        private void pengantinLelakiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPages.SetPage(pengantinPriaPage);
        }

        private void hscroll_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            int value = int.Parse(e.Value.ToString());
            PlanningDataView.FirstDisplayedScrollingColumnIndex = value;
        }

        private void CreateFormBtn(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("FormNikah"))
            {
                var formNikah = new FormProject.FormNikah();
                formNikah.Show();
            }
        }
    }
}
