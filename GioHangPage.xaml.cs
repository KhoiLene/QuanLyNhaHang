using NhaHang.Services;
using NhaHang;
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
        totalLabel.Text = $"Tổng: {GioHang.Instance.GetTotal()} đ";
    }

    private void OnClearCartClicked(object sender, EventArgs e)
    {
        GioHang.Instance.Clear();
        LoadCart();
        cartList.ItemsSource = GioHang.Instance.Items; 
    }
}