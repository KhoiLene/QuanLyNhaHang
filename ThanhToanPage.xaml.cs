namespace NhaHang;

using NhaHang.Services;
public partial class ThanhToanPage : ContentPage
{
    public ThanhToanPage()
    {
        InitializeComponent();

        // Lấy dữ liệu từ giỏ hàng
        string maHD = GioHang.Instance.MaHoaDon;
        string tenKH = GioHang.Instance.KhachHang?.Tenk ?? "Khach";
        int tongTien = GioHang.Instance.GetTotal();

        // Thông tin ngân hàng
        string bankCode = "BIDV";            // Mã ngân hàng
        string stk = "123456789";            // Số tài khoản
        string noiDung = $"{maHD}-{tenKH}";  // Nội dung CK
        // ✅ Tạo link VietQR
        string qrUrl = $"https://img.vietqr.io/image/{bankCode}-{stk}-compact2.png?amount={tongTien}&addInfo={Uri.EscapeDataString(noiDung)}";

        // Gán vào Image
        qrImage.Source = ImageSource.FromUri(new Uri(qrUrl));

        // Hiện thông tin
        lblThongTin.Text = $"STK: {stk} ({bankCode})\nSố tiền: {tongTien:N0} VND\nNội dung: {noiDung}";
    }
        private async void OnThanhToanClicked(object sender, EventArgs e)
    {
         try
    {
        var service = new HoaDonService();
        string noiDung = service.TaoNoiDungHoaDon();

        // Hiện review trước khi lưu
        bool xacNhan = await DisplayAlert("Xuất hoá đơn", noiDung, "Lưu", "Hủy");

        if (xacNhan)
        {
            // Lưu file hóa đơn
            string folder = @"D:\NhaHang";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string fileName = Path.Combine(folder, $"HoaDon.txt");
            File.WriteAllText(fileName, noiDung);

            await DisplayAlert("Thông báo", $"Hóa đơn đã lưu tại:\n{fileName}", "OK");

            GioHang.Instance.Clear();
        GioHang.Instance.ClearKhachHang();
        }
    }
    catch (Exception ex)
    {
        await DisplayAlert("Lỗi", ex.Message, "OK");
    }
        
        await Navigation.PushAsync(new KhachHang());
    }
    private async void OnHuyThanhToanClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GioHangPage());
    }
}
