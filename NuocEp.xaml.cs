namespace NhaHang;
using NhaHang.Services;
public partial class NuocEp : ContentPage
{
	int DemTraDaoCamSa = 1;
	int DemNuocGaoDuaHau = 1;
	int DemNuocGaoOiXoai = 1;
	int DemNuocGaoPhucBonTu = 1;


	public NuocEp()
	{
		InitializeComponent();
		lblTraDaoCamSa.Text = "Trà đào cam sả: " + DemTraDaoCamSa;
		lblNuocGaoDuaHau.Text = "Nước gạo dưa hấu: " + DemNuocGaoDuaHau;
		lblNuocGaoOiXoai.Text = "Nước gạo ổi xoài: " + DemNuocGaoOiXoai;
		lblNuocGaoPhucBonTu.Text = "Nước gạo phúc bồn tử: " + DemNuocGaoPhucBonTu;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemTraDaoCamSa++;
		lblTraDaoCamSa.Text = "Trà đào cam sả: " + DemTraDaoCamSa;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemTraDaoCamSa > 0)
		{
			DemTraDaoCamSa--;
			lblTraDaoCamSa.Text = "Trà đào cam sả: " + DemTraDaoCamSa;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemNuocGaoDuaHau++;
		lblNuocGaoDuaHau.Text = "Nước gạo dưa hấu: " + DemNuocGaoDuaHau;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemNuocGaoDuaHau > 0)
		{
			DemNuocGaoDuaHau--;
			lblNuocGaoDuaHau.Text = "Nước gạo dưa hấu: " + DemNuocGaoDuaHau;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemNuocGaoOiXoai++;
		lblNuocGaoOiXoai.Text = "Coca Cola fushu: " + DemNuocGaoOiXoai;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemNuocGaoOiXoai > 0)
		{
			DemNuocGaoOiXoai--;
			lblNuocGaoOiXoai.Text = "Coca Cola fushu: " + DemNuocGaoOiXoai;
		}
	}
	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemNuocGaoPhucBonTu++;
		lblNuocGaoPhucBonTu.Text = "Nước gạo phúc bồn tử: " + DemNuocGaoPhucBonTu;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemNuocGaoPhucBonTu > 0)
		{
			DemNuocGaoPhucBonTu--;
			lblNuocGaoPhucBonTu.Text = "Nước gạo phúc bồn tử: " + DemNuocGaoPhucBonTu;
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

	private void OnTraDaoCamSaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Trà đào cam sả", 55000, DemTraDaoCamSa);

		var TraDaoCamSa = GioHang.Instance.Items.First(i => i.Ten == "Trà đào cam sả");

		DisplayAlert("Chọn món", $"Bạn đã chọn Trà đào cam sả - Tổng số lượng: {DemTraDaoCamSa}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTraDaoCamSa = 1;
		lblTraDaoCamSa.Text = $"Trà đào cam sả: {DemTraDaoCamSa}";
	}

	private async void OnTraDaoCamSaPoint(object sender, PointerEventArgs e)
	{
		await imgTraDaoCamSa.ScaleTo(1.1, 200);
		await lblTraDaoCamSa.ScaleTo(1.1, 200);
	}


	private async void OnTraDaoCamSaPointer(object sender, PointerEventArgs e)
	{
		await imgTraDaoCamSa.ScaleTo(1.0, 200);
		await lblTraDaoCamSa.ScaleTo(1.0, 200);
	}
	private void OnNuocGaoDuaHauTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nước gạo dưa hấu ", 55000, DemNuocGaoDuaHau);

		var NuocGaoDuaHau = GioHang.Instance.Items.First(i => i.Ten == "Nước gạo dưa hấu ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nước gạo dưa hấu  - Tổng số lượng: {DemNuocGaoDuaHau}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNuocGaoDuaHau = 1;
		lblNuocGaoDuaHau.Text = $"Nước gạo dưa hấu: {DemNuocGaoDuaHau}";
	}
	private async void OnNuocGaoDuaHauPoint(object sender, PointerEventArgs e)
	{
		await imgNuocGaoDuaHau.ScaleTo(1.1, 200);
		await lblNuocGaoDuaHau.ScaleTo(1.1, 200);
	}

	private async void OnNuocGaoDuaHauPointer(object sender, PointerEventArgs e)
	{
		await imgNuocGaoDuaHau.ScaleTo(1.0, 200);
		await lblNuocGaoDuaHau.ScaleTo(1.0, 200);
	}
	private void OnNuocGaoOiXoaiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Coca Cola fushu", 55000, DemNuocGaoOiXoai);

		var NuocGaoOiXoai = GioHang.Instance.Items.First(i => i.Ten == "Coca Cola fushu");

		DisplayAlert("Chọn món", $"Bạn đã chọn Coca Cola fushu - Tổng số lượng: {DemNuocGaoOiXoai}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNuocGaoOiXoai = 1;
		lblNuocGaoOiXoai.Text = $"Coca Cola fushu: {DemNuocGaoOiXoai}";
	}

	private async void OnNuocGaoOiXoaiPoint(object sender, PointerEventArgs e)
	{
		await imgNuocGaoOiXoai.ScaleTo(1.1, 200);
		await lblNuocGaoOiXoai.ScaleTo(1.1, 200);
	}

	private async void OnNuocGaoOiXoaiPointer(object sender, PointerEventArgs e)
	{
		await imgNuocGaoOiXoai.ScaleTo(1.0, 200);
		await lblNuocGaoOiXoai.ScaleTo(1.0, 200);
	}

	private void OnNuocGaoPhucBonTuTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nước gạo phúc bồn tử", 55000, DemNuocGaoPhucBonTu);

		var NuocGaoPhucBonTu = GioHang.Instance.Items.First(i => i.Ten == "Nước gạo phúc bồn tử");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nước gạo phúc bồn tử - Tổng số lượng: {DemNuocGaoPhucBonTu}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNuocGaoPhucBonTu = 1;
		lblNuocGaoPhucBonTu.Text = $"Nước gạo phúc bồn tử: {DemNuocGaoPhucBonTu}";
	}
	private async void OnNuocGaoPhucBonTuPoint(object sender, PointerEventArgs e)
	{
		await imgNuocGaoPhucBonTu.ScaleTo(1.1, 200);
		await lblNuocGaoPhucBonTu.ScaleTo(1.1, 200);
	}

	private async void OnNuocGaoPhucBonTuPointer(object sender, PointerEventArgs e)
	{
		await imgNuocGaoPhucBonTu.ScaleTo(1.0, 200);
		await lblNuocGaoPhucBonTu.ScaleTo(1.0, 200);
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