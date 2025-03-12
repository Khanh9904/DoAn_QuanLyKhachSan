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
    public partial class ufrm_CRUDTang : UserControl
    {

        // tạo đôi tượng gọi kết nối
        Database db = new Database();
        private BLL_Tang BLL_Tang;


        public ufrm_CRUDTang()
        {
            InitializeComponent();

            BLL_Tang = new BLL_Tang(new Database().GetDataSet());

            LoadTang();


        }

        //hàm load dữ liệu tầng
        public void LoadTang()
        {
            try
            {
                data_Tang.DataSource = BLL_Tang.GetDataTang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //hàm dọn thông tin
        public void DonThongTin()
        {
            maTangTextBox.Text = "";
            tenTangTextBox.Text = "";
        }

        private void tangLauBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tangLauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet1);

        }

        private void tangLauBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tangLauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet1);

        }

        private void btnThemTang_Click(object sender, EventArgs e)
        {
            try
            {
                Tang tang = new Tang()
                {
                    TenTang = tenTangTextBox.Text,

                };

                BLL_Tang.AddTang(tang);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTang();

                DonThongTin();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       
       

        private void data_Tang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (data_Tang.CurrentRow != null)
                {
                    maTangTextBox.Text = data_Tang.CurrentRow.Cells["MaTang"].Value.ToString();
                    tenTangTextBox.Text = data_Tang.CurrentRow.Cells["TenTang"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        //--------------------------------------------------------------------------------
        //hàm sửa tầng
        private void btnSuaTang_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_Tang.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Tang tang = new Tang()
                {
                    MaTang = Convert.ToInt32(data_Tang.CurrentRow.Cells["MaTang"].Value),
                    TenTang = tenTangTextBox.Text.Trim(),
                    
                };

                BLL_Tang.UpdateTang(tang);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTang();

                DonThongTin();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------
        //hàm xóa tầng


        private void btnXoaTang_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_Tang.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn tầng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int MaTang = Convert.ToInt32(data_Tang.CurrentRow.Cells["MaTang"].Value);
                BLL_Tang.DeleteTang(MaTang);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTang();
                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClearTang_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }

        private void txtTimKiemTang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemTang.Text.Trim();

            DataTable dt = BLL_Tang.SearchTang(keyword);

            data_Tang.DataSource = dt;
        }
    }
}

