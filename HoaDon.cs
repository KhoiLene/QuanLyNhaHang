using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace NhaHang.Services
{
    public class HoaDonService
    {
        // Tạo nội dung hóa đơn (review trước)
        public string TaoNoiDungHoaDon()
        {
            if (GioHang.Instance.KhachHang == null || !GioHang.Instance.Items.Any())
                throw new Exception("Không có dữ liệu để xuất hóa đơn.");

            var sb = new StringBuilder();
            sb.AppendLine("===== HÓA ĐƠN THANH TOÁN =====");
            sb.AppendLine($"Ngày xuất hoá đơn: {GioHang.Instance.NgayXuat}");
            sb.AppendLine($"Mã hóa đơn: {GioHang.Instance.MaHoaDon}");
            sb.AppendLine($"Tên KH: {GioHang.Instance.KhachHang.Tenk}");
            sb.AppendLine($"Ngày sinh: {(GioHang.Instance.KhachHang.NgaySinh.HasValue ? GioHang.Instance.KhachHang.NgaySinh.Value.ToString("dd/MM/yyyy") : "Không nhập")}");
            sb.AppendLine($"SĐT: {GioHang.Instance.KhachHang.SDT}");
            sb.AppendLine($"Số bàn: {GioHang.Instance.KhachHang.SoBan}");
            sb.AppendLine("-----------------------------------");

            foreach (var item in GioHang.Instance.Items)
            {
                sb.AppendLine($"{item.Ten} - SL: {item.SoLuong} - Giá: {item.Gia:N0}đ - Thành tiền: {(item.SoLuong * item.Gia):N0}đ");
            }

            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Tổng cộng: {GioHang.Instance.GetTotal():N0} vnđ");
            sb.AppendLine("===== CẢM ƠN QUÝ KHÁCH =====");

            return sb.ToString();
        }

        // Review + lưu
        public async Task ReviewVaLuuHoaDon()
        {
            string noiDung = TaoNoiDungHoaDon();

            // Hiện review popup
            bool xacNhan = await Application.Current.MainPage.DisplayAlert(
                "Xem trước hóa đơn",
                noiDung,
                "Lưu",
                "Hủy"
            );

            if (xacNhan)
            {
                string folder = @"D:\NhaHang";
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = Path.Combine(folder, "Hoadon.txt");
                File.WriteAllText(fileName, noiDung);

                await Application.Current.MainPage.DisplayAlert("Thông báo", $"Hóa đơn đã lưu tại:\n{fileName}", "OK");
            }
        }
    }
}
