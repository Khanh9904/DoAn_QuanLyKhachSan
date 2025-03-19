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

namespace DoAn_QuanLyKhachSan.UI.UserFormCon
{
    public partial class ufrm_CaLam : UserControl
    {
        Database db = new Database();

        private BLL_CaLam BLL_CaLam;

        public ufrm_CaLam()
        {
            InitializeComponent();

            BLL_CaLam = new BLL_CaLam(new Database().GetDataSet());

            LoadCaLam();

        }

        //ham load du lieu ca lam
        public void LoadCaLam()
        {
            try
            {
                data_CaLam.DataSource = BLL_CaLam.GetDataCaLam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ham don thong tin
        public void DonThongTin()
        {
            iD_CALAMTextBox.Text = "";
            tENCATextBox.Text = "";
            gIOBATDAUTextBox.Text = "";
            gIOKETTHUCTextBox.Text = "";
        }

        // ham them ca lam
        private void btnThemCaLam_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu các ô nhập liệu trống
                if (string.IsNullOrWhiteSpace(tENCATextBox.Text) ||
                    string.IsNullOrWhiteSpace(gIOBATDAUTextBox.Text) ||
                    string.IsNullOrWhiteSpace(gIOKETTHUCTextBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi dữ liệu từ TextBox sang TimeSpan
                if (!TimeSpan.TryParse(gIOBATDAUTextBox.Text, out TimeSpan gioBatDau) ||
                    !TimeSpan.TryParse(gIOKETTHUCTextBox.Text, out TimeSpan gioKetThuc))
                {
                    MessageBox.Show("Giờ bắt đầu hoặc giờ kết thúc không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đảm bảo giờ bắt đầu < giờ kết thúc
                if (gioBatDau >= gioKetThuc)
                {
                    MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng CaLam
                CaLam caLam = new CaLam()
                {
                    TENCA = tENCATextBox.Text.Trim(),
                    GIOBATDAU = gioBatDau,
                    GIOKETTHUC = gioKetThuc
                };

                // Gọi hàm thêm ca làm
                BLL_CaLam.AddCaLam(caLam);
                MessageBox.Show("Thêm ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCaLam();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm ca làm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //ham sua ca lam
        private void btnSuaCaLam_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_CaLam.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn ca làm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Kiểm tra dữ liệu có rỗng không
                if (string.IsNullOrWhiteSpace(tENCATextBox.Text) ||
                    string.IsNullOrWhiteSpace(gIOBATDAUTextBox.Text) ||
                    string.IsNullOrWhiteSpace(gIOKETTHUCTextBox.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra ID_CALAM hợp lệ
                if (!int.TryParse(data_CaLam.CurrentRow.Cells["ID_CALAM"].Value?.ToString(), out int idCalam))
                {
                    MessageBox.Show("ID ca làm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra giờ bắt đầu và giờ kết thúc
                if (!TimeSpan.TryParse(gIOBATDAUTextBox.Text, out TimeSpan gioBatDau) ||
                    !TimeSpan.TryParse(gIOKETTHUCTextBox.Text, out TimeSpan gioKetThuc))
                {
                    MessageBox.Show("Giờ bắt đầu hoặc giờ kết thúc không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đảm bảo giờ bắt đầu < giờ kết thúc
                if (gioBatDau >= gioKetThuc)
                {
                    MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng ca làm mới
                CaLam calam = new CaLam()
                {
                    ID_CALAM = idCalam,
                    TENCA = tENCATextBox.Text.Trim(),
                    GIOBATDAU = gioBatDau,
                    GIOKETTHUC = gioKetThuc
                };

                // Gọi phương thức cập nhật
                bool isUpdated = BLL_CaLam.UpdateCaLam(calam);
                if (!isUpdated)
                {
                    MessageBox.Show("Cập nhật ca làm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Cập nhật ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCaLam();  // Load lại danh sách
                DonThongTin(); // Xóa thông tin nhập liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật ca làm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ham xoa ca lam
        private void btnXoaCaLam_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_CaLam.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn ca làm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int ID_CALAM = Convert.ToInt32(data_CaLam.CurrentRow.Cells["ID_CALAM"].Value);
                BLL_CaLam.DeleteCaLam(ID_CALAM);
                MessageBox.Show("Xóa ca làm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCaLam();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa ca làm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearCaLam_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }

        private void txtTimKiemCaLam_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemCaLam.Text.Trim();

            DataTable dt = BLL_CaLam.SearchCaLam(keyword);

            data_CaLam.DataSource = dt;
        }

        private void data_CaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_CaLam.Rows[e.RowIndex];

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
