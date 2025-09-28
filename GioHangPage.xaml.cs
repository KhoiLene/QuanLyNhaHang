using NhaHang.Services;

namespace NhaHang;

public partial class GioHangPage : ContentPage
{
    public GioHangPage()
    {
        InitializeComponent();
        LoadCart();
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
}
