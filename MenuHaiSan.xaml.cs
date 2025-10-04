namespace NhaHang;
using NhaHang.Services;
public partial class MenuHaiSanPage : ContentPage
{
	int DemTomTheTuoi = 1;
	int DemTomTich = 1;
	int DemBaoTuCaBasa = 1;
	int DemBachTuocBaby = 1;
	int DemNgheu = 1;
	int DemMucOng = 1;
	int DemMucNangNut = 1;
	int DemSuaTuoi = 1;
	int DemVayCaHoi = 1;
	int DemCaSauFillet = 1;
	int DemCaBasa = 1;
	int DemGheFaci = 1;

	public MenuHaiSanPage()
	{
		InitializeComponent();
		lblTomTheTuoi.Text = "Tôm thẻ tươi: " + DemTomTheTuoi;
		lblTomTich.Text = "Tôm tích: " + DemTomTich;
		lblBaoTuCaBasa.Text = "Bao tử cá Basa: " + DemBaoTuCaBasa;
		lblBachTuocBaby.Text = "Bạch Tuộc Baby: " + DemBachTuocBaby;
		lblNgheu.Text = "Nghêu: " + DemNgheu;
		lblMucOng.Text = "Mực ống: " + DemMucOng;
		lblMucNangNut.Text = "Mực nang nút: " + DemMucNangNut;
		lblSuaTuoi.Text = "Sứa tươi: " + DemSuaTuoi;
		lblVayCaHoi.Text = "Vây cá Hồi: " + DemVayCaHoi;
		lblCaSauFillet.Text = "Cá sấu fillet: " + DemCaSauFillet;
		lblCaBasa.Text = "Cá Basa: " + DemCaBasa;
		lblGheFaci.Text = "Ghẹ Faci: " + DemGheFaci;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemTomTheTuoi++;
		lblTomTheTuoi.Text = "Tôm thẻ tươi: " + DemTomTheTuoi;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemTomTheTuoi > 0)
		{
			DemTomTheTuoi--;
			lblTomTheTuoi.Text = "Tôm thẻ tươi: " + DemTomTheTuoi;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemTomTich++;
		lblTomTich.Text = "Tôm tích: " + DemTomTich;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemTomTich > 0)
		{
			DemTomTich--;
			lblTomTich.Text = "Tôm tích: " + DemTomTich;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemBaoTuCaBasa++;
		lblBaoTuCaBasa.Text = "Bao tử cá Basa: " + DemBaoTuCaBasa;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemBaoTuCaBasa > 0)
		{
			DemBaoTuCaBasa--;
			lblBaoTuCaBasa.Text = "Bao tử cá Basa: " + DemBaoTuCaBasa;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemBachTuocBaby++;
		lblBachTuocBaby.Text = "Bạch Tuộc Baby: " + DemBachTuocBaby;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemBachTuocBaby > 0)
		{
			DemBachTuocBaby--;
			lblBachTuocBaby.Text = "Bạch Tuộc Baby: " + DemBachTuocBaby;
		}
	}

	private void OnDauCongDem2Tapped(object sender, EventArgs e)
	{
		DemNgheu++;
		lblNgheu.Text = "Nghêu: " + DemNgheu;

	}
	private void OnDauTruDem2Tapped(object sender, EventArgs e)
	{
		if (DemNgheu > 0)
		{
			DemNgheu--;
			lblNgheu.Text = "Nghêu : " + DemNgheu;
		}
	}

	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemMucOng++;
		lblMucOng.Text = "Mực ống: " + DemMucOng;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemMucOng > 0)
		{
			DemMucOng--;
			lblMucOng.Text = "Mực ống: " + DemMucOng;
		}
	}

	private void OnDauCongDem3Tapped(object sender, EventArgs e)
	{
		DemMucNangNut++;
		lblMucNangNut.Text = "Mực nang nút: " + DemMucNangNut;

	}
	private void OnDauTruDem3Tapped(object sender, EventArgs e)
	{
		if (DemMucNangNut > 0)
		{
			DemMucNangNut--;
			lblMucNangNut.Text = "Mực nang nút: " + DemMucNangNut;
		}
	}
	private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemSuaTuoi++;
		lblSuaTuoi.Text = "Sứa tươi: " + DemSuaTuoi;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemSuaTuoi > 0)
		{
			DemSuaTuoi--;
			lblSuaTuoi.Text = "Sứa tươi: " + DemSuaTuoi;
		}
	}
	private void OnDauCongDem4Tapped(object sender, EventArgs e)
	{
		DemVayCaHoi++;
		lblVayCaHoi.Text = "Vây cá Hồi: " + DemVayCaHoi;

	}
	private void OnDauTruDem4Tapped(object sender, EventArgs e)
	{
		if (DemVayCaHoi > 0)
		{
			DemVayCaHoi--;
			lblVayCaHoi.Text = "Vây cá Hồi : " + DemVayCaHoi;
		}
	}

	private void OnDauCongDem5Tapped(object sender, EventArgs e)
	{
		DemCaSauFillet++;
		lblCaSauFillet.Text = "Cá sấu fillet: " + DemCaSauFillet;

	}
	private void OnDauTruDem5Tapped(object sender, EventArgs e)
	{
		if (DemCaSauFillet > 0)
		{
			DemCaSauFillet--;
			lblCaSauFillet.Text = "Cá sấu fillet: " + DemCaSauFillet;
		}
	}

	private void OnDauCongDem6Tapped(object sender, EventArgs e)
	{
		DemCaBasa++;
		lblCaBasa.Text = "Cá Basa: " + DemCaBasa;

	}
	private void OnDauTruDem6Tapped(object sender, EventArgs e)
	{
		if (DemCaBasa > 0)
		{
			DemCaBasa--;
			lblCaBasa.Text = "Cá Basa: " + DemCaBasa;
		}
	}
	private void OnDauCongDem7Tapped(object sender, EventArgs e)
	{
		DemGheFaci++;
		lblGheFaci.Text = "Ghẹ Faci: " + DemGheFaci;

	}
	private void OnDauTruDem7Tapped(object sender, EventArgs e)
	{
		if (DemGheFaci > 0)
		{
			DemGheFaci--;
			lblGheFaci.Text = "Ghẹ Faci: " + DemGheFaci;
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

	private void OnTomTheTuoiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Tôm thẻ tươi", 84900, DemTomTheTuoi);

		var tomTheTuoi = GioHang.Instance.Items.First(i => i.Ten == "Tôm thẻ tươi");

		DisplayAlert("Chọn món", $"Bạn đã chọn Tôm thẻ tươi - Tổng số lượng: {DemTomTheTuoi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTomTheTuoi = 1;
		lblTomTheTuoi.Text = $"Tôm thẻ tươi: {DemTomTheTuoi}";
	}

	private async void OnTomTheTuoiPoint(object sender, PointerEventArgs e)
	{
		await imgTomTheTuoi.ScaleTo(1.1, 200);
		await lblTomTheTuoi.ScaleTo(1.1, 200);
	}

	private async void OnTomTheTuoiPointer(object sender, PointerEventArgs e)
	{
		await imgTomTheTuoi.ScaleTo(1.0, 200);
		await lblTomTheTuoi.ScaleTo(1.0, 200);
	}
	private void OnTomTichTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Tôm tích", 84900, DemTomTich);

		var baChiBo = GioHang.Instance.Items.First(i => i.Ten == "Tôm tích");

		DisplayAlert("Chọn món", $"Bạn đã chọn Tôm tích - Tổng số lượng: {DemTomTich}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTomTich = 1;
		lblTomTich.Text = $"Tôm tích: {DemTomTich}";
	}


	private async void OnTomTichPoint(object sender, PointerEventArgs e)
	{
		await imgTomTich.ScaleTo(1.1, 200);
		await lblTomTich.ScaleTo(1.1, 200);
	}
	private async void OnTomTichPointer(object sender, PointerEventArgs e)
	{
		await imgTomTich.ScaleTo(1.0, 200);
		await lblTomTich.ScaleTo(1.0, 200);
	}
	private void OnBaoTuCaBasaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bao tử cá Basa", 84900, DemBaoTuCaBasa);

		var BaoTuCaBasa = GioHang.Instance.Items.First(i => i.Ten == "Bao tử cá Basa");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bao tử cá Basa - Tổng số lượng: {DemBaoTuCaBasa}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBaoTuCaBasa = 1;
		lblBaoTuCaBasa.Text = $"Bao tử cá Basa: {DemBaoTuCaBasa}";
	}
	private async void OnBaoTuCaBasaPoint(object sender, PointerEventArgs e)
	{
		await imgBaoTuCaBasa.ScaleTo(1.1, 200);
		await lblBaoTuCaBasa.ScaleTo(1.1, 200);
	}

	private async void OnBaoTuCaBasaPointer(object sender, PointerEventArgs e)
	{
		await imgBaoTuCaBasa.ScaleTo(1.0, 200);
		await lblBaoTuCaBasa.ScaleTo(1.0, 200);
	}
	private void OnBachTuocBabyTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bạch Tuộc Baby", 84900, DemBachTuocBaby);

		var BachTuocBaby = GioHang.Instance.Items.First(i => i.Ten == "Bạch Tuộc Baby");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bạch Tuộc Baby - Tổng số lượng: {DemBachTuocBaby}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBachTuocBaby = 1;
		lblBachTuocBaby.Text = $"Bạch Tuộc Baby: {DemBachTuocBaby}";
	}

	private async void OnBachTuocBabyPoint(object sender, PointerEventArgs e)
	{
		await imgBachTuocBaby.ScaleTo(1.1, 200);
		await lblBachTuocBaby.ScaleTo(1.1, 200);
	}

	private async void OnBachTuocBabyPointer(object sender, PointerEventArgs e)
	{
		await imgBachTuocBaby.ScaleTo(1.0, 200);
		await lblBachTuocBaby.ScaleTo(1.0, 200);
	}
	private void OnNgheuTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nghêu ", 84900, DemNgheu);

		var Ngheu = GioHang.Instance.Items.First(i => i.Ten == "Nghêu ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nghêu  - Tổng số lượng: {DemNgheu}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNgheu = 1;
		lblNgheu.Text = $"Nghêu : {DemNgheu}";
	}

	private async void OnNgheuPoint(object sender, PointerEventArgs e)
	{
		await imgNgheu.ScaleTo(1.1, 200);
		await lblNgheu.ScaleTo(1.1, 200);
	}

	private async void OnNgheuPointer(object sender, PointerEventArgs e)
	{
		await imgNgheu.ScaleTo(1.0, 200);
		await lblNgheu.ScaleTo(1.0, 200);
	}
	private void OnMucOngTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mực ống", 84900, DemMucOng);

		var MucOng = GioHang.Instance.Items.First(i => i.Ten == "Mực ống");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mực ống - Tổng số lượng: {DemMucOng}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMucOng = 1;
		lblMucOng.Text = $"Mực ống: {DemMucOng}";
	}
	private async void OnMucOngPoint(object sender, PointerEventArgs e)
	{
		await imgMucOng.ScaleTo(1.1, 200);
		await lblMucOng.ScaleTo(1.1, 200);
	}

	private async void OnMucOngPointer(object sender, PointerEventArgs e)
	{
		await imgMucOng.ScaleTo(1.0, 200);
		await lblMucOng.ScaleTo(1.0, 200);
	}

	private void OnMucNangNutTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mực nang nút", 84900, DemMucNangNut);

		var MucNangNut = GioHang.Instance.Items.First(i => i.Ten == "Mực nang nút");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mực nang nút - Tổng số lượng: {DemMucNangNut}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMucNangNut = 1;
		lblMucNangNut.Text = $"Mực nang nút: {DemMucNangNut}";
	}
	private async void OnMucNangNutPoint(object sender, PointerEventArgs e)
	{
		await imgMucNangNut.ScaleTo(1.1, 200);
		await lblMucNangNut.ScaleTo(1.1, 200);
	}

	private async void OnMucNangNutPointer(object sender, PointerEventArgs e)
	{
		await imgMucNangNut.ScaleTo(1.0, 200);
		await lblMucNangNut.ScaleTo(1.0, 200);
	}


	private void OnSuaTuoiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Sứa tươi", 84900, DemSuaTuoi);

		var SuaTuoi = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Sứa tươi");

		DisplayAlert("Chọn món", $"Bạn đã chọn Sứa tươi - Tổng số lượng: {DemSuaTuoi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemSuaTuoi = 1;
		lblSuaTuoi.Text = $"Sứa tươi: {DemSuaTuoi}";
	}
	private async void OnSuaTuoiPoint(object sender, PointerEventArgs e)
	{
		await imgSuaTuoi.ScaleTo(1.1, 200);
		await lblSuaTuoi.ScaleTo(1.1, 200);
	}

	private async void OnSuaTuoiPointer(object sender, PointerEventArgs e)
	{
		await imgSuaTuoi.ScaleTo(1.0, 200);
		await lblSuaTuoi.ScaleTo(1.0, 200);
	}

	private void OnVayCaHoiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Vây cá Hồi ", 84900, DemVayCaHoi);

		var VayCaHoi = GioHang.Instance.Items.First(i => i.Ten == "Vây cá Hồi ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Vây cá Hồi  - Tổng số lượng: {DemVayCaHoi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemVayCaHoi = 1;
		lblVayCaHoi.Text = $"Vây cá Hồi : {DemVayCaHoi}";
	}

	private async void OnVayCaHoiPoint(object sender, PointerEventArgs e)
	{
		await imgVayCaHoi.ScaleTo(1.1, 200);
		await lblVayCaHoi.ScaleTo(1.1, 200);
	}

	private async void OnVayCaHoiPointer(object sender, PointerEventArgs e)
	{
		await imgVayCaHoi.ScaleTo(1.0, 200);
		await lblVayCaHoi.ScaleTo(1.0, 200);
	}
	private void OnCaSauFilletTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Cá sấu fillet", 84900, DemCaSauFillet);

		var CaSauFillet = GioHang.Instance.Items.First(i => i.Ten == "Cá sấu fillet");

		DisplayAlert("Chọn món", $"Bạn đã chọn Cá sấu fillet - Tổng số lượng: {DemCaSauFillet}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemCaSauFillet = 1;
		lblCaSauFillet.Text = $"Cá sấu fillet: {DemCaSauFillet}";
	}
	private async void OnCaSauFilletPoint(object sender, PointerEventArgs e)
	{
		await imgCaSauFillet.ScaleTo(1.1, 200);
		await lblCaSauFillet.ScaleTo(1.1, 200);
	}

	private async void OnCaSauFilletPointer(object sender, PointerEventArgs e)
	{
		await imgCaSauFillet.ScaleTo(1.0, 200);
		await lblCaSauFillet.ScaleTo(1.0, 200);
	}

	private void OnCaBasaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Cá basa", 84900, DemCaBasa);

		var CaBasa = GioHang.Instance.Items.First(i => i.Ten == "Cá basa");

		DisplayAlert("Chọn món", $"Bạn đã chọn Cá basa - Tổng số lượng: {DemCaBasa}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemCaBasa = 1;
		lblCaBasa.Text = $"Cá basa: {DemCaBasa}";
	}
	private async void OnCaBasaPoint(object sender, PointerEventArgs e)
	{
		await imgCaBasa.ScaleTo(1.1, 200);
		await lblCaBasa.ScaleTo(1.1, 200);
	}

	private async void OnCaBasaPointer(object sender, PointerEventArgs e)
	{
		await imgCaBasa.ScaleTo(1.0, 200);
		await lblCaBasa.ScaleTo(1.0, 200);
	}


	private void OnGheFaciTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Ghẹ Faci", 84900, DemGheFaci);

		var GheFaci = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Ghẹ Faci");

		DisplayAlert("Chọn món", $"Bạn đã chọn Ghẹ Faci - Tổng số lượng: {DemGheFaci}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemGheFaci = 1;
		lblGheFaci.Text = $"Ghẹ Faci: {DemGheFaci}";
	}
	private async void OnGheFaciPoint(object sender, PointerEventArgs e)
	{
		await imgGheFaci.ScaleTo(1.1, 200);
		await lblGheFaci.ScaleTo(1.1, 200);
	}

	private async void OnGheFaciPointer(object sender, PointerEventArgs e)
	{
		await imgGheFaci.ScaleTo(1.0, 200);
		await lblGheFaci.ScaleTo(1.0, 200);
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