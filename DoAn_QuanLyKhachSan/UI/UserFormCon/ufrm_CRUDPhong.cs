using BLL;
using DAL.Database;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyKhachSan.UI.UseForm
{
    public partial class ufrm_CRUDPhong : UserControl
    {
        
        Database db = new Database();

        private BLL_Phong BLL_Phong;

        private Timer taiKhoanTimer;


        public ufrm_CRUDPhong()
        {
            InitializeComponent();

            BLL_Phong = new BLL_Phong(new Database().GetDataSet());

            LoadPhong();

            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadMaLoaiPhongComboBox();
            taiKhoanTimer.Start();

            
            taiKhoanTimer = new Timer();
            taiKhoanTimer.Interval = 1000;
            taiKhoanTimer.Tick += (s, e) => LoadTangLauComboBox();
            taiKhoanTimer.Start();

            


        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.heThongKhachSanDataSet);

        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void LoadMaLoaiPhongComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT MaLoaiPhong, TenLoaiPhong FROM LOAI_PHONG";


            var selectedValue = cbMaLoaiPhong.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbMaLoaiPhong.DisplayMember = "TenLoaiPhong";

            cbMaLoaiPhong.ValueMember = "MaLoaiPhong";

            cbMaLoaiPhong.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["MaLoaiPhong"].ToString() == selectedValue.ToString()))
            {
                cbMaLoaiPhong.SelectedValue = selectedValue;
            }
            else
            {

                cbMaLoaiPhong.SelectedIndex = -1;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        public void LoadTangLauComboBox()
        {
            string connectionString = new Database().GetDataSet();

            string query = "SELECT MaTang, TenTang FROM TangLau";


            var selectedValue = cbTang.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbTang.DisplayMember = "TenTang";

            cbTang.ValueMember = "MaTang";

            cbTang.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["MaTang"].ToString() == selectedValue.ToString()))
            {
                cbTang.SelectedValue = selectedValue;
            }
            else
            {

                cbTang.SelectedIndex = -1;
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        

        //-----------------------------------------------------------------------------------------------------------------------------------

        //ham load du lieu phong
        public void LoadPhong()
        {
            try
            {
                data_Phong.DataSource = BLL_Phong.GetDataPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------

        

        //don thong tin
        public void DonThongTin()
        {
            maPhongTextBox.Text = "";
            tenPhongTextBox.Text = "";
            tinhTrangTextBox.Text = "";
            cbMaLoaiPhong.Text = "";
            cbTang.Text = "";
            
        }
        // -----------------------------------------------------------------------------------------------------------------------------------

        // ham them phong
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                
                Phong phong = new Phong()
                {
                    TenPhong = tenPhongTextBox.Text,

                    TinhTrang = tinhTrangTextBox.Text,

                    MaLoaiPhong = (int)cbMaLoaiPhong.SelectedValue,

                    MaTang = (int)cbTang.SelectedValue,

                    


                };

                BLL_Phong.AddPhong(phong);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhong();

                DonThongTin();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // -----------------------------------------------------------------------------------------------------------------------------------

        // ham sua phong
        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            try
            {

                Phong phong = new Phong()

                {
                    MaPhong = Convert.ToInt32(data_Phong.CurrentRow.Cells["MaPhong"].Value),

                    TenPhong = tenPhongTextBox.Text.Trim(),

                    TinhTrang = tinhTrangTextBox.Text.Trim(),

                    MaLoaiPhong = (int)cbMaLoaiPhong.SelectedValue,

                    MaTang = (int)cbTang.SelectedValue,

                    

                };

                BLL_Phong.UpdatePhong(phong);

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhong();

                DonThongTin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // -----------------------------------------------------------------------------------------------------------------------------------

        // ham xoa phong
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_Phong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int MaPhong = Convert.ToInt32(data_Phong.CurrentRow.Cells["MaPhong"].Value);

                BLL_Phong.DeletePhong(MaPhong);

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhong();

                DonThongTin();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin liên kết nối : " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // -----------------------------------------------------------------------------------------------------------------------------------

        //xóa thông tin
        private void button5_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }
        // -----------------------------------------------------------------------------------------------------------------------------------

        //chọn thông tin
        private void data_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = data_Phong.Rows[e.RowIndex];

                maPhongTextBox.Text = rowst.Cells["MaPhong"]?.Value != DBNull.Value ? rowst.Cells["MaPhong"].Value.ToString() : "";


                tenPhongTextBox.Text = rowst.Cells["TenPhong"]?.Value != DBNull.Value ? rowst.Cells["TenPhong"].Value.ToString() : "";

                tinhTrangTextBox.Text = rowst.Cells["TinhTrang"]?.Value != DBNull.Value ? rowst.Cells["TinhTrang"].Value.ToString() : "";

                
                if (rowst.Cells["MaLoaiPhong"]?.Value != null && rowst.Cells["MaLoaiPhong"].Value != DBNull.Value)
                {
                    int MaLoaiPhong = Convert.ToInt32(rowst.Cells["MaLoaiPhong"].Value);
                    cbMaLoaiPhong.SelectedValue = MaLoaiPhong;
                }
                else
                {
                    cbMaLoaiPhong.SelectedIndex = -1;
                }

                if (rowst.Cells["MaTang"]?.Value != null && rowst.Cells["MaTang"].Value != DBNull.Value)
                {
                    int MaThietBi = Convert.ToInt32(rowst.Cells["MaTang"].Value);
                    cbTang.SelectedValue = MaThietBi;
                }
                else
                {
                    cbTang.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------


        //tim kiem phong
        private void txtTimKiemPhong_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiemPhong.Text.Trim();

            DataTable dt = BLL_Phong.SearchPhong(keyword);

            data_Phong.DataSource = dt;
        }

        private void maThietBiLabel_Click(object sender, EventArgs e)
        {

        }

        private void ufrm_CRUDPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
