namespace NhaHang;
using NhaHang.Services;
public partial class MenuPage : ContentPage
{
	// int count = 0;

	public MenuPage()
	{
		InitializeComponent();
	}
	private void OnLauNamTapped(object sender, TappedEventArgs e)
	{
		DisplayAlert("Chọn món", "Bạn đã chọn Lẩu nấm", "OK");
		NhaHang.Services.GioHang.Instance.AddItem("Lẩu Nấm", 0);
		lblCartCount.Text = GioHang.Instance.Dem.ToString();
	}
	private void OnLauNamPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
		lblLauNam.FontSize = 30;
	}

	private void OnLauNamPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
		lblLauNam.FontSize = 27;
	}
	private void OnLauTomYumTapped(object sender, TappedEventArgs e)
	{
		DisplayAlert("Chọn món", "Bạn đã chọn Lẩu Tom Yum", "OK");
		NhaHang.Services.GioHang.Instance.AddItem("Lẩu Tom Yum", 0);
		lblCartCount.Text = GioHang.Instance.Dem.ToString();
	}
	private void OnLauTomYumPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
		lblLauTomYum.FontSize = 30;
	}

	private void OnLauTomYumPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
		lblLauTomYum.FontSize = 27;
	}
	private void OnLauXuyenTieuTapped(object sender, TappedEventArgs e)
	{
		DisplayAlert("Chọn món", "Bạn đã chọn Lẩu Xuyên Tiêu", "OK");
		NhaHang.Services.GioHang.Instance.AddItem("Lẩu Xuyên Tiêu", 0);
		lblCartCount.Text = GioHang.Instance.Dem.ToString();
	}
	private void OnLauXuyenTieuPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
		lblLauXuyenTieu.FontSize = 30;
	}

	private void OnLauXuyenTieuPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
		lblLauXuyenTieu.FontSize = 27;
	}
	private void OnLauCuaDongTapped(object sender, TappedEventArgs e)
	{
		DisplayAlert("Chọn món", "Bạn đã chọn Lẩu Cua Đồng", "OK");
		NhaHang.Services.GioHang.Instance.AddItem("Lẩu Cua Đông", 0);
		lblCartCount.Text = GioHang.Instance.Dem.ToString();
	}
	private void OnLauCuaDongPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
		lblLauCuaDong.FontSize = 30;
	}

	private void OnLauCuaDongPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
		lblLauCuaDong.FontSize = 27;
	}
	private void OnLauTomYumSuaTapped(object sender, TappedEventArgs e)
	{
		DisplayAlert("Chọn món", "Bạn đã chọn Lẩu Tom Yum Sữa", "OK");
		NhaHang.Services.GioHang.Instance.AddItem("Lẩu Tom Yum Sữa", 0);
		lblCartCount.Text = GioHang.Instance.Dem.ToString();
	}
	private void OnLauTomYumSuaPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
		lblLauTomYumSua.FontSize = 30;
	}

	private void OnLauTomYumSuaPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
		lblLauTomYumSua.FontSize = 27;
	}
	// int cartCount = 0;
	// void AddToCart()
	// {
	// 	cartCount++;
	// 	lblCartCount.Text = cartCount.ToString();
	// }
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





	// Ví dụ gọi AddToCart() trong handler khi user tap món:
}