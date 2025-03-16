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
    public partial class ufrm_TTTang : UserControl
    {
        Database db = new Database();
        private BLL_Tang BLL_Tang;

        public ufrm_TTTang()
        {
            InitializeComponent();
            BLL_Tang = new BLL_Tang(new Database().GetDataSet());

            LoadTang();
        }
        public void LoadTang()
        {
            try
            {
                data_TTTang.DataSource = BLL_Tang.GetDataTang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTang.Text.Trim();

            DataTable dt = BLL_Tang.SearchTang(keyword);

            data_TTTang.DataSource = dt;
        }

        private void data_TTTang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (data_TTTang.CurrentRow != null)
                {
                    maTangTextBox.Text = data_TTTang.CurrentRow.Cells["MaTang"].Value.ToString();
                    tenTangTextBox.Text = data_TTTang.CurrentRow.Cells["TenTang"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
