using DAL.DAL;
using DAL.Database;
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
    public partial class ufrm_ManHinhHeThong : UserControl
    {
        /**
        * QUy trình Mô đun -------------------------------------------------
        * 
        * 
        * - Load Danh sách các phòng 
        * 
        * - Code hành động CLick từng đối tượng phòng 
        * 
        * - Form Đặt phòng 
        * 
        * - Hiển thị chi tiết phòng + DGV + CellCLick
        * 
        * - Hiển thị chi tiết thiết bị của phòng + DGV + CellCLick
        * 
        * - Tính tổng tiền phòng khi đang xem
        * 
        * - NÚt áp dụng giảm giá 
        * 
        * - NÚt thanh toán phòng 
        * 
        * - Nút xóa thông tin phòng 
        * 
        * - NÚt xóa thông tin thiết bị 
        * 
        * - Nút thêm thiết bị 
        * 
        * - Định dạng VNĐ 
        * 
        * - NÚt mở danh sách hóa đơn 
        * 
        * **/

        private Database db = new Database();
        private Button lastClickedButton = null; // Lưu lại button được click gần nhất

        private string tenThietBiDangChon = null;
        private int selectedMaPhongDangChon = -1;

        private decimal tongThanhToanGoc = 0; // lưu tổng tiền để load lại 
        public ufrm_ManHinhHeThong()
        {
            InitializeComponent();
            LoadData();
        }
        // Load thông tin giao diện các phòng theo tầng ---------------------------------------------
        private void LoadData()
        {
            flow_ManHinhChinh.Controls.Clear();
            string connectionString = db.GetDataSet();
            string query = @"SELECT kv.MaTang, kv.TenTang, p.TenPhong, p.MaPhong, p.TinhTrang
                             FROM TangLau kv
                             LEFT JOIN PHONG p ON kv.MaTang = p.MaTang
                             ORDER BY kv.MaTang;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    int currentKhuVucID = -1;
                    FlowLayoutPanel khuPanel = null;

                    while (reader.Read())
                    {
                        int khuVucID = reader.GetInt32(0);
                        string tenKhuVuc = reader.GetString(1);
                        string tenPhong = reader.IsDBNull(2) ? "Không có phòng" : reader.GetString(2);
                        int maPhong = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                        string tinhTrang = reader.IsDBNull(4) ? "Không xác định" : reader.GetString(4);

                        if (khuVucID != currentKhuVucID)
                        {
                            currentKhuVucID = khuVucID;
                            khuPanel = new FlowLayoutPanel
                            {
                                FlowDirection = FlowDirection.TopDown,
                                AutoSize = true,
                                WrapContents = false,
                                Padding = new Padding(10),
                                Margin = new Padding(0, 20, 0, 0),
                            };

                            Label khuVucLabel = new Label
                            {
                                Text = tenKhuVuc,
                                Font = new Font("Arial", 12),
                                AutoSize = true,
                                ForeColor = Color.Black,
                                Margin = new Padding(0, 0, 0, 10),
                                TextAlign = ContentAlignment.MiddleLeft
                            };
                            khuPanel.Controls.Add(khuVucLabel);
                            flow_ManHinhChinh.Controls.Add(khuPanel);
                        }

                        Panel phongPanel = new Panel
                        {
                            Width = 140,
                            Height = 120,
                            Margin = new Padding(5),
                        };

                        Button phongButton = new Button
                        {
                            Text = tenPhong,
                            Width = 120,
                            Height = 80,
                            Margin = new Padding(10, 0, 10, 0),
                            FlatStyle = FlatStyle.Flat,
                            Font = new Font("Arial", 10),
                            BackColor = tinhTrang == "Trống" ? Color.LightGreen : Color.Tomato,
                            ForeColor = Color.White,
                            Tag = Tuple.Create(maPhong, tinhTrang) // Sử dụng Tuple để truyền dữ liệu
                        };
                        phongButton.FlatAppearance.BorderSize = 1; 
                        phongButton.Click += PhongButton_Click;// Sự kiện click vào phòng



                        phongPanel.Controls.Add(phongButton);

                        khuPanel.Controls.Add(phongPanel);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        // chọn phòng mở Form nhập thông tin đặt phòng -------------------------------------------
        private void PhongButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Tag is Tuple<int, string> tag)
            {
                selectedMaPhongDangChon = tag.Item1;
                int maPhong = tag.Item1;
                string tinhTrang = tag.Item2;
                string tenPhong = clickedButton.Text;

                txtTenPhong.Text = tenPhong;

                // Loại bỏ viền của button trước đó (nếu có)
                if (lastClickedButton != null)
                {
                    lastClickedButton.FlatAppearance.BorderSize = 1;
                }

                // Đặt viền đỏ cho button được chọn
                clickedButton.FlatAppearance.BorderSize = 3;
                clickedButton.FlatAppearance.BorderColor = Color.Red;
                lastClickedButton = clickedButton;

                if (tinhTrang == "Trống")
                {
                    FormDatPhong datPhongForm = new FormDatPhong(maPhong);
                    datPhongForm.ShowDialog();
                    LoadData();
                    data_ThongTinPhong.DataSource = null;
                    data_ThongTinThietBi.DataSource = null;
                }
                else
                {
                    // Hiển thị chi tiết phòng trong DataGridView nếu phòng đang sử dụng
                    HienThiChiTietPhong(maPhong);
                    HienThiThietBiPhong(maPhong);
                    TinhTongTien(maPhong);
                }
            }
        }


        // Tính tổng thanh toán của phòng --------------------------------------------------
        private void TinhTongTien(int maPhong)
        {
            string connectionString = db.GetDataSet();
            string query = @"
            SELECT lp.Gia, pdp.NgayNhanPhong, pdp.NgayTraPhong, 
                   ISNULL(SUM(dv.GiaDichVu), 0) AS TongTienDichVu
            FROM PHONG p
            JOIN LOAI_PHONG lp ON p.MaLoaiPhong = lp.MaLoaiPhong
            LEFT JOIN PHIEU_DAT_PHONG pdp ON p.MaPhong = pdp.MaPhong
            LEFT JOIN CHITIETPHONG ctp ON pdp.MaPhong = ctp.MaPhong
            LEFT JOIN DICH_VU dv ON ctp.MaDichVu = dv.MaDichVu
            WHERE p.MaPhong = @MaPhong
            GROUP BY lp.Gia, pdp.NgayNhanPhong, pdp.NgayTraPhong;";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal giaPhong = reader.GetDecimal(0);
                        DateTime ngayNhanPhong = reader.GetDateTime(1);
                        DateTime ngayTraPhong = reader.GetDateTime(2);
                        decimal tongTienDichVu = reader.GetDecimal(3);

                        // Tính số ngày ở
                        int soNgayO = (ngayTraPhong - ngayNhanPhong).Days;
                        if (soNgayO <= 0) soNgayO = 1;

                        // Tính tổng tiền phòng
                        decimal tongTienPhong = giaPhong * soNgayO;

                        // Tính tổng thanh toán
                        decimal tongThanhToan = tongTienPhong + tongTienDichVu;

                        tongThanhToanGoc = tongThanhToan;

                        // Hiển thị vào các textBox
                        txtTienPhong.Text = tongTienPhong.ToString("N0") + " VNĐ";
                        txtTongTienDichVu.Text = tongTienDichVu.ToString("N0") + " VNĐ";
                        txtTongThanhToan.Text = tongThanhToan.ToString("N0") + " VNĐ"; // Hiển thị tổng thanh toán
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng tiền: " + ex.Message);
            }
        }


        // Hiển thị chi tiết phòng ----------------------------------------------------------------

        private void HienThiChiTietPhong(int maPhong)
        {
            try
            {
                string connectionString = db.GetDataSet();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                   SELECT TOP 1 
                       pdp.MaLapPhieu,
                       ctp.MaChiTietPhong,
                       pdp.MaPhong,
                        kh.MaKhachHang,
                       kh.HoTen,
                       dv.TenDichVu,
                       pdp.NgayNhanPhong,
                       pdp.NgayTraPhong,
                       pdp.SoNguoiO,
                       pdp.TrangThaiPhieuDat,
                       pdp.TienCoc,
                       pdp.NgayDat
                   FROM CHITIETPHONG ctp   
                   LEFT JOIN KHACH_HANG kh ON ctp.MaKhachHang = kh.MaKhachHang
                   LEFT JOIN DICH_VU dv ON ctp.MaDichVu = dv.MaDichVu
                   LEFT JOIN PHIEU_DAT_PHONG pdp ON ctp.MaPhong = pdp.MaPhong
                   WHERE ctp.MaPhong = @MaPhong
                   ORDER BY pdp.NgayDat DESC;";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@MaPhong", SqlDbType.Int).Value = maPhong;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        data_ThongTinPhong.DataSource = dt;

                        // CÁC THÔNG TIN HIỂN THỊ TRONG BẢNG ---------------------------
                        if (dt.Columns.Contains("MaLapPhieu"))
                            data_ThongTinPhong.Columns["MaLapPhieu"].HeaderText = "Mã phiếu";
                        if (dt.Columns.Contains("MaChiTietPhong"))
                            data_ThongTinPhong.Columns["MaChiTietPhong"].HeaderText = "Mã CTP";
                        if (dt.Columns.Contains("MaPhong"))
                            data_ThongTinPhong.Columns["MaPhong"].HeaderText = "Mã phòng";
                        if (dt.Columns.Contains("HoTen"))
                            data_ThongTinPhong.Columns["HoTen"].HeaderText = "Họ tên";
                        if (dt.Columns.Contains("TenDichVu"))
                            data_ThongTinPhong.Columns["TenDichVu"].HeaderText = "Dịch vụ";
                        if (dt.Columns.Contains("NgayNhanPhong"))
                            data_ThongTinPhong.Columns["NgayNhanPhong"].HeaderText = "Ngày nhận";
                        if (dt.Columns.Contains("NgayTraPhong"))
                            data_ThongTinPhong.Columns["NgayTraPhong"].HeaderText = "Ngày trả";
                        if (dt.Columns.Contains("SoNguoiO"))
                            data_ThongTinPhong.Columns["SoNguoiO"].HeaderText = "Số người ở";
                        if (dt.Columns.Contains("TrangThaiPhieuDat"))
                            data_ThongTinPhong.Columns["TrangThaiPhieuDat"].HeaderText = "Trạng thái";
                        if (dt.Columns.Contains("TienCoc"))
                            data_ThongTinPhong.Columns["TienCoc"].HeaderText = "Tiền cọc";
                        if (dt.Columns.Contains("NgayDat"))
                            data_ThongTinPhong.Columns["NgayDat"].HeaderText = "Ngày đặt";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết phòng: " + ex.Message);
            }
        }




        // HIển thị thiết bị của phòng đó --------------------------------------------------------------------------
        private void HienThiThietBiPhong(int maPhong)
        {
            string connectionString = db.GetDataSet();
            string query = @"
                SELECT tb.TenThietBi, cttb.SoLuongSuDung
                FROM CHI_TIET_THIET_BI cttb
                JOIN THIET_BI tb ON cttb.MaThietBi = tb.MaThietBi
                WHERE cttb.MaPhong = @MaPhong;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    data_ThongTinThietBi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thiết bị phòng: " + ex.Message);
            }
        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            if (lastClickedButton != null && lastClickedButton.Tag is Tuple<int, string> tag)
            {
                int maPhong = tag.Item1;
                FormThemThietBi formThemThietBi = new FormThemThietBi(maPhong);
                formThemThietBi.ShowDialog();
                HienThiThietBiPhong(maPhong);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng trước!");
            }
        }

        private void data_ThongTinThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không click vào tiêu đề
            {
                DataGridViewRow row = data_ThongTinThietBi.Rows[e.RowIndex];
                tenThietBiDangChon = row.Cells["TenThietBi"].Value.ToString(); // Lưu thiết bị được chọn
            }
        }

        private void btnXoaThietBi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tenThietBiDangChon))
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa thiết bị '{tenThietBiDangChon}' khỏi phòng không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                XoaThietBi(tenThietBiDangChon);
                tenThietBiDangChon = null; // Reset thiết bị sau khi xóa
            }
        }
        // Hàm xóa thiết bị ---------------------------------------------
        private void XoaThietBi(string tenThietBi)
        {
            if (lastClickedButton != null && lastClickedButton.Tag is Tuple<int, string> tag)
            {
                int maPhong = tag.Item1;
                string connectionString = db.GetDataSet();
                string query = @"
            DELETE FROM CHI_TIET_THIET_BI 
            WHERE MaPhong = @MaPhong 
            AND MaThietBi = (SELECT MaThietBi FROM THIET_BI WHERE TenThietBi = @TenThietBi);";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@TenThietBi", tenThietBi);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HienThiThietBiPhong(maPhong); // Cập nhật lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa thiết bị. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thiết bị: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phòng trước khi xóa thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void data_ThongTinPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMaPhongDangChon = Convert.ToInt32(data_ThongTinPhong.Rows[e.RowIndex].Cells["MaPhong"].Value);

            }
        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            if (selectedMaPhongDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng trước khi xóa!");
                return;
            }

            string connectionString = db.GetDataSet();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Kiểm tra xem phòng có phiếu đặt không
                            string checkQuery = "SELECT COUNT(*) FROM PHIEU_DAT_PHONG WHERE MaPhong = @MaPhong";
                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                int count = (int)checkCmd.ExecuteScalar();

                            }

                            string deletePhieuDatPhongQuery = "DELETE FROM PHIEU_DAT_PHONG WHERE MaPhong = @MaPhong";
                            using (SqlCommand deletePhieuCmd = new SqlCommand(deletePhieuDatPhongQuery, conn, transaction))
                            {
                                deletePhieuCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                deletePhieuCmd.ExecuteNonQuery();
                            }

                            // Xóa dữ liệu trong bảng CHITIETPHONG
                            string deleteChiTietPhongQuery = "DELETE FROM CHITIETPHONG WHERE MaPhong = @MaPhong";
                            using (SqlCommand deleteChiTietCmd = new SqlCommand(deleteChiTietPhongQuery, conn, transaction))
                            {
                                deleteChiTietCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                deleteChiTietCmd.ExecuteNonQuery();
                            }

                            // Xóa thiết bị trong phòng
                            string deleteThietBiQuery = "DELETE FROM CHI_TIET_THIET_BI WHERE MaPhong = @MaPhong";
                            using (SqlCommand deleteThietBiCmd = new SqlCommand(deleteThietBiQuery, conn, transaction))
                            {
                                deleteThietBiCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                deleteThietBiCmd.ExecuteNonQuery();
                            }

                            // Cập nhật trạng thái phòng thành "Trống"
                            string updateQuery = "UPDATE PHONG SET TinhTrang = N'Trống' WHERE MaPhong = @MaPhong";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                updateCmd.ExecuteNonQuery();
                            }

                            // Commit transaction nếu mọi thứ thành công
                            transaction.Commit();

                            MessageBox.Show("Xóa thông tin phòng thành công!");
                            data_ThongTinPhong.DataSource = null;
                            selectedMaPhongDangChon = -1; // Reset lựa chọn
                            txtTongTienDichVu.Text = "";
                            txtKhuyenMai.Text = "";
                            txtTenPhong.Text = "";
                            txtTongThanhToan.Text = "";
                            txtTienPhong.Text = "";
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }



        private void btnApDung_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu textbox tổng tiền rỗng
            if (string.IsNullOrWhiteSpace(txtTongThanhToan.Text))
            {
                MessageBox.Show("Lỗi: Tổng thanh toán không hợp lệ!");
                return;
            }

            // Chuyển đổi tổng tiền thanh toán
            if (!decimal.TryParse(txtTongThanhToan.Text.Replace(" VNĐ", "").Replace(",", ""), out decimal tongThanhToan))
            {
                MessageBox.Show("Lỗi khi lấy tổng thanh toán!");
                return;
            }

            // Nếu tổng thanh toán gốc chưa được lưu, gán giá trị ban đầu
            if (tongThanhToanGoc == 0)
            {
                tongThanhToanGoc = tongThanhToan;
            }

            // Kiểm tra nếu textbox khuyến mãi rỗng
            if (string.IsNullOrWhiteSpace(txtKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng nhập số phần trăm giảm giá!");
                return;
            }

            // Chuyển đổi giá trị khuyến mãi
            if (!decimal.TryParse(txtKhuyenMai.Text, out decimal giamGia))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            // Kiểm tra xem giá trị khuyến mãi có hợp lệ không
            if (giamGia < 0 || giamGia > 100)
            {
                MessageBox.Show("Vui lòng nhập số phần trăm từ 0 đến 100!");
                return;
            }

            // Tính toán giảm giá
            decimal soTienGiam = (tongThanhToanGoc * giamGia) / 100;
            tongThanhToan = tongThanhToanGoc - soTienGiam; // Tính lại tổng thanh toán từ giá trị gốc

            // Cập nhật textbox tổng thanh toán
            txtTongThanhToan.Text = tongThanhToan.ToString("N0") + " VNĐ";
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTongThanhToan.Text = tongThanhToanGoc.ToString("N0") + " VNĐ";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string connectionString = db.GetDataSet();
            string phuongThucThanhToan = cb_Phuongthuc.Text;
            string trangThai = "Đã thanh toán";


            if (!decimal.TryParse(txtTienPhong.Text.Replace(" VNĐ", "").Replace(",", ""), out decimal tongTienPhong) ||
                !decimal.TryParse(txtTongTienDichVu.Text.Replace(" VNĐ", "").Replace(",", ""), out decimal tongTienDichVu) ||
                !decimal.TryParse(txtTongThanhToan.Text.Replace(" VNĐ", "").Replace(",", ""), out decimal tongTienThanhToan))
            {
                MessageBox.Show("Lỗi khi đọc giá trị số. Vui lòng kiểm tra lại!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Kiểm tra xem MaLapPhieu có tồn tại không
                            string checkMaLapPhieuQuery = "SELECT TOP 1 MaLapPhieu FROM PHIEU_DAT_PHONG WHERE MaPhong = @MaPhong ORDER BY NgayDat DESC";
                            int? maLapPhieu = null;

                            using (SqlCommand checkCmd = new SqlCommand(checkMaLapPhieuQuery, conn, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                object result = checkCmd.ExecuteScalar();
                                if (result != null)
                                {
                                    maLapPhieu = Convert.ToInt32(result);
                                }
                            }

                            if (maLapPhieu == null)
                            {
                                MessageBox.Show("Không tìm thấy thông tin đặt phòng cho phòng này.");
                                transaction.Rollback();
                                return;
                            }
                            string getKhachHangQuery = "SELECT MaKhachHang FROM PHIEU_DAT_PHONG WHERE MaLapPhieu = @MaLapPhieu";
                            int? maKhachHang = null;

                            using (SqlCommand khCmd = new SqlCommand(getKhachHangQuery, conn, transaction))
                            {
                                khCmd.Parameters.AddWithValue("@MaLapPhieu", maLapPhieu);
                                object khResult = khCmd.ExecuteScalar();
                                if (khResult != null)
                                {
                                    maKhachHang = Convert.ToInt32(khResult);
                                }
                            }

                            string insertHoaDonQuery = @"
                        INSERT INTO HOA_DON (NgayLapHoaDon, TongTienPhong, TongTienDichVu, TongTienThanhToan, PhuongThucThanhToan, TrangThai, MaLapPhieu , MaKhachHang)
                        VALUES (@NgayLapHoaDon, @TongTienPhong, @TongTienDichVu, @TongTienThanhToan, @PhuongThucThanhToan, @TrangThai, @MaLapPhieu, @MaKhachHang)";

                            using (SqlCommand cmd = new SqlCommand(insertHoaDonQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@NgayLapHoaDon", DateTime.Now);
                                cmd.Parameters.AddWithValue("@TongTienPhong", tongTienPhong);
                                cmd.Parameters.AddWithValue("@TongTienDichVu", tongTienDichVu);
                                cmd.Parameters.AddWithValue("@TongTienThanhToan", tongTienThanhToan);
                                cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
                                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                                cmd.Parameters.AddWithValue("@MaLapPhieu", maLapPhieu);
                                cmd.Parameters.AddWithValue("@MaKhachHang", (object)maKhachHang ?? DBNull.Value); // Xử lý nếu null
                                cmd.ExecuteNonQuery();
                            }

                            string updatePhieuDatQuery = "UPDATE PHIEU_DAT_PHONG SET TrangThaiPhieuDat = N'Đã thanh toán' WHERE MaLapPhieu = @MaLapPhieu";
                            using (SqlCommand updatePhieuCmd = new SqlCommand(updatePhieuDatQuery, conn, transaction))
                            {
                                updatePhieuCmd.Parameters.AddWithValue("@MaLapPhieu", maLapPhieu);
                                updatePhieuCmd.ExecuteNonQuery();
                            }


                            string deleteQuery = "DELETE FROM CHI_TIET_THIET_BI WHERE MaPhong = @MaPhong";
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction))
                            {
                                deleteCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                deleteCmd.ExecuteNonQuery();
                            }


                            string deleteChiTietPhongQuery = "DELETE FROM CHITIETPHONG WHERE MaPhong = @MaPhong";

                            using (SqlCommand deleteChiTietCmd = new SqlCommand(deleteChiTietPhongQuery, conn, transaction))
                            {
                                deleteChiTietCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                deleteChiTietCmd.ExecuteNonQuery();
                            }


                            string updateQuery = "UPDATE PHONG SET TinhTrang = N'Trống' WHERE MaPhong = @MaPhong";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@MaPhong", selectedMaPhongDangChon);
                                updateCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Thanh toán thành công! Phòng đã được cập nhật.");
                            LoadData();
                            data_ThongTinPhong.DataSource = null;
                            data_ThongTinThietBi.DataSource = null;
                            txtTongTienDichVu.Text = "";
                            txtKhuyenMai.Text = "";
                            txtTenPhong.Text = "";
                            txtTongThanhToan.Text = "";
                            txtTienPhong.Text = "";
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void data_ThongTinPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (data_ThongTinPhong.Columns[e.ColumnIndex].Name == "TienCoc" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnDSHD_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon ds = new DanhSachHoaDon();
            ds.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
