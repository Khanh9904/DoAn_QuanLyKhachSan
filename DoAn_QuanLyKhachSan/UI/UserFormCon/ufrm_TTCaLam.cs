using BLL;
using DAL.DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    public partial class ufrm_TTCaLam : UserControl
    {
        Database db = new Database();

        private BLL_CaLam BLL_CaLam;

        public ufrm_TTCaLam()
        {
            InitializeComponent();
            BLL_CaLam = new BLL_CaLam(new Database().GetDataSet());

            LoadCaLam();
        }

        public void LoadCaLam()
        {
            try
            {
                data_TTCaLam.DataSource = BLL_CaLam.GetDataCaLam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTCaLam_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTCaLam.Text.Trim();

            DataTable dt = BLL_CaLam.SearchCaLam(keyword);

            data_TTCaLam.DataSource = dt;
        }

        private void iD_CALAMLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_TTCaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTCaLam.Rows[e.RowIndex];

                iD_CALAMTextBox.Text = rowst.Cells["ID_CALAM"]?.Value != DBNull.Value ? rowst.Cells["ID_CALAM"].Value.ToString() : "";


                tENCATextBox.Text = rowst.Cells["TENCA"]?.Value != DBNull.Value ? rowst.Cells["TENCA"].Value.ToString() : "";

                gIOBATDAUTextBox.Text = rowst.Cells["GIOBATDAU"]?.Value != DBNull.Value ? rowst.Cells["GIOBATDAU"].Value.ToString() : "";

                gIOKETTHUCTextBox.Text = rowst.Cells["GIOKETTHUC"]?.Value != DBNull.Value ? rowst.Cells["GIOKETTHUC"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
