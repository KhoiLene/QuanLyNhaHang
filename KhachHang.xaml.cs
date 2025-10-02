
using NhaHang.Services;


namespace NhaHang;

public partial class KhachHang : ContentPage
{
    public KhachHang()
    {
        InitializeComponent();
    }

    // Hàm xử lý sự kiện Clicked
    private void OnLuuClicked(object sender, EventArgs e)
    {
        // Lấy dữ liệu từ Entry
        string ten = txtTen.Text;
         DateTime? ngaySinh = null;
    if (dpNgaySinh.Date != DateTime.Now.Date) // nếu user có chọn khác hôm nay
    {
        ngaySinh = dpNgaySinh.Date;

        // ✅ Tính tuổi
        int tuoi = DateTime.Now.Year - ngaySinh.Value.Year;
        if (ngaySinh.Value.Date > DateTime.Now.AddYears(-tuoi)) // chưa qua sinh nhật trong năm nay
            tuoi--;

        if (tuoi < 16)
        {
            return; // ❌ không cho lưu
        }
    }    // DatePicker luôn có Date
        int sdt = int.TryParse(txtSDT.Text, out var sb) ? sb : 0;
        String soBan = txtSoBan.Text;

        // ✅ Thêm khách hàng vào giỏ
        GioHang.Instance.AddTen(ten, ngaySinh, sdt, soBan);

        // Chuyển sang trang giỏ hàng
        Navigation.PushAsync(new ChonMenuPage());
    }
}
