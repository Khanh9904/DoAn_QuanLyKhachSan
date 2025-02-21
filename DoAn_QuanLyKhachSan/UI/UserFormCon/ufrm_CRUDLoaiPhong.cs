using BLL;
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
    public partial class ufrm_CRUDLoaiPhong : UserControl
    {

        Database db = new Database();

        private BLL_LoaiPhong BLL_LoaiPhong;

        public ufrm_CRUDLoaiPhong()
        {
            InitializeComponent();

            BLL_LoaiPhong = new BLL_LoaiPhong(new Database().GetDataSet());

            LoadLoaiPhong();
        }

        private void kHACH_HANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACH_HANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham load du lieu loai phong
        public void LoadLoaiPhong()
        {
            try
            {
                data_LoaiPhong.DataSource = BLL_LoaiPhong.GetDataLoaiPhong();
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
            maLoaiPhongTextBox.Text = "";
            tenLoaiPhongTextBox.Text = "";
            giaTextBox.Text = "";
            soNguoiToiDaTextBox.Text = "";
        }


        //----------------------------------------------------------------------------------------------------------------------------------------

        // Ham them loai phong
        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiPhong loaiPhong = new LoaiPhong()
                {
                    TenLoaiPhong = tenLoaiPhongTextBox.Text,
                    Gia = decimal.Parse(giaTextBox.Text),
                    SoNguoiToiDa = int.Parse(soNguoiToiDaTextBox.Text)
                };

                BLL_LoaiPhong.AddLoaiPhong(loaiPhong);
                MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiPhong();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại phòng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        //hàm sửa loại phòng
        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_LoaiPhong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                LoaiPhong loaiPhong = new LoaiPhong()
                {
                    MaLoaiPhong = Convert.ToInt32(data_LoaiPhong.CurrentRow.Cells["MaLoaiPhong"].Value),
                    TenLoaiPhong = tenLoaiPhongTextBox.Text.Trim(),
                    Gia = decimal.Parse(giaTextBox.Text),
                    SoNguoiToiDa = int.Parse(soNguoiToiDaTextBox.Text)
                };

                BLL_LoaiPhong.UpdateLoaiPhong(loaiPhong);
                MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiPhong();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại phòng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        //hàm xóa loại phòng
        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_LoaiPhong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại phòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int MaLoaiPhong = Convert.ToInt32(data_LoaiPhong.CurrentRow.Cells["MaLoaiPhong"].Value);
                BLL_LoaiPhong.DeleteLoaiPhong(MaLoaiPhong);
                MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiPhong();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại phòng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        // hàm xóa thông tin
        private void btnClearLoaiPhong_Click(object sender, EventArgs e)
        {
            DonThongTin();  
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        //hàm tìm kiếm loại phòng
        private void txtTimKiemLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemLoaiPhong.Text.Trim();

            DataTable dt = BLL_LoaiPhong.SearchLoaiPhong(keyword);

            data_LoaiPhong.DataSource = dt;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------

        //cell click loại phòng
        private void data_LoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_LoaiPhong.Rows[e.RowIndex];

                maLoaiPhongTextBox.Text = rowst.Cells["MaLoaiPhong"]?.Value != DBNull.Value ? rowst.Cells["MaLoaiPhong"].Value.ToString() : "";


                tenLoaiPhongTextBox.Text = rowst.Cells["TenLoaiPhong"]?.Value != DBNull.Value ? rowst.Cells["TenLoaiPhong"].Value.ToString() : "";

                giaTextBox.Text = rowst.Cells["Gia"]?.Value != DBNull.Value ? rowst.Cells["Gia"].Value.ToString() : "";

                soNguoiToiDaTextBox.Text = rowst.Cells["SoNguoiToiDa"]?.Value != DBNull.Value ? rowst.Cells["SoNguoiToiDa"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------


    }
    








}

