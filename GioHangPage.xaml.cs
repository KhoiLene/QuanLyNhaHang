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
