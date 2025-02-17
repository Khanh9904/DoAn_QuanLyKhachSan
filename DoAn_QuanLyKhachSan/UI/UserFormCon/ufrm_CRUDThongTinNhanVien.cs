using BLL;
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
    public partial class ufrm_CRUDThongTinNhanVien : UserControl
    {

        // tạo đối tượng gọi kết nối
        Database db = new Database();

        private BLL_ThongTinNhanVien BLL_ThongTinNhanVien;
        //--------------------------------------------------------------------------------




        public ufrm_CRUDThongTinNhanVien()
        {
            InitializeComponent();

            BLL_ThongTinNhanVien = new BLL_ThongTinNhanVien(new Database().GetDataSet());

            
        }

        //--------------------------------------------------------------------------------
        //Hàm load dữ liệu nhân viên
        public void LoadNhanVien()
        {
            try
            {
                data_NhanVien.DataSource = BLL_ThongTinNhanVien.GetDataNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            

        private void nHAN_VIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAN_VIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }


        //--------------------------------------------------------------------------------
        private void btnTroLaiNhanVien_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_QuanLyNhanVien quanly = new ufrm_QuanLyNhanVien();
            this.Controls.Add(quanly);
            quanly.Dock = DockStyle.Fill;
        }

        //---------------------------------------------------------------------------------
        //hàm dọn thông tin
        public void btnDonThongTin()
        {
            iD_NHANVIENTextBox.Text = "";
            hOTENTextBox.Text = "";
            nGAYSINHDateTimePicker.Text = "";
            dIACHITextBox.Text = "";
            sDTTextBox.Text = "";   
        }

        //------------------------------------------------------------------------

        


        //--------------------------------------------------------------------------------
        // Ham them nhan vien
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = new NhanVien()
                {
                    TENNHANVIEN = hOTENTextBox.Text,
                    NGAYSINH = nGAYSINHDateTimePicker.Value,
                    DIACHI = dIACHITextBox.Text,
                    SDT = sDTTextBox.Text
                };

                BLL_ThongTinNhanVien.AddNhanVien(nhanVien);

                LoadNhanVien();

                btnDonThongTin();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------
        //hàm xóa nhân viên

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_NhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int ID_NHANVIEN = Convert.ToInt32(data_NhanVien.CurrentRow.Cells["ID_NHANVIEN"].Value);

                BLL_ThongTinNhanVien.DeleteNhanVien(ID_NHANVIEN);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNhanVien();

                btnDonThongTin();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //--------------------------------------------------------------------------



        //--------------------------------------------------------------------------------
        //hàm sửa nhân viên

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = new NhanVien()
                {
                    ID_NHANVIEN = Convert.ToInt32(iD_NHANVIENTextBox.Text),
                    TENNHANVIEN = hOTENTextBox.Text,
                    NGAYSINH = nGAYSINHDateTimePicker.Value,
                    DIACHI = dIACHITextBox.Text,
                    SDT = sDTTextBox.Text
                };
                BLL_ThongTinNhanVien.UpdateNhanVien(nhanVien);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
                btnDonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------
        //dọn thông tin
        private void btnDonThongTin_Click(object sender, EventArgs e)
        {
            btnDonThongTin();
        }

        private void data_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_NhanVien.Rows[e.RowIndex];


                iD_NHANVIENTextBox.Text = rowst.Cells["HOTEN"]?.Value != DBNull.Value ? rowst.Cells["HOTEN"].Value.ToString() : "";

                dIACHITextBox.Text = rowst.Cells["DIACHI"]?.Value != DBNull.Value ? rowst.Cells["DIACHI"].Value.ToString() : "";


                nGAYSINHDateTimePicker.Text = rowst.Cells["NGAYSINH"]?.Value != DBNull.Value ? rowst.Cells["NGAYSINH"].Value.ToString() : "";

                sDTTextBox.Text = rowst.Cells["SDT"]?.Value != DBNull.Value ? rowst.Cells["SDT"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
