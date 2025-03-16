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
    public partial class ufrm_TTThietBi : UserControl
    {
        Database db = new Database();

        private BLL_ThietBi BLL_ThietBi;
        public ufrm_TTThietBi()
        {
            InitializeComponent();
            BLL_ThietBi = new BLL_ThietBi(new Database().GetDataSet());

            LoadThietBi();
        }
        public void LoadThietBi()
        {
            try
            {
                data_TTThietBi.DataSource = BLL_ThietBi.GetDataThietBi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTThietBi_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTThietBi.Text.Trim();
            DataTable dt = BLL_ThietBi.SearchThietBi(keyword);
            data_TTThietBi.DataSource = dt;
        }

        private void data_TTThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTThietBi.Rows[e.RowIndex];

                maThietBiTextBox.Text = rowst.Cells["MaThietBi"]?.Value != DBNull.Value ? rowst.Cells["MaThietBi"].Value.ToString() : "";


                tenThietBiTextBox.Text = rowst.Cells["TenThietBi"]?.Value != DBNull.Value ? rowst.Cells["TenThietBi"].Value.ToString() : "";

                soLuongThietBiTextBox.Text = rowst.Cells["SoLuongThietBi"]?.Value != DBNull.Value ? rowst.Cells["SoLuongThietBi"].Value.ToString() : "";

                tinhTrangTextBox.Text = rowst.Cells["TinhTrang"]?.Value != DBNull.Value ? rowst.Cells["TinhTrang"].Value.ToString() : "";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
