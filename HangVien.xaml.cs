namespace NhaHang;
using NhaHang.Services;
public partial class HangVien : ContentPage
{
	int DemTrungGa = 1;
	int DemTrungCut = 1;
	int DemPasteBo = 1;
	int DemPasteHeo = 1;
	int DemPasteGa = 1;
	int DemDauHuLuaNon = 1;
	int DemVienBo = 1;
	int DemBanhBaoHaiSan = 1;
	int DemHaCaoNga = 1;
	int DemThanhCua = 1;
	int DemLosterBall = 1;
	int DemFishSandwich = 1;

	public HangVien()
	{
		InitializeComponent();
		lblTrungGa.Text = "Trứng gà: " + DemTrungGa;
		lblTrungCut.Text = "Trứng cút: " + DemTrungCut;
		lblPasteBo.Text = "Paste bò: " + DemPasteBo;
		lblPasteHeo.Text = "Paste heo: " + DemPasteHeo;
		lblPasteGa.Text = "Paste gà: " + DemPasteGa;
		lblDauHuLuaNon.Text = "Đạu hũ lụa non: " + DemDauHuLuaNon;
		lblVienBo.Text = "Viên bò: " + DemVienBo;
		lblBanhBaoHaiSan.Text = "Bánh bao hải sản: " + DemBanhBaoHaiSan;
		lblHaCaoNga.Text = "Há cảo Nga: " + DemHaCaoNga;
		lblThanhCua.Text = "Thanh cua: " + DemThanhCua;
		lblLosterBall.Text = "Loster ball: " + DemLosterBall;
		lblFishSandwich.Text = "Fish sandwich: " + DemFishSandwich;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemTrungGa++;
		lblTrungGa.Text = "Trứng gà: " + DemTrungGa;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemTrungGa > 0)
		{
			DemTrungGa--;
			lblTrungGa.Text = "Trứng gà: " + DemTrungGa;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemTrungCut++;
		lblTrungCut.Text = "Trứng cút: " + DemTrungCut;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemTrungCut > 0)
		{
			DemTrungCut--;
			lblTrungCut.Text = "Trứng cút: " + DemTrungCut;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemPasteBo++;
		lblPasteBo.Text = "Paste bò: " + DemPasteBo;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemPasteBo > 0)
		{
			DemPasteBo--;
			lblPasteBo.Text = "Paste bò: " + DemPasteBo;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemPasteHeo++;
		lblPasteHeo.Text = "Paste heo: " + DemPasteHeo;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemPasteHeo > 0)
		{
			DemPasteHeo--;
			lblPasteHeo.Text = "Paste heo: " + DemPasteHeo;
		}
	}

	private void OnDauCongDem2Tapped(object sender, EventArgs e)
	{
		DemPasteGa++;
		lblPasteGa.Text = "Paste gà: " + DemPasteGa;

	}
	private void OnDauTruDem2Tapped(object sender, EventArgs e)
	{
		if (DemPasteGa > 0)
		{
			DemPasteGa--;
			lblPasteGa.Text = "Paste gà : " + DemPasteGa;
		}
	}

	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemDauHuLuaNon++;
		lblDauHuLuaNon.Text = "Đạu hũ lụa non: " + DemDauHuLuaNon;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemDauHuLuaNon > 0)
		{
			DemDauHuLuaNon--;
			lblDauHuLuaNon.Text = "Đạu hũ lụa non: " + DemDauHuLuaNon;
		}
	}

	private void OnDauCongDem3Tapped(object sender, EventArgs e)
	{
		DemVienBo++;
		lblVienBo.Text = "Viên bò: " + DemVienBo;

	}
	private void OnDauTruDem3Tapped(object sender, EventArgs e)
	{
		if (DemVienBo > 0)
		{
			DemVienBo--;
			lblVienBo.Text = "Viên bò: " + DemVienBo;
		}
	}
	private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemBanhBaoHaiSan++;
		lblBanhBaoHaiSan.Text = "Bánh bao hải sản: " + DemBanhBaoHaiSan;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemBanhBaoHaiSan > 0)
		{
			DemBanhBaoHaiSan--;
			lblBanhBaoHaiSan.Text = "Bánh bao hải sản: " + DemBanhBaoHaiSan;
		}
	}
	private void OnDauCongDem4Tapped(object sender, EventArgs e)
	{
		DemHaCaoNga++;
		lblHaCaoNga.Text = "Há cảo Nga: " + DemHaCaoNga;

	}
	private void OnDauTruDem4Tapped(object sender, EventArgs e)
	{
		if (DemHaCaoNga > 0)
		{
			DemHaCaoNga--;
			lblHaCaoNga.Text = "Há cảo Nga : " + DemHaCaoNga;
		}
	}

	private void OnDauCongDem5Tapped(object sender, EventArgs e)
	{
		DemThanhCua++;
		lblThanhCua.Text = "Thanh cua: " + DemThanhCua;

	}
	private void OnDauTruDem5Tapped(object sender, EventArgs e)
	{
		if (DemThanhCua > 0)
		{
			DemThanhCua--;
			lblThanhCua.Text = "Thanh cua: " + DemThanhCua;
		}
	}

	private void OnDauCongDem6Tapped(object sender, EventArgs e)
	{
		DemLosterBall++;
		lblLosterBall.Text = "Loster ball: " + DemLosterBall;

	}
	private void OnDauTruDem6Tapped(object sender, EventArgs e)
	{
		if (DemLosterBall > 0)
		{
			DemLosterBall--;
			lblLosterBall.Text = "Loster ball: " + DemLosterBall;
		}
	}
	private void OnDauCongDem7Tapped(object sender, EventArgs e)
	{
		DemFishSandwich++;
		lblFishSandwich.Text = "Fish sandwich: " + DemFishSandwich;

	}
	private void OnDauTruDem7Tapped(object sender, EventArgs e)
	{
		if (DemFishSandwich > 0)
		{
			DemFishSandwich--;
			lblFishSandwich.Text = "Fish sandwich: " + DemFishSandwich;
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

	private void OnTrungGaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Trứng gà", 20000, DemTrungGa);

		var TrungGa = GioHang.Instance.Items.First(i => i.Ten == "Trứng gà");

		DisplayAlert("Chọn món", $"Bạn đã chọn Trứng gà - Tổng số lượng: {DemTrungGa}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTrungGa = 1;
		lblTrungGa.Text = $"Trứng gà: {DemTrungGa}";
	}

	private async void OnTrungGaPoint(object sender, PointerEventArgs e)
	{
		await imgTrungGa.ScaleTo(1.1, 200);
		await lblTrungGa.ScaleTo(1.1, 200);
	}

	private async void OnTrungGaPointer(object sender, PointerEventArgs e)
	{
		await imgTrungGa.ScaleTo(1.0, 200);
		await lblTrungGa.ScaleTo(1.0, 200);
	}
	private void OnTrungCutTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Trứng cút", 20000, DemTrungCut);

		var baChiBo = GioHang.Instance.Items.First(i => i.Ten == "Trứng cút");

		DisplayAlert("Chọn món", $"Bạn đã chọn Trứng cút - Tổng số lượng: {DemTrungCut}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTrungCut = 1;
		lblTrungCut.Text = $"Trứng cút: {DemTrungCut}";
	}


	private async void OnTrungCutPoint(object sender, PointerEventArgs e)
	{
		await imgTrungCut.ScaleTo(1.1, 200);
		await lblTrungCut.ScaleTo(1.1, 200);
	}
	private async void OnTrungCutPointer(object sender, PointerEventArgs e)
	{
		await imgTrungCut.ScaleTo(1.0, 200);
		await lblTrungCut.ScaleTo(1.0, 200);
	}
	private void OnPasteBoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Paste bò", 20000, DemPasteBo);

		var PasteBo = GioHang.Instance.Items.First(i => i.Ten == "Paste bò");

		DisplayAlert("Chọn món", $"Bạn đã chọn Paste bò - Tổng số lượng: {DemPasteBo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemPasteBo = 1;
		lblPasteBo.Text = $"Paste bò: {DemPasteBo}";
	}
	private async void OnPasteBoPoint(object sender, PointerEventArgs e)
	{
		await imgPasteBo.ScaleTo(1.1, 200);
		await lblPasteBo.ScaleTo(1.1, 200);
	}

	private async void OnPasteBoPointer(object sender, PointerEventArgs e)
	{
		await imgPasteBo.ScaleTo(1.0, 200);
		await lblPasteBo.ScaleTo(1.0, 200);
	}
	private void OnPasteHeoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Paste heo", 20000, DemPasteHeo);

		var PasteHeo = GioHang.Instance.Items.First(i => i.Ten == "Paste heo");

		DisplayAlert("Chọn món", $"Bạn đã chọn Paste heo - Tổng số lượng: {DemPasteHeo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemPasteHeo = 1;
		lblPasteHeo.Text = $"Paste heo: {DemPasteHeo}";
	}

	private async void OnPasteHeoPoint(object sender, PointerEventArgs e)
	{
		await imgPasteHeo.ScaleTo(1.1, 200);
		await lblPasteHeo.ScaleTo(1.1, 200);
	}

	private async void OnPasteHeoPointer(object sender, PointerEventArgs e)
	{
		await imgPasteHeo.ScaleTo(1.0, 200);
		await lblPasteHeo.ScaleTo(1.0, 200);
	}
	private void OnPasteGaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Paste gà ", 20000, DemPasteGa);

		var PasteGa = GioHang.Instance.Items.First(i => i.Ten == "Paste gà ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Paste gà  - Tổng số lượng: {DemPasteGa}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemPasteGa = 1;
		lblPasteGa.Text = $"Paste gà : {DemPasteGa}";
	}

	private async void OnPasteGaPoint(object sender, PointerEventArgs e)
	{
		await imgPasteGa.ScaleTo(1.1, 200);
		await lblPasteGa.ScaleTo(1.1, 200);
	}

	private async void OnPasteGaPointer(object sender, PointerEventArgs e)
	{
		await imgPasteGa.ScaleTo(1.0, 200);
		await lblPasteGa.ScaleTo(1.0, 200);
	}
	private void OnDauHuLuaNonTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Đạu hũ lụa non", 20000, DemDauHuLuaNon);

		var DauHuLuaNon = GioHang.Instance.Items.First(i => i.Ten == "Đạu hũ lụa non");

		DisplayAlert("Chọn món", $"Bạn đã chọn Đạu hũ lụa non - Tổng số lượng: {DemDauHuLuaNon}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemDauHuLuaNon = 1;
		lblDauHuLuaNon.Text = $"Đạu hũ lụa non: {DemDauHuLuaNon}";
	}
	private async void OnDauHuLuaNonPoint(object sender, PointerEventArgs e)
	{
		await imgDauHuLuaNon.ScaleTo(1.1, 200);
		await lblDauHuLuaNon.ScaleTo(1.1, 200);
	}

	private async void OnDauHuLuaNonPointer(object sender, PointerEventArgs e)
	{
		await imgDauHuLuaNon.ScaleTo(1.0, 200);
		await lblDauHuLuaNon.ScaleTo(1.0, 200);
	}

	private void OnVienBoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Viên bò", 20000, DemVienBo);

		var VienBo = GioHang.Instance.Items.First(i => i.Ten == "Viên bò");

		DisplayAlert("Chọn món", $"Bạn đã chọn Viên bò - Tổng số lượng: {DemVienBo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemVienBo = 1;
		lblVienBo.Text = $"Viên bò: {DemVienBo}";
	}
	private async void OnVienBoPoint(object sender, PointerEventArgs e)
	{
		await imgVienBo.ScaleTo(1.1, 200);
		await lblVienBo.ScaleTo(1.1, 200);
	}

	private async void OnVienBoPointer(object sender, PointerEventArgs e)
	{
		await imgVienBo.ScaleTo(1.0, 200);
		await lblVienBo.ScaleTo(1.0, 200);
	}


	private void OnBanhBaoHaiSanTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bánh bao hải sản", 20000, DemBanhBaoHaiSan);

		var BanhBaoHaiSan = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Bánh bao hải sản");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bánh bao hải sản - Tổng số lượng: {DemBanhBaoHaiSan}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBanhBaoHaiSan = 1;
		lblBanhBaoHaiSan.Text = $"Bánh bao hải sản: {DemBanhBaoHaiSan}";
	}
	private async void OnBanhBaoHaiSanPoint(object sender, PointerEventArgs e)
	{
		await imgBanhBaoHaiSan.ScaleTo(1.1, 200);
		await lblBanhBaoHaiSan.ScaleTo(1.1, 200);
	}

	private async void OnBanhBaoHaiSanPointer(object sender, PointerEventArgs e)
	{
		await imgBanhBaoHaiSan.ScaleTo(1.0, 200);
		await lblBanhBaoHaiSan.ScaleTo(1.0, 200);
	}

	private void OnHaCaoNgaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Há cảo Nga ", 20000, DemHaCaoNga);

		var HaCaoNga = GioHang.Instance.Items.First(i => i.Ten == "Há cảo Nga ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Há cảo Nga  - Tổng số lượng: {DemHaCaoNga}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemHaCaoNga = 1;
		lblHaCaoNga.Text = $"Há cảo Nga : {DemHaCaoNga}";
	}

	private async void OnHaCaoNgaPoint(object sender, PointerEventArgs e)
	{
		await imgHaCaoNga.ScaleTo(1.1, 200);
		await lblHaCaoNga.ScaleTo(1.1, 200);
	}

	private async void OnHaCaoNgaPointer(object sender, PointerEventArgs e)
	{
		await imgHaCaoNga.ScaleTo(1.0, 200);
		await lblHaCaoNga.ScaleTo(1.0, 200);
	}
	private void OnThanhCuaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Thanh cua", 20000, DemThanhCua);

		var ThanhCua = GioHang.Instance.Items.First(i => i.Ten == "Thanh cua");

		DisplayAlert("Chọn món", $"Bạn đã chọn Thanh cua - Tổng số lượng: {DemThanhCua}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemThanhCua = 1;
		lblThanhCua.Text = $"Thanh cua: {DemThanhCua}";
	}
	private async void OnThanhCuaPoint(object sender, PointerEventArgs e)
	{
		await imgThanhCua.ScaleTo(1.1, 200);
		await lblThanhCua.ScaleTo(1.1, 200);
	}

	private async void OnThanhCuaPointer(object sender, PointerEventArgs e)
	{
		await imgThanhCua.ScaleTo(1.0, 200);
		await lblThanhCua.ScaleTo(1.0, 200);
	}

	private void OnLosterBallTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Loster ball", 20000, DemLosterBall);

		var LosterBall = GioHang.Instance.Items.First(i => i.Ten == "Loster ball");

		DisplayAlert("Chọn món", $"Bạn đã chọn Loster ball - Tổng số lượng: {DemLosterBall}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLosterBall = 1;
		lblLosterBall.Text = $"Loster ball: {DemLosterBall}";
	}
	private async void OnLosterBallPoint(object sender, PointerEventArgs e)
	{
		await imgLosterBall.ScaleTo(1.1, 200);
		await lblLosterBall.ScaleTo(1.1, 200);
	}

	private async void OnLosterBallPointer(object sender, PointerEventArgs e)
	{
		await imgLosterBall.ScaleTo(1.0, 200);
		await lblLosterBall.ScaleTo(1.0, 200);
	}


	private void OnFishSandwichTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Fish sandwich", 20000, DemFishSandwich);

		var FishSandwich = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Fish sandwich");

		DisplayAlert("Chọn món", $"Bạn đã chọn Fish sandwich - Tổng số lượng: {DemFishSandwich}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemFishSandwich = 1;
		lblFishSandwich.Text = $"Fish sandwich: {DemFishSandwich}";
	}
	private async void OnFishSandwichPoint(object sender, PointerEventArgs e)
	{
		await imgFishSandwich.ScaleTo(1.1, 200);
		await lblFishSandwich.ScaleTo(1.1, 200);
	}

	private async void OnFishSandwichPointer(object sender, PointerEventArgs e)
	{
		await imgFishSandwich.ScaleTo(1.0, 200);
		await lblFishSandwich.ScaleTo(1.0, 200);
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