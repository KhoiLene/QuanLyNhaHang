namespace NhaHang;
using NhaHang.Services;
public partial class DoAnKem : ContentPage
{
	int DemPhuTrucChien = 1;
	int DemMiRamenVang = 1;
	int DemMiRamenXanh = 1;
	int DemBunGao = 1;
	int DemBunTuoi = 1;
	int DemMiDetHanQuoc = 1;

	public DoAnKem()
	{
		InitializeComponent();
		lblPhuTrucChien.Text = "Phú trúc chiên: " + DemPhuTrucChien;
		lblMiRamenVang.Text = "Mì Ramen vàng: " + DemMiRamenVang;
		lblMiRamenXanh.Text = "Mì Ramen xanh: " + DemMiRamenXanh;
		lblBunGao.Text = "Bún gạo: " + DemBunGao;
		lblBunTuoi.Text = "Bún tươi: " + DemBunTuoi;
		lblMiDetHanQuoc.Text = "Mì dẹt Hàn Quốc: " + DemMiDetHanQuoc;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemPhuTrucChien++;
		lblPhuTrucChien.Text = "Phú trúc chiên: " + DemPhuTrucChien;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemPhuTrucChien > 0)
		{
			DemPhuTrucChien--;
			lblPhuTrucChien.Text = "Phú trúc chiên: " + DemPhuTrucChien;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemMiRamenVang++;
		lblMiRamenVang.Text = "Mì Ramen vàng: " + DemMiRamenVang;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemMiRamenVang > 0)
		{
			DemMiRamenVang--;
			lblMiRamenVang.Text = "Mì Ramen vàng: " + DemMiRamenVang;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemMiRamenXanh++;
		lblMiRamenXanh.Text = "Mì Ramen xanh: " + DemMiRamenXanh;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemMiRamenXanh > 0)
		{
			DemMiRamenXanh--;
			lblMiRamenXanh.Text = "Mì Ramen xanh: " + DemMiRamenXanh;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemBunGao++;
		lblBunGao.Text = "Bún gạo: " + DemBunGao;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemBunGao > 0)
		{
			DemBunGao--;
			lblBunGao.Text = "Bún gạo: " + DemBunGao;
		}
	}
	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemBunTuoi++;
		lblBunTuoi.Text = "Bún tươi: " + DemBunTuoi;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemBunTuoi > 0)
		{
			DemBunTuoi--;
			lblBunTuoi.Text = "Bún tươi: " + DemBunTuoi;
		}
	}
	private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemMiDetHanQuoc++;
		lblMiDetHanQuoc.Text = "Mì dẹt Hàn Quốc: " + DemMiDetHanQuoc;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemMiDetHanQuoc > 0)
		{
			DemMiDetHanQuoc--;
			lblMiDetHanQuoc.Text = "Mì dẹt Hàn Quốc: " + DemMiDetHanQuoc;
		}
	}
	private void OnDauTruDemPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
	}

	private void OnDauTruDemPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
	}
	private void OnDauCongDemPoint(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1.1, 200); // phóng to 10% trong 200ms
	}

	private void OnDauCongDemPointer(object sender, PointerEventArgs e)
	{
		var image = sender as Image;
		image.ScaleTo(1, 200); // trở về kích thước ban đầu
	}

	private void OnPhuTrucChienTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Phú trúc chiên", 23500, DemPhuTrucChien);

		var PhuTrucChien = GioHang.Instance.Items.First(i => i.Ten == "Phú trúc chiên");

		DisplayAlert("Chọn món", $"Bạn đã chọn Phú trúc chiên - Tổng số lượng: {DemPhuTrucChien}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemPhuTrucChien = 1;
		lblPhuTrucChien.Text = $"Phú trúc chiên: {DemPhuTrucChien}";
	}

	private async void OnPhuTrucChienPoint(object sender, PointerEventArgs e)
	{
		await imgPhuTrucChien.ScaleTo(1.1, 200);
		await lblPhuTrucChien.ScaleTo(1.1, 200);
	}


	private async void OnPhuTrucChienPointer(object sender, PointerEventArgs e)
	{
		await imgPhuTrucChien.ScaleTo(1.0, 200);
		await lblPhuTrucChien.ScaleTo(1.0, 200);
	}
	private void OnMiRamenVangTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mì Ramen vàng", 23500, DemMiRamenVang);

		var MiRamenVang = GioHang.Instance.Items.First(i => i.Ten == "Mì Ramen vàng");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mì Ramen vàng - Tổng số lượng: {DemMiRamenVang}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMiRamenVang = 1;
		lblMiRamenVang.Text = $"Mì Ramen vàng: {1}";
	}
	private async void OnMiRamenVangPoint(object sender, PointerEventArgs e)
	{
		await imgMiRamenVang.ScaleTo(1.1, 200);
		await lblMiRamenVang.ScaleTo(1.1, 200);
	}

	private async void OnMiRamenVangPointer(object sender, PointerEventArgs e)
	{
		await imgMiRamenVang.ScaleTo(1.0, 200);
		await lblMiRamenVang.ScaleTo(1.0, 200);
	}
	private void OnMiRamenXanhTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mì Ramen xanh", 23500, DemMiRamenXanh);

		var MiRamenXanh = GioHang.Instance.Items.First(i => i.Ten == "Mì Ramen xanh");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mì Ramen xanh - Tổng số lượng: {DemMiRamenXanh}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMiRamenXanh = 1;
		lblMiRamenXanh.Text = $"Mì Ramen xanh: {1}";
	}

	private async void OnMiRamenXanhPoint(object sender, PointerEventArgs e)
	{
		await imgMiRamenXanh.ScaleTo(1.1, 200);
		await lblMiRamenXanh.ScaleTo(1.1, 200);
	}

	private async void OnMiRamenXanhPointer(object sender, PointerEventArgs e)
	{
		await imgMiRamenXanh.ScaleTo(1.0, 200);
		await lblMiRamenXanh.ScaleTo(1.0, 200);
	}

	private void OnBunGaoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bún gạo", 23500, DemMiRamenXanh);

		var BunGao = GioHang.Instance.Items.First(i => i.Ten == "Bún gạo");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bún gạo - Tổng số lượng: {DemMiRamenXanh}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMiRamenXanh = 1;
		lblBunGao.Text = $"Bún gạo: {1}";
	}

	private async void OnBunGaoPoint(object sender, PointerEventArgs e)
	{
		await imgBunGao.ScaleTo(1.1, 200);
		await lblBunGao.ScaleTo(1.1, 200);
	}

	private async void OnBunGaoPointer(object sender, PointerEventArgs e)
	{
		await imgBunGao.ScaleTo(1.0, 200);
		await lblBunGao.ScaleTo(1.0, 200);
	}

	private void OnBunTuoiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bún tươi", 23500, DemBunTuoi);

		var BunTuoi = GioHang.Instance.Items.First(i => i.Ten == "Bún tươi");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bún tươi - Tổng số lượng: {DemBunTuoi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBunTuoi = 1;
		lblBunTuoi.Text = $"Bún tươi: {1}";
	}
	private async void OnBunTuoiPoint(object sender, PointerEventArgs e)
	{
		await imgBunTuoi.ScaleTo(1.1, 200);
		await lblBunTuoi.ScaleTo(1.1, 200);
	}

	private async void OnBunTuoiPointer(object sender, PointerEventArgs e)
	{
		await imgBunTuoi.ScaleTo(1.0, 200);
		await lblBunTuoi.ScaleTo(1.0, 200);
	}
	private void OnMiDetHanQuocTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mì dẹt Hàn Quốc", 23500, DemMiDetHanQuoc);

		var MiDetHanQuoc = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Mì Ramen vàngSua");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mì dẹt Hàn Quốc - Tổng số lượng: {DemMiDetHanQuoc}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMiDetHanQuoc = 1;
		lblMiDetHanQuoc.Text = $"Mì dẹt Hàn Quốc: {1}";
	}
	private async void OnMiDetHanQuocPoint(object sender, PointerEventArgs e)
	{
		await imgMiDetHanQuoc.ScaleTo(1.1, 200);
		await lblMiDetHanQuoc.ScaleTo(1.1, 200);
	}

	private async void OnMiDetHanQuocPointer(object sender, PointerEventArgs e)
	{
		await imgMiDetHanQuoc.ScaleTo(1.0, 200);
		await lblMiDetHanQuoc.ScaleTo(1.0, 200);
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
	private void OnCounterClicked(object sender, EventArgs e)
	{
		Application.Current.MainPage = new NavigationPage(new ChonMenuPage());
	}
	private void OnCounter1Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new GioHangPage());
    }





	// Ví dụ gọi AddToCart() trong handler khi user tap món:
}