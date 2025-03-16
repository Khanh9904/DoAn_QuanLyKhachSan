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
    public partial class ufrm_TTDichVu : UserControl
    {
        Database db = new Database();

        private BLL_DichVu BLL_DichVu;
        public ufrm_TTDichVu()
        {
            InitializeComponent();
            BLL_DichVu = new BLL_DichVu(new Database().GetDataSet());

            LoadDichVu();
        }
        public void LoadDichVu()
        {
            try
            {
                data_TTDichVu.DataSource = BLL_DichVu.GetDataDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTDichVu_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTDichVu.Text.Trim();
            DataTable dt = BLL_DichVu.SearchDichVu(keyword);
            data_TTDichVu.DataSource = dt;
        }

        private void data_TTDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTDichVu.Rows[e.RowIndex];

                maDichVuTextBox.Text = rowst.Cells["MaDichVu"]?.Value != DBNull.Value ? rowst.Cells["MaDichVu"].Value.ToString() : "";


                tenDichVuTextBox.Text = rowst.Cells["TenDichVu"]?.Value != DBNull.Value ? rowst.Cells["TenDichVu"].Value.ToString() : "";

                giaDichVuTextBox.Text = rowst.Cells["GiaDichVu"]?.Value != DBNull.Value ? rowst.Cells["GiaDichVu"].Value.ToString() : "";

                trangThaiDichVuTextBox.Text = rowst.Cells["TrangThaiDichVu"]?.Value != DBNull.Value ? rowst.Cells["TrangThaiDichVu"].Value.ToString() : "";

                soLuongDichVuTextBox.Text = rowst.Cells["SoLuongDichVu"]?.Value != DBNull.Value ? rowst.Cells["SoLuongDichVu"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void giaDichVuTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = giaDichVuTextBox.Text.Replace(".", "").Replace(" VND", "").Trim();

            if (decimal.TryParse(input, out decimal mucLuong))
            {

                giaDichVuTextBox.Text = string.Format("{0:N0} VND", mucLuong);
                giaDichVuTextBox.SelectionStart = giaDichVuTextBox.Text.Length;
            }
        }

        private void data_TTDichVu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_TTDichVu.Columns[e.ColumnIndex].Name == "GiaDichVu" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
