using BLL;
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
    public partial class ufrm_TTPhanQuyen : UserControl
    {
        Database db = new Database();

        private BLL_QuanLyPhanQuyen BLL_QuanLyPhanQuyen;

        public ufrm_TTPhanQuyen()
        {
            InitializeComponent();
            BLL_QuanLyPhanQuyen = new BLL_QuanLyPhanQuyen(new Database().GetDataSet());

            LoadPhanQuyen();
        }

        public void LoadPhanQuyen()
        {
            try
            {
                data_TTPhanQuyen.DataSource = BLL_QuanLyPhanQuyen.GetDataPhanQuyen();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemTTPhanQuyen_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTTPhanQuyen.Text.Trim();

            DataTable dt = BLL_QuanLyPhanQuyen.TimKiemPhanQuyen(keyword);

            data_TTPhanQuyen.DataSource = dt;
        }

        private void data_TTPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_TTPhanQuyen.Rows[e.RowIndex];


                btnTenQuyen.Text = rowst.Cells["TENQUYEN"]?.Value != DBNull.Value ? rowst.Cells["TENQUYEN"].Value.ToString() : "";

                btnMoTa.Text = rowst.Cells["MoTa"]?.Value != DBNull.Value ? rowst.Cells["MoTa"].Value.ToString() : "";

                btnMucLuong.Text = rowst.Cells["MUCLUONGLAMVIEC"]?.Value != DBNull.Value ? rowst.Cells["MUCLUONGLAMVIEC"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_TTPhanQuyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_TTPhanQuyen.Columns[e.ColumnIndex].Name == "MUCLUONGLAMVIEC" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnMucLuong_TextChanged(object sender, EventArgs e)
        {
            string input = btnMucLuong.Text.Replace(".", "").Replace(" VND", "").Trim();

            if (decimal.TryParse(input, out decimal mucLuong))
            {

                btnMucLuong.Text = string.Format("{0:N0} VND", mucLuong);
                btnMucLuong.SelectionStart = btnMucLuong.Text.Length;
            }
        }
    }
}
