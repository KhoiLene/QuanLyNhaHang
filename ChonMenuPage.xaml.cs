namespace NhaHang;
using NhaHang.Services;
public partial class ChonMenuPage : ContentPage
{

    public ChonMenuPage()
    {
        InitializeComponent();
    }
    private async void OnLoGoTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MenuPage());
    }
    private void OnLoGoPoint(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
    }

    private void OnLoGoPointer(object sender, PointerEventArgs e)
    {
        var image = sender as Image;
        image.ScaleTo(1, 200); // trở về kích thước ban đầu
    }
    private async void OnChonPoint(object sender, PointerEventArgs e)
    {
        await imgThitNhapKhau.ScaleTo(1.1, 200);

        await lblThitNhapKhau.ScaleTo(1.1, 200);
    }


    private async void OnChonPointer(object sender, PointerEventArgs e)
    {
        await imgThitNhapKhau.ScaleTo(1.0, 200);

        await lblThitNhapKhau.ScaleTo(1.0, 200);
    }
    private async void OnChonHaiSanPoint(object sender, PointerEventArgs e)
    {
        await imgHaiSan.ScaleTo(1.1, 200);

        await lblHaiSan.ScaleTo(1.1, 200);
    }


    private async void OnChonHaiSanPointer(object sender, PointerEventArgs e)
    {
        await imgHaiSan.ScaleTo(1.0, 200);

        await lblHaiSan.ScaleTo(1.0, 200);
    }
    private async void OnGioHangTapped(object sender, TappedEventArgs e)
    {
        // Mở trang giỏ hàng
        await Navigation.PushAsync(new GioHangPage());
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        lblCartCount.Text = GioHang.Instance.Dem.ToString();
    }
    private async void OnChonVienThaLauPoint(object sender, PointerEventArgs e)
    {
        await imgVienThaLau.ScaleTo(1.1, 200);

        await lblVienThaLau.ScaleTo(1.1, 200);
    }


    private async void OnChonVienThaLauPointer(object sender, PointerEventArgs e)
    {
        await imgVienThaLau.ScaleTo(1.0, 200);

        await lblVienThaLau.ScaleTo(1.0, 200);
    }
    private async void OnChonNamVaRauPoint(object sender, PointerEventArgs e)
    {
        await imgNamVaRau.ScaleTo(1.1, 200);

        await lblNamVaRau.ScaleTo(1.1, 200);
    }


    private async void OnChonNamVaRauPointer(object sender, PointerEventArgs e)
    {
        await imgNamVaRau.ScaleTo(1.0, 200);

        await lblNamVaRau.ScaleTo(1.0, 200);
    }
    private async void OnChonDoAnKemPoint(object sender, PointerEventArgs e)
    {
        await imgDoAnKem.ScaleTo(1.1, 200);

        await lblDoAnKem.ScaleTo(1.1, 200);
    }


    private async void OnChonDoAnKemPointer(object sender, PointerEventArgs e)
    {
        await imgDoAnKem.ScaleTo(1.0, 200);

        await lblDoAnKem.ScaleTo(1.0, 200);
    }
    private async void OnChonNuocNgotPoint(object sender, PointerEventArgs e)
    {
        await imgNuocNgot.ScaleTo(1.1, 200);

        await lblNuocNgot.ScaleTo(1.1, 200);
    }


    private async void OnChonNuocNgotPointer(object sender, PointerEventArgs e)
    {
        await imgNuocNgot.ScaleTo(1.0, 200);

        await lblNuocNgot.ScaleTo(1.0, 200);
    }
    private async void OnChonNuocEpPoint(object sender, PointerEventArgs e)
    {
        await imgNuocEp.ScaleTo(1.1, 200);

        await lblNuocEp.ScaleTo(1.1, 200);
    }


    private async void OnChonNuocEpPointer(object sender, PointerEventArgs e)
    {
        await imgNuocEp.ScaleTo(1.0, 200);

        await lblNuocEp.ScaleTo(1.0, 200);
    }
    private async void OnChonNuocTraiCayPoint(object sender, PointerEventArgs e)
    {
        await imgNuocTraiCay.ScaleTo(1.1, 200); 

        await lblNuocTraiCay.ScaleTo(1.1, 200);
    }


    private async void OnChonNuocTraiCayPointer(object sender, PointerEventArgs e)
    {
        await imgNuocTraiCay.ScaleTo(1.0, 200); 

        await lblNuocTraiCay.ScaleTo(1.0, 200);
    }
}