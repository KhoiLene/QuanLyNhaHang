namespace NhaHang;
using NhaHang.Services;
public partial class NuocTraiCay : ContentPage
{
	int DemNuocChanhDay = 1;
	int DemNuocCamNguyenChat = 1;
	int DemNuocEpDuaHau = 1;
	int DemTeaPopPlusThanhLong = 1;
	int DemTeaPopPlusSoRi = 1;
	int DemTeaPopPlusDauRung = 1;

	public NuocTraiCay()
	{
		InitializeComponent();
		lblNuocChanhDay.Text = "Nước chanh dây: " + DemNuocChanhDay;
		lblNuocCamNguyenChat.Text = "Nước cam nguyễn chất : " + DemNuocCamNguyenChat;
		lblNuocEpDuaHau.Text = "Nước ép dưa hấu: " + DemNuocEpDuaHau;
		lblTeaPopPlusThanhLong.Text = "Teapop Plus thanh long: " + DemTeaPopPlusThanhLong;
		lblTeaPopPlusSoRi.Text = "TeaPop Plus sơ ri: " + DemTeaPopPlusSoRi;
		lblTeaPopPlusDauRung.Text = "TeaPop Plus dâu rừng: " + DemTeaPopPlusDauRung;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemNuocChanhDay++;
		lblNuocChanhDay.Text = "Nước chanh dây: " + DemNuocChanhDay;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemNuocChanhDay > 0)
		{
			DemNuocChanhDay--;
			lblNuocChanhDay.Text = "Nước chanh dây: " + DemNuocChanhDay;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemNuocCamNguyenChat++;
		lblNuocCamNguyenChat.Text = "Nước cam nguyễn chất : " + DemNuocCamNguyenChat;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemNuocCamNguyenChat > 0)
		{
			DemNuocCamNguyenChat--;
			lblNuocCamNguyenChat.Text = "Nước cam nguyễn chất : " + DemNuocCamNguyenChat;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemNuocEpDuaHau++;
		lblNuocEpDuaHau.Text = "Nước ép dưa hấu: " + DemNuocEpDuaHau;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemNuocEpDuaHau > 0)
		{
			DemNuocEpDuaHau--;
			lblNuocEpDuaHau.Text = "Nước ép dưa hấu: " + DemNuocEpDuaHau;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemTeaPopPlusThanhLong++;
		lblTeaPopPlusThanhLong.Text = "Teapop Plus thanh long: " + DemTeaPopPlusThanhLong;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemTeaPopPlusThanhLong > 0)
		{
			DemTeaPopPlusThanhLong--;
			lblTeaPopPlusThanhLong.Text = "Teapop Plus thanh long: " + DemTeaPopPlusThanhLong;
		}
	}
	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemTeaPopPlusSoRi++;
		lblTeaPopPlusSoRi.Text = "TeaPop Plus sơ ri: " + DemTeaPopPlusSoRi;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemTeaPopPlusSoRi > 0)
		{
			DemTeaPopPlusSoRi--;
			lblTeaPopPlusSoRi.Text = "TeaPop Plus sơ ri: " + DemTeaPopPlusSoRi;
		}
	}
	private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemTeaPopPlusDauRung++;
		lblTeaPopPlusDauRung.Text = "TeaPop Plus dâu rừng: " + DemTeaPopPlusDauRung;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemTeaPopPlusDauRung > 0)
		{
			DemTeaPopPlusDauRung--;
			lblTeaPopPlusDauRung.Text = "TeaPop Plus dâu rừng: " + DemTeaPopPlusDauRung;
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

	private void OnNuocChanhDayTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nước chanh dây", 41000, DemNuocChanhDay);

		var NuocChanhDay = GioHang.Instance.Items.First(i => i.Ten == "Nước chanh dây");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nước chanh dây - Tổng số lượng: {DemNuocChanhDay}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNuocChanhDay = 1;
		lblNuocChanhDay.Text = $"Nước chanh dây: {DemNuocChanhDay}";
	}

	private async void OnNuocChanhDayPoint(object sender, PointerEventArgs e)
	{
		await imgNuocChanhDay.ScaleTo(1.1, 200);
		await lblNuocChanhDay.ScaleTo(1.1, 200);
	}


	private async void OnNuocChanhDayPointer(object sender, PointerEventArgs e)
	{
		await imgNuocChanhDay.ScaleTo(1.0, 200);
		await lblNuocChanhDay.ScaleTo(1.0, 200);
	}
	private void OnNuocCamNguyenChatTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nước cam nguyễn chất ", 41000, DemNuocCamNguyenChat);

		var NuocCamNguyenChat = GioHang.Instance.Items.First(i => i.Ten == "Nước cam nguyễn chất ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nước cam nguyễn chất  - Tổng số lượng: {DemNuocCamNguyenChat}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNuocCamNguyenChat = 1;
		lblNuocCamNguyenChat.Text = $"Nước cam nguyễn chất : {DemNuocCamNguyenChat}";
	}
	private async void OnNuocCamNguyenChatPoint(object sender, PointerEventArgs e)
	{
		await imgNuocCamNguyenChat.ScaleTo(1.1, 200);
		await lblNuocCamNguyenChat.ScaleTo(1.1, 200);
	}

	private async void OnNuocCamNguyenChatPointer(object sender, PointerEventArgs e)
	{
		await imgNuocCamNguyenChat.ScaleTo(1.0, 200);
		await lblNuocCamNguyenChat.ScaleTo(1.0, 200);
	}
	private void OnNuocEpDuaHauTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nước ép dưa hấu", 41000, DemNuocEpDuaHau);

		var NuocEpDuaHau = GioHang.Instance.Items.First(i => i.Ten == "Nước ép dưa hấu");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nước ép dưa hấu - Tổng số lượng: {DemNuocEpDuaHau}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNuocEpDuaHau = 1;
		lblNuocEpDuaHau.Text = $"Nước ép dưa hấu: {DemNuocEpDuaHau}";
	}

	private async void OnNuocEpDuaHauPoint(object sender, PointerEventArgs e)
	{
		await imgNuocEpDuaHau.ScaleTo(1.1, 200);
		await lblNuocEpDuaHau.ScaleTo(1.1, 200);
	}

	private async void OnNuocEpDuaHauPointer(object sender, PointerEventArgs e)
	{
		await imgNuocEpDuaHau.ScaleTo(1.0, 200);
		await lblNuocEpDuaHau.ScaleTo(1.0, 200);
	}

	private void OnTeaPopPlusThanhLongTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Teapop Plus thanh long", 41000, DemTeaPopPlusThanhLong);

		var TeaPopPlusThanhLong = GioHang.Instance.Items.First(i => i.Ten == "Teapop Plus thanh long");

		DisplayAlert("Chọn món", $"Bạn đã chọn Teapop Plus thanh long - Tổng số lượng: {DemTeaPopPlusThanhLong}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTeaPopPlusThanhLong = 1;
		lblTeaPopPlusThanhLong.Text = $"Teapop Plus thanh long: {DemTeaPopPlusThanhLong}";
	}

	private async void OnTeaPopPlusThanhLongPoint(object sender, PointerEventArgs e)
	{
		await imgTeaPopPlusThanhLong.ScaleTo(1.1, 200);
		await lblTeaPopPlusThanhLong.ScaleTo(1.1, 200);
	}

	private async void OnTeaPopPlusThanhLongPointer(object sender, PointerEventArgs e)
	{
		await imgTeaPopPlusThanhLong.ScaleTo(1.0, 200);
		await lblTeaPopPlusThanhLong.ScaleTo(1.0, 200);
	}

	private void OnTeaPopPlusSoRiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("TeaPop Plus sơ ri", 41000, DemTeaPopPlusSoRi);

		var TeaPopPlusSoRi = GioHang.Instance.Items.First(i => i.Ten == "TeaPop Plus sơ ri");

		DisplayAlert("Chọn món", $"Bạn đã chọn TeaPop Plus sơ ri - Tổng số lượng: {DemTeaPopPlusSoRi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTeaPopPlusSoRi = 1;
		lblTeaPopPlusSoRi.Text = $"TeaPop Plus sơ ri: {DemTeaPopPlusSoRi}";
	}
	private async void OnTeaPopPlusSoRiPoint(object sender, PointerEventArgs e)
	{
		await imgTeaPopPlusSoRi.ScaleTo(1.1, 200);
		await lblTeaPopPlusSoRi.ScaleTo(1.1, 200);
	}

	private async void OnTeaPopPlusSoRiPointer(object sender, PointerEventArgs e)
	{
		await imgTeaPopPlusSoRi.ScaleTo(1.0, 200);
		await lblTeaPopPlusSoRi.ScaleTo(1.0, 200);
	}
	private void OnTeaPopPlusDauRungTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("TeaPop Plus dâu rừng", 41000, DemTeaPopPlusDauRung);

		var TeaPopPlusDauRung = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Nước cam nguyễn chất Sua");

		DisplayAlert("Chọn món", $"Bạn đã chọn TeaPop Plus dâu rừng - Tổng số lượng: {DemTeaPopPlusDauRung}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTeaPopPlusDauRung = 1;
		lblTeaPopPlusDauRung.Text = $"TeaPop Plus dâu rừng: {DemTeaPopPlusDauRung}";
	}
	private async void OnTeaPopPlusDauRungPoint(object sender, PointerEventArgs e)
	{
		await imgTeaPopPlusDauRung.ScaleTo(1.1, 200);
		await lblTeaPopPlusDauRung.ScaleTo(1.1, 200);
	}

	private async void OnTeaPopPlusDauRungPointer(object sender, PointerEventArgs e)
	{
		await imgTeaPopPlusDauRung.ScaleTo(1.0, 200);
		await lblTeaPopPlusDauRung.ScaleTo(1.0, 200);
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