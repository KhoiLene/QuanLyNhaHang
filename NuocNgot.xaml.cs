namespace NhaHang;
using NhaHang.Services;
public partial class NuocNgot : ContentPage
{
	int DemCocaColaTuoi = 1;
	int DemSpriteTuoi = 1;
	int DemCocaColaFushu = 1;
	int DemHcmuteJumbo = 1;


	public NuocNgot()
	{
		InitializeComponent();
		lblCocaColaTuoi.Text = "Coca Cola tươi: " + DemCocaColaTuoi;
		lblSpriteTuoi.Text = "Sprite tươi: " + DemSpriteTuoi;
		lblCocaColaFushu.Text = "Coca Cola fushu: " + DemCocaColaFushu;
		lblHcmuteJumbo.Text = "Hcmute jumbo: " + DemHcmuteJumbo;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemCocaColaTuoi++;
		lblCocaColaTuoi.Text = "Coca Cola tươi: " + DemCocaColaTuoi;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemCocaColaTuoi > 0)
		{
			DemCocaColaTuoi--;
			lblCocaColaTuoi.Text = "Coca Cola tươi: " + DemCocaColaTuoi;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemSpriteTuoi++;
		lblSpriteTuoi.Text = "Sprite tươi : " + DemSpriteTuoi;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemSpriteTuoi > 0)
		{
			DemSpriteTuoi--;
			lblSpriteTuoi.Text = "Sprite tươi : " + DemSpriteTuoi;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemCocaColaFushu++;
		lblCocaColaFushu.Text = "Coca Cola fushu: " + DemCocaColaFushu;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemCocaColaFushu > 0)
		{
			DemCocaColaFushu--;
			lblCocaColaFushu.Text = "Coca Cola fushu: " + DemCocaColaFushu;
		}
	}
	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemHcmuteJumbo++;
		lblHcmuteJumbo.Text = "Hcmute jumbo: " + DemHcmuteJumbo;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemHcmuteJumbo > 0)
		{
			DemHcmuteJumbo--;
			lblHcmuteJumbo.Text = "Hcmute jumbo: " + DemHcmuteJumbo;
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

	private void OnCocaColaTuoiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Coca Cola tươi", 10000, DemCocaColaTuoi);

		var CocaColaTuoi = GioHang.Instance.Items.First(i => i.Ten == "Coca Cola tươi");

		DisplayAlert("Chọn món", $"Bạn đã chọn Coca Cola tươi - Tổng số lượng: {DemCocaColaTuoi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemCocaColaTuoi = 1;
		lblCocaColaTuoi.Text = $"Coca Cola tươi: {DemCocaColaTuoi}";
	}

	private async void OnCocaColaTuoiPoint(object sender, PointerEventArgs e)
	{
		await imgCocaColaTuoi.ScaleTo(1.1, 200);
		await lblCocaColaTuoi.ScaleTo(1.1, 200);
	}


	private async void OnCocaColaTuoiPointer(object sender, PointerEventArgs e)
	{
		await imgCocaColaTuoi.ScaleTo(1.0, 200);
		await lblCocaColaTuoi.ScaleTo(1.0, 200);
	}
	private void OnSpriteTuoiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Sprite tươi ", 10000, DemSpriteTuoi);

		var SpriteTuoi = GioHang.Instance.Items.First(i => i.Ten == "Sprite tươi ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Sprite tươi  - Tổng số lượng: {DemSpriteTuoi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemSpriteTuoi = 1;
		lblSpriteTuoi.Text = $"Sprite tươi : {DemSpriteTuoi}";
	}
	private async void OnSpriteTuoiPoint(object sender, PointerEventArgs e)
	{
		await imgSpriteTuoi.ScaleTo(1.1, 200);
		await lblSpriteTuoi.ScaleTo(1.1, 200);
	}

	private async void OnSpriteTuoiPointer(object sender, PointerEventArgs e)
	{
		await imgSpriteTuoi.ScaleTo(1.0, 200);
		await lblSpriteTuoi.ScaleTo(1.0, 200);
	}
	private void OnCocaColaFushuTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Coca Cola fushu", 10000, DemCocaColaFushu);

		var CocaColaFushu = GioHang.Instance.Items.First(i => i.Ten == "Coca Cola fushu");

		DisplayAlert("Chọn món", $"Bạn đã chọn Coca Cola fushu - Tổng số lượng: {DemCocaColaFushu}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemCocaColaFushu = 1;
		lblCocaColaFushu.Text = $"Coca Cola fushu: {DemCocaColaFushu}";
	}

	private async void OnCocaColaFushuPoint(object sender, PointerEventArgs e)
	{
		await imgCocaColaFushu.ScaleTo(1.1, 200);
		await lblCocaColaFushu.ScaleTo(1.1, 200);
	}

	private async void OnCocaColaFushuPointer(object sender, PointerEventArgs e)
	{
		await imgCocaColaFushu.ScaleTo(1.0, 200);
		await lblCocaColaFushu.ScaleTo(1.0, 200);
	}

	private void OnHcmuteJumboTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Hcmute jumbo", 10000, DemHcmuteJumbo);

		var HcmuteJumbo = GioHang.Instance.Items.First(i => i.Ten == "Hcmute jumbo");

		DisplayAlert("Chọn món", $"Bạn đã chọn Hcmute jumbo - Tổng số lượng: {DemHcmuteJumbo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemHcmuteJumbo = 1;
		lblHcmuteJumbo.Text = $"Hcmute jumbo: {DemHcmuteJumbo}";
	}
	private async void OnHcmuteJumboPoint(object sender, PointerEventArgs e)
	{
		await imgHcmuteJumbo.ScaleTo(1.1, 200);
		await lblHcmuteJumbo.ScaleTo(1.1, 200);
	}

	private async void OnHcmuteJumboPointer(object sender, PointerEventArgs e)
	{
		await imgHcmuteJumbo.ScaleTo(1.0, 200);
		await lblHcmuteJumbo.ScaleTo(1.0, 200);
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