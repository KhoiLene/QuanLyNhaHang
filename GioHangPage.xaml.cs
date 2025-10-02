using NhaHang.Services;
using GioHangTenModel = NhaHang.Services.GioHangTen;
namespace NhaHang;


public partial class GioHangPage : ContentPage
{
    public GioHangPage()
    {
        InitializeComponent();
        LoadCart();
        LoadKhachHang();
    }

    private void LoadKhachHang()
    {
        var kh = GioHang.Instance.KhachHang;

        if (kh != null)
        {
            lblTen.Text = $"Tên: {kh.Tenk}";
            lblNgaySinh.Text = $"Ngày sinh: {(kh.NgaySinh.HasValue ? kh.NgaySinh.Value.ToString("dd/MM/yyyy") : "Không nhập")}";
            lblSDT.Text = $"SĐT: {(kh.SDT > 0 ? kh.SDT.ToString() : "Không nhập")}";
            lblSoBan.Text = $"Số bàn: {kh.SoBan}";
            //string maHoaDon = $"HD-HCMUTE{new Random().Next(1, 9999)}";
            lblMaHoaDon.Text = $"Mã hóa đơn: {GioHang.Instance.MaHoaDon}";
            lblNgayXuat.Text = $"Ngày xuất hoá đơn: {GioHang.Instance.NgayXuat}";

        }
        else
        {
            lblTen.Text = "Tên: Chưa có";
            lblNgaySinh.Text = "Ngày sinh: Chưa có";
            lblSDT.Text = "SĐT: Chưa có";
            lblSoBan.Text = "Số bàn: Chưa có";
        }

    }


    private void LoadCart()
    {
        cartList.ItemsSource = null;
        cartList.ItemsSource = GioHang.Instance.Items;
        totalLabel.Text = $"Tổng: {GioHang.Instance.GetTotal().ToString("N0")} vnđ";
    }

    private void OnClearCartClicked(object sender, EventArgs e)
    {
        GioHang.Instance.Clear();
        LoadCart();
    }
    private void OnDauTruTapped(object sender, EventArgs e)
    {
        var image = sender as Image;
        var item = image?.BindingContext as GioHangItem;
        if (item != null && item.SoLuong > 0)
        {
            item.SoLuong--;
        }
        if (item.SoLuong <= 0)
        {
            GioHang.Instance.RemoveItem(item); // ✅ Xóa khỏi giỏ
        }
        LoadCart();

    }
    private void OnDauTruPoint(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
    }

    private void OnDauTruPointer(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1, 200); // trở về kích thước ban đầu
    }
    private void OnDauCongTapped(object sender, EventArgs e)
    {
        var image = sender as Image;
        var item = image?.BindingContext as GioHangItem;
        if (item != null && item.SoLuong > 0)
        {
            item.SoLuong++;
        }
        LoadCart();

    }
    private void OnDauCongPoint(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
    }

    private void OnDauCongPointer(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1, 200); // trở về kích thước ban đầu
    }
    private void OnThungRacPoint(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
    }

    private void OnThungRacPointer(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1, 200); // trở về kích thước ban đầu
    }
    private void OnDeleteItemTapped(object sender, EventArgs e)
    {
        var image = sender as Image;                     // lấy Image vừa bấm
        var item = image?.BindingContext as GioHangItem; // lấy item từ BindingContext

        if (item != null)
        {
            GioHang.Instance.RemoveItem(item); // dùng hàm RemoveItem trong GioHang.cs
            LoadCart();
        }
    }
    private void OnChonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new ChonMenuPage());
    }
    private async void OnNhapClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new KhachHang());

    }
    private async void OnThanhToanClicked(object sender, EventArgs e)
    {
        try
        {
            var service = new HoaDonService();
            string noiDung = service.TaoNoiDungHoaDon();

            // Hiện review trước khi lưu
            bool chonChuyenKhoan = await DisplayAlert(
            "Xem trước hóa đơn",
            noiDung,
            "Chuyển khoản",
            "Tiền mặt"
        );

            if (chonChuyenKhoan)
            {
                await Navigation.PushAsync(new ThanhToanPage());
                await DisplayAlert("Thông báo", "Bạn đã chọn thanh toán chuyển khoản.", "OK");
            }

            else
            {
                string folder = @"D:\NhaHang";
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = Path.Combine(folder, $"Hoadon.txt");
                File.WriteAllText(fileName, noiDung);
                await DisplayAlert("Thông báo", $"Hóa đơn đã lưu tại:\n{fileName}", "OK");

                GioHang.Instance.Clear();
                GioHang.Instance.ClearKhachHang();
                await Navigation.PushAsync(new KhachHang());
            }
        }
         catch (Exception ex)
    {
        await DisplayAlert("Lỗi", ex.Message, "OK");
    }
    }
}
