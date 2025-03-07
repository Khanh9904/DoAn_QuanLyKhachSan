using DAL.Database;
using DAL.Model;
using DoAn_QuanLyKhachSan.UI;
using DoAn_QuanLyKhachSan;
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

namespace DoAn_QuanLyKhachSan.UI
{
    public partial class Login : Form
    {
        Database db = new Database();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
           
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = db.GetDataSet();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectData = "SELECT * FROM TAIKHOAN WHERE EMAIL = @Email AND MATKHAU = @matkhau";

                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtnhapemail.Text.Trim());
                        cmd.Parameters.AddWithValue("@matkhau", txtpass.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 1)
                        {

                            int maPQ = Convert.ToInt32(table.Rows[0]["ID_PHANQUYEN"]);


                            if (maPQ == 8)
                            {
                                MessageBox.Show("Đăng nhập thành công màn hình - QUẢN LÝ !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 manHinhChinh = new Form1();
                                manHinhChinh.Show();
                                this.Hide();
                            } else if  (maPQ == 9)
                            {
                                MessageBox.Show("Đăng nhập thành công màn hình - TIẾP TÂN  !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ManHinhTiepTan manHinhNhanVien = new ManHinhTiepTan();
                                manHinhNhanVien.Show();
                                this.Hide();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại: Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


