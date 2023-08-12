using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.DomainClass;
using WinFormsApp3.Services;

namespace WinFormsApp3.Views
{
    public partial class Form1 : Form
    {
        //Form là điểm cuối, DBContext là điểm bắt đầu
        // Sử dụng Repositories để lấy dữ liệu từ DB
        // Sử dụng Services để sử dụng dữ liệu được lấy từ repos
        // Form hiển thị dữ liệu cho người dùng xem từ services
        private string _currentMaXe;
        private XeMayService service = new XeMayService();
        public Form1()
        {
            InitializeComponent();
            LoadGrid(null);
            LoadComboBox();
        }

        //Load Combobox
        public void LoadComboBox()
        {
            //dùng for
            for (int i = 1; i <= 100; i++)
            {
                cmbSoLuong.Items.Add(i.ToString());
            }
            //chọn item hiển thị mặc định
            cmbSoLuong.SelectedIndex = 0;
            // không cho edit 
            cmbSoLuong.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Load Form
        public void LoadGrid(string search)
        {
            int stt = 1;
            // tạo cột cho gridview
            dtgView.ColumnCount = 5;
            //Đặt tên cho từng cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã Xe";
            dtgView.Columns[2].Name = "Tên";
            dtgView.Columns[3].Name = "Mô Tả";
            dtgView.Columns[4].Name = "Số lượng";
            // xóa tất cả các dòng khi gọi lại hàm
            dtgView.Rows.Clear();
            // xuất dữ liệu lấy từ service
            foreach (XeMay x in service.GetXeMays(search))
            {
                dtgView.Rows.Add(stt++, x.Ma, x.Ten, x.Mota, x.SoLuong);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //3 bước
            //B1: Lấy dữ liệu từ txtbox
            var obj = new XeMay();
            obj.Ma = txtMa.Text;
            obj.Ten = txtTen.Text;
            obj.Mota = txtMoTa.Text;
            //try parse để kiểm lỗi
            if (double.TryParse(txtGiaNhap.Text, out double price))
            {
                obj.GiaNhap = (decimal)price;
            }
            else
            {
                MessageBox.Show("Bạn biết giá nghĩa là nhập gì ko??");
                return;
            }
            obj.SoLuong = int.Parse(cmbSoLuong.Text);
            //B2: Đẩy cho service
            MessageBox.Show(service.ThemXeMay(obj));
            //B3: Load lại grid
            LoadGrid(null);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(textBox4.Text);
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy dòng hiện tại được click vào
            int currentRow = e.RowIndex;
            if (currentRow < 0 || currentRow > service.GetXeMays(null).Count)
            {
                return;
            }
            //Lấy mã Xe từ trong dòng được chọn
            _currentMaXe = dtgView.Rows[currentRow].Cells[1].Value.ToString();
            //Lấy ra đối tượng từ list có tồn tại mã xe kia
            var obj = service.GetXeMays(null).FirstOrDefault(xm => xm.Ma == _currentMaXe);
            //truyền dữ liệu vào các textbox
            txtMa.Text = obj.Ma;
            txtTen.Text = obj.Ten;
            txtMoTa.Text = obj.Mota;
            txtGiaNhap.Text = obj.GiaNhap.ToString();
            cmbSoLuong.Text = obj.SoLuong.ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtMoTa.Clear();
            txtGiaNhap.Clear();
            cmbSoLuong.SelectedIndex = 5;
            textBox4.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Xóa chỉ cần quan tâm mã
            MessageBox.Show(service.XoaXeMay(_currentMaXe));
            // Load lại form
            LoadGrid(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //3 bước
            //B1: Lấy dữ liệu từ txtbox
            var obj = new XeMay();
            obj.Ma = txtMa.Text;
            obj.Ten = txtTen.Text;
            obj.Mota = txtMoTa.Text;
            //try parse để kiểm lỗi
            if (double.TryParse(txtGiaNhap.Text, out double price))
            {
                obj.GiaNhap = (decimal)price;
            }
            else
            {
                MessageBox.Show("Bạn biết giá nghĩa là nhập gì ko??");
                return;
            }
            obj.SoLuong = int.Parse(cmbSoLuong.Text);
            //B2: Đẩy cho service
            MessageBox.Show(service.SuaXeMay(obj));
            //B3: Load lại grid
            LoadGrid(null);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int stt = 1;
            // tạo cột cho gridview
            dtgView.ColumnCount = 6;
            //Đặt tên cho từng cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "Mã Xe";
            dtgView.Columns[2].Name = "Tên";
            dtgView.Columns[3].Name = "Mô Tả";
            dtgView.Columns[4].Name = "Số lượng";
            dtgView.Columns[5].Name = "Loại Xe";
            // xóa tất cả các dòng khi gọi lại hàm
            dtgView.Rows.Clear();
            foreach(var xm in service.GetXeMays(null))
            {
                string result = "Hàng Nhái";
                // chạy for để check mã
                foreach(var x in service.GetXms())
                {
                    if(x.Id == xm.IdLxm)
                    {
                        result = x.Ten;
                    }
                }
                dtgView.Rows.Add(stt++, xm.Ma, xm.Ten, xm.Mota, xm.SoLuong, result);
            }
        }
    }
}
