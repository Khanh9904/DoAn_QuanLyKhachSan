using BLL;
using DAL.DAL;
using DAL.Database;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UserFormPhu
{
    public partial class ufrm_CRUDDichVu : UserControl
    {
        Database db = new Database();

        private BLL_DichVu BLL_DichVu;



        public ufrm_CRUDDichVu()
        {
            InitializeComponent();

            BLL_DichVu = new BLL_DichVu(new Database().GetDataSet());

            LoadDichVu();
        }

        private void dICH_VUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dICH_VUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham load du lieu dich vu
        public void LoadDichVu()
        {
            try
            {
                data_DichVu.DataSource = BLL_DichVu.GetDataDichVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham don thong tin
        public void DonThongTin()
        {
            maDichVuTextBox.Text = "";
            tenDichVuTextBox.Text = "";
            giaDichVuTextBox.Text = "";
            trangThaiDichVuTextBox.Text = "";
            soLuongDichVuTextBox.Text = "";
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham them dich vu
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                DichVu dichVu = new DichVu()
                {
                    TenDichVu = tenDichVuTextBox.Text,
                    GiaDichVu = decimal.Parse(giaDichVuTextBox.Text),
                    TrangThaiDichVu = trangThaiDichVuTextBox.Text,
                    SoLuongDichVu = int.Parse(soLuongDichVuTextBox.Text)
                };

                BLL_DichVu.AddDichVu(dichVu);

                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDichVu();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham sua dich vu
        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_DichVu.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DichVu dichVu = new DichVu()
                {
                    MaDichVu = Convert.ToInt32(data_DichVu.CurrentRow.Cells["MaDichVu"].Value),
                    TenDichVu = tenDichVuTextBox.Text.Trim(),
                    GiaDichVu = decimal.Parse(giaDichVuTextBox.Text),
                    TrangThaiDichVu = trangThaiDichVuTextBox.Text,
                    SoLuongDichVu = int.Parse(soLuongDichVuTextBox.Text)
                };

                BLL_DichVu.UpdateDichVu(dichVu);
                MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDichVu();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dịch vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham xoa dich vu
        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_DichVu.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int MaDichVu = Convert.ToInt32(data_DichVu.CurrentRow.Cells["MaDichVu"].Value);
                BLL_DichVu.DeleteDichVu(MaDichVu);
                MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDichVu();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham tim kiem dich vu
        private void txtTimKiemDichVu_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemDichVu.Text.Trim();
            DataTable dt = BLL_DichVu.SearchDichVu(keyword);
            data_DichVu.DataSource = dt;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        //cell click dich vu
        private void data_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_DichVu.Rows[e.RowIndex];

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

        private void btnClearDichVu_Click(object sender, EventArgs e)
        {
            DonThongTin();  
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Format tiền
        private void data_DichVu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_DichVu.Columns[e.ColumnIndex].Name == "GiaDichVu" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        


    }
}
