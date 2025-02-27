using BLL;
using DAL.DAL;
using DAL.Database;
using DAL.Model;
using DoAn_QuanLyKhachSan.UI.UseForm;
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
    public partial class ufrm_CRUDThietBi : UserControl
    {

        Database db = new Database();

        private BLL_ThietBi BLL_ThietBi;

        public ufrm_CRUDThietBi()
        {
            InitializeComponent();

            BLL_ThietBi = new BLL_ThietBi(new Database().GetDataSet());

            LoadThietBi();
        }

        private void data_Thietbi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void tHIET_BIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHIET_BIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }

        private void txtTimKiemThietbi_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemThietbi.Text.Trim();
            DataTable dt = BLL_ThietBi.SearchThietBi(keyword);
            data_Thietbi.DataSource = dt;
        }

        // ham load du lieu thiet bi
        public void LoadThietBi()
        {
            try
            {
                data_Thietbi.DataSource = BLL_ThietBi.GetDataThietBi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ham don thong tin
        public void DonThongTin()
        {
            maThietBiTextBox.Text = "";
            tenThietBiTextBox.Text = "";
            soLuongThietBiTextBox.Text = "";
            tinhTrangTextBox.Text = "";
        }


        // ham them thiet bi
        private void btnThemThietbi_Click(object sender, EventArgs e)
        {
            try
            {
                ThietBi thietBi = new ThietBi()
                {
                    TenThietBi = tenThietBiTextBox.Text,
                    SoLuongThietBi = int.Parse(soLuongThietBiTextBox.Text),
                    TinhTrang = tinhTrangTextBox.Text,
                   
                };

                BLL_ThietBi.AddThietBi(thietBi);

                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThietBi();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thiết bị: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ham sua thiet bi
        private void btnSuaThietbi_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_Thietbi.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ThietBi thietbi = new ThietBi()
                {
                    MaThietBi = Convert.ToInt32(data_Thietbi.CurrentRow.Cells["MaThietBi"].Value),
                    TenThietBi = tenThietBiTextBox.Text.Trim(),
                    SoLuongThietBi = int.Parse(soLuongThietBiTextBox.Text),
                    TinhTrang = tinhTrangTextBox.Text,
                    
                };

                BLL_ThietBi.UpdateThietBi(thietbi);
                MessageBox.Show("Cập nhật thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThietBi();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dịch vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaThietbi_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_Thietbi.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int MaThietBi = Convert.ToInt32(data_Thietbi.CurrentRow.Cells["MaThietBi"].Value);
                BLL_ThietBi.DeleteThietBi(MaThietBi);
                MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThietBi();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearThietbi_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }


        // ham load thong tin len textbox
        private void data_Thietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_Thietbi.Rows[e.RowIndex];

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

        private void btnTroLaiThietbi_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyCSVC quanly = new ufrm_QuanLyCSVC();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }
    }
}
