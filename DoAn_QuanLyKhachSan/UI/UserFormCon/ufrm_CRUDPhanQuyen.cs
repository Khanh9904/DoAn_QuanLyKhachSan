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

namespace DoAn_QuanLyKhachSan.UI.UseForm
{


    public partial class ufrm_CRUDPhanQuyen : UserControl
    {

        // tạo đối tượng gọi kết nối
        Database db = new Database();

        private BLL_QuanLyPhanQuyen BLL_QuanLyPhanQuyen;


            

        public ufrm_CRUDPhanQuyen()
        {

            InitializeComponent();

            BLL_QuanLyPhanQuyen = new BLL_QuanLyPhanQuyen(new Database().GetDataSet());

            LoadPhanQuyen();
        }

        //--------------------------------------------------------------------------------
        // Ham load du lieu phan quyen
        public void LoadPhanQuyen()
        {
            try
            {
                data_PhanQuyen.DataSource = BLL_QuanLyPhanQuyen.GetDataPhanQuyen();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------






        private void pHANQUYENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHANQUYENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyNhanVien quanly = new ufrm_QuanLyNhanVien();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }

        //---------------------------------------------------------------------------------
        //ham don thong tin

        public void DonThongTin()
        {
            btnTenQuyen.Text = "";
            btnMoTa.Text = "";
            btnMucLuong.Text = "";
        }

        //--------------------------------------------------------------------------------
        // Them phan quyen
        private void btnThemQuyen_Click(object sender, EventArgs e)
        {
                try
            {
                PhanQuyen Quyen = new PhanQuyen()
                {
                    TENQUYEN = btnTenQuyen.Text,
                    MoTa = btnMoTa.Text,
                    MUCLUONGLAMVIEC = decimal.Parse(btnMucLuong.Text.Trim())
                };

                BLL_QuanLyPhanQuyen.AddNewPhanQuyen(Quyen);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhanQuyen();

                DonThongTin();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------
        // xoa phan quyen

        private void btnXoaQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if(data_PhanQuyen.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int ID_PHANQUYEN = Convert.ToInt32(data_PhanQuyen.CurrentRow.Cells["ID_PHANQUYEN"].Value);

                BLL_QuanLyPhanQuyen.DeletePhanQuyen(ID_PHANQUYEN);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhanQuyen();

                DonThongTin();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //



        //--------------------------------------------------------------------------------
        // VND
        private void data_PhanQuyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_PhanQuyen.Columns[e.ColumnIndex].Name == "MUCLUONGLAMVIEC" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }
        //--------------------------------------------------------------------------------
        // sua phan quyen

        private void btnSuaQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if(data_PhanQuyen.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 
                PhanQuyen quyen = new PhanQuyen()
                {
                    ID_PHANQUYEN = Convert.ToInt32(data_PhanQuyen.CurrentRow.Cells["ID_PHANQUYEN"].Value),
                    TENQUYEN = btnTenQuyen.Text.Trim(),
                    MoTa = btnMoTa.Text.Trim(),
                    MUCLUONGLAMVIEC = decimal.Parse(btnMucLuong.Text.Trim())
                };

                BLL_QuanLyPhanQuyen.UpdatePhanQuyen(quyen);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhanQuyen();

                DonThongTin();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_PhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_PhanQuyen.Rows[e.RowIndex];


                btnTenQuyen.Text = rowst.Cells["TENQUYEN"]?.Value != DBNull.Value ? rowst.Cells["TENQUYEN"].Value.ToString() : "";

                btnMoTa.Text = rowst.Cells["MoTa"]?.Value != DBNull.Value ? rowst.Cells["MoTa"].Value.ToString() : "";

                btnMucLuong.Text = rowst.Cells["MUCLUONGLAMVIEC"]?.Value != DBNull.Value ? rowst.Cells["MUCLUONGLAMVIEC"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ufrm_CRUDThongTinKhachHang kh = new ufrm_CRUDThongTinKhachHang();
            this.Controls.Clear();
            this.Controls.Add(kh);
            kh.Dock = DockStyle.Fill;
        }

        private void txtTimKiemQuyen_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemQuyen.Text.Trim();

            DataTable dt = BLL_QuanLyPhanQuyen.TimKiemPhanQuyen(keyword);

            data_PhanQuyen.DataSource = dt;
        }

        private void data_PhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
