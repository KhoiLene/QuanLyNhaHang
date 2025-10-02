namespace NhaHang;
using NhaHang.Services;
public partial class MenuThitPage : ContentPage
{
	int DemLoiVaiBo = 1;
	int DemBaChiBo = 1;
	int DemBapBoUc = 1;
	int DemGauBo = 1;
	int DemNacDamHeo = 1;
	int DemSuonHeo = 1;
	int DemTimHeo = 1;
	int DemDuiGaFillet = 1;

	public MenuThitPage()
	{
		InitializeComponent();
		lblLoiVaiBo.Text = "Lõi vai bò: " + DemLoiVaiBo;
		lblBaChiBo.Text = "Ba chỉ bò: " + DemBaChiBo;
		lblBapBoUc.Text = "Bắp bò Úc: " + DemBapBoUc;
		lblGauBo.Text = "Gầu bò: " + DemGauBo;
		lblNacDamHeo.Text = "Nạc dăm heo: " + DemNacDamHeo;
		lblSuonHeo.Text = "Sườn heo: " + DemSuonHeo;
		lblTimHeo.Text = "Tim heo: " + DemTimHeo;
		lblDuiGaFillet.Text = "Đùi gà fillet: " + DemDuiGaFillet;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemLoiVaiBo++;
		lblLoiVaiBo.Text = "Lõi vai bò: " + DemLoiVaiBo;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemLoiVaiBo > 0)
		{
			DemLoiVaiBo--;
			lblLoiVaiBo.Text = "Lõi vai bò: " + DemLoiVaiBo;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemBaChiBo++;
		lblBaChiBo.Text = "Ba chỉ bò: " + DemBaChiBo;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemBaChiBo > 0)
		{
			DemBaChiBo--;
			lblBaChiBo.Text = "Ba chỉ bò: " + DemBaChiBo;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemBapBoUc++;
		lblBapBoUc.Text = "Bắp bò Úc: " + DemBapBoUc;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemBapBoUc > 0)
		{
			DemBapBoUc--;
			lblBapBoUc.Text = "Bắp bò Úc: " + DemBapBoUc;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemGauBo++;
		lblGauBo.Text = "Gầu bò: " + DemGauBo;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemGauBo > 0)
		{
			DemGauBo--;
			lblGauBo.Text = "Gầu bò: " + DemGauBo;
		}
	}

	private void OnDauCongDem2Tapped(object sender, EventArgs e)
	{
		DemNacDamHeo++;
		lblNacDamHeo.Text = "Nạc dăm heo: " + DemNacDamHeo;

	}
	private void OnDauTruDem2Tapped(object sender, EventArgs e)
	{
		if (DemNacDamHeo > 0)
		{
			DemNacDamHeo--;
			lblNacDamHeo.Text = "Nạc dăm heo : " + DemNacDamHeo;
		}
	}

	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemSuonHeo++;
		lblSuonHeo.Text = "Sườn heo: " + DemSuonHeo;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemSuonHeo > 0)
		{
			DemSuonHeo--;
			lblSuonHeo.Text = "Sườn heo: " + DemSuonHeo;
		}
	}

	private void OnDauCongDem3Tapped(object sender, EventArgs e)
	{
		DemTimHeo++;
		lblTimHeo.Text = "Tim heo: " + DemTimHeo;

	}
	private void OnDauTruDem3Tapped(object sender, EventArgs e)
	{
		if (DemTimHeo > 0)
		{
			DemTimHeo--;
			lblTimHeo.Text = "Tim heo: " + DemTimHeo;
		}
	}
		private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemDuiGaFillet++;
		lblDuiGaFillet.Text = "Đùi gà fillet: " + DemDuiGaFillet;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemDuiGaFillet > 0)
		{
			DemDuiGaFillet--;
			lblDuiGaFillet.Text = "Đùi gà fillet: " + DemDuiGaFillet;
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

	private void OnLoiVaiBoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lõi vai bò", 200000, DemLoiVaiBo);

		var loiVaiBo = GioHang.Instance.Items.First(i => i.Ten == "Lõi vai bò");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lõi vai bò - Tổng số lượng: {DemLoiVaiBo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLoiVaiBo = 1;
		lblLoiVaiBo.Text = $"Lõi vai bò: {DemLoiVaiBo}";
	}

	private async void OnLoiVaiBoPoint(object sender, PointerEventArgs e)
	{
		await imgLoiVaiBo.ScaleTo(1.1, 200);      
		await lblLoiVaiBo.ScaleTo(1.1, 200);      
	}

	private async void OnLoiVaiBoPointer(object sender, PointerEventArgs e)
	{
		await imgLoiVaiBo.ScaleTo(1.1, 200);      
		await lblLoiVaiBo.ScaleTo(1.1, 200);      
	}
	private void OnBaChiBoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Ba Chỉ Bò", 200000, DemBaChiBo);

		var baChiBo = GioHang.Instance.Items.First(i => i.Ten == "Ba Chỉ Bò");

		DisplayAlert("Chọn món", $"Bạn đã chọn Ba Chỉ Bò - Tổng số lượng: {DemBaChiBo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBaChiBo = 1;
		lblBaChiBo.Text = $"Ba Chỉ Bò: {DemBaChiBo}";
	}


	private async void OnBaChiBoPoint(object sender, PointerEventArgs e)
	{
		await imgBaChiBo.ScaleTo(1.0, 200);
		await lblBaChiBo.ScaleTo(1.0, 200);
	}
	private async void OnBaChiBoPointer(object sender, PointerEventArgs e)
	{
		await imgBaChiBo.ScaleTo(1.0, 200);
		await lblBaChiBo.ScaleTo(1.0, 200);
	}
	private void OnBapBoUcTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bắp bò Úc", 250000, DemBapBoUc);

		var bapBoUc = GioHang.Instance.Items.First(i => i.Ten == "Bắp bò Úc");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bắp bò Úc - Tổng số lượng: {DemBapBoUc}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBapBoUc = 1;
		lblBapBoUc.Text = $"Bắp bò Úc: {DemBapBoUc}";
	}
	private async void OnBapBoUcPoint(object sender, PointerEventArgs e)
	{
		await imgBapBoUc.ScaleTo(1.1, 200);
		await lblBapBoUc.ScaleTo(1.1, 200);
	}

	private async void OnBapBoUcPointer(object sender, PointerEventArgs e)
	{
		await imgBapBoUc.ScaleTo(1.0, 200);
		await lblBapBoUc.ScaleTo(1.0, 200);
	}
	private void OnGauBoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Gầu bò", 250000, DemGauBo);

		var gauBo = GioHang.Instance.Items.First(i => i.Ten == "Gầu bò");

		DisplayAlert("Chọn món", $"Bạn đã chọn Gầu bò - Tổng số lượng: {DemGauBo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemGauBo = 1;
		lblGauBo.Text = $"Gầu bò: {DemGauBo}";
	}

	private async void OnGauBoPoint(object sender, PointerEventArgs e)
	{
		await imgGauBo.ScaleTo(1.1, 200);
		await lblGauBo.ScaleTo(1.1, 200);
	}

	private async void OnGauBoPointer(object sender, PointerEventArgs e)
	{
		await imgGauBo.ScaleTo(1.0, 200);
		await lblGauBo.ScaleTo(1.0, 200);
	}
	private void OnNacDamHeoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nạc dăm heo ", 250000, DemNacDamHeo);

		var nacDamHeo = GioHang.Instance.Items.First(i => i.Ten == "Nạc dăm heo ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nạc dăm heo  - Tổng số lượng: {DemNacDamHeo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNacDamHeo = 1;
		lblNacDamHeo.Text = $"Nạc dăm heo : {DemNacDamHeo}";
	}

	private async void OnNacDamHeoPoint(object sender, PointerEventArgs e)
	{
		await imgNacDamHeo.ScaleTo(1.1, 200);
		await lblNacDamHeo.ScaleTo(1.1, 200);
	}

	private async void OnNacDamHeoPointer(object sender, PointerEventArgs e)
	{
		await imgNacDamHeo.ScaleTo(1.0, 200);
		await lblNacDamHeo.ScaleTo(1.0, 200);
	}
	private void OnSuonHeoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Sườn heo", 250000, DemSuonHeo);

		var suonHeo = GioHang.Instance.Items.First(i => i.Ten == "Sườn heo");

		DisplayAlert("Chọn món", $"Bạn đã chọn Sườn heo - Tổng số lượng: {DemSuonHeo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemSuonHeo = 1;
		lblSuonHeo.Text = $"Sườn heo: {DemSuonHeo}";
	}
	private async void OnSuonHeoPoint(object sender, PointerEventArgs e)
	{
		await imgSuonHeo.ScaleTo(1.1, 200);
		await lblSuonHeo.ScaleTo(1.1, 200);
	}

	private async void OnSuonHeoPointer(object sender, PointerEventArgs e)
	{
		await imgSuonHeo.ScaleTo(1.0, 200);
		await lblSuonHeo.ScaleTo(1.0, 200);
	}

	private void OnTimHeoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Tim heo", 250000, DemTimHeo);

		var timHeo = GioHang.Instance.Items.First(i => i.Ten == "Tim heo");

		DisplayAlert("Chọn món", $"Bạn đã chọn Tim heo - Tổng số lượng: {DemTimHeo}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTimHeo = 1;
		lblTimHeo.Text = $"Tim heo: {DemTimHeo}";
	}
	private async void OnTimHeoPoint(object sender, PointerEventArgs e)
	{
		await imgTimHeo.ScaleTo(1.1, 200);
		await lblTimHeo.ScaleTo(1.1, 200);
	}

	private async void OnTimHeoPointer(object sender, PointerEventArgs e)
	{
		await imgTimHeo.ScaleTo(1.0, 200);
		await lblTimHeo.ScaleTo(1.0, 200);
	}


		private void OnDuiGaFilletTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Đùi gà Fillet", 250000, DemDuiGaFillet);

		var duiGafillet = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Đùi gà Fillet");

		DisplayAlert("Chọn món", $"Bạn đã chọn Đùi gà Fillet - Tổng số lượng: {DemDuiGaFillet}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemDuiGaFillet = 1;
		lblDuiGaFillet.Text = $"Đùi gà Fillet: {DemDuiGaFillet}";
	}
	private async void OnDuiGaFilletPoint(object sender, PointerEventArgs e)
	{
		await imgDuiGaFillet.ScaleTo(1.1, 200);
		await lblDuiGaFillet.ScaleTo(1.1, 200);
	}

	private async void OnDuiGaFilletPointer(object sender, PointerEventArgs e)
	{
		await imgDuiGaFillet.ScaleTo(1.0, 200);
		await lblDuiGaFillet.ScaleTo(1.0, 200);
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





	// Ví dụ gọi AddToCart() trong handler khi user tap món:
}