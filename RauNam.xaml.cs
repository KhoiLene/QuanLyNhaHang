namespace NhaHang;
using NhaHang.Services;
public partial class RauNam : ContentPage
{
	int DemNamTramTrang = 1;
	int DemNamTien = 1;
	int DemNamXoe = 1;
	int DemNamHaiSan = 1;
	int DemNamViCuaNau = 1;
	int DemNamHoangKim = 1;
	int DemCaiBeXanh = 1;
	int DemBapMi = 1;
	int DemMongToi = 1;
	int DemRauMuong = 1;
	int DemTanO = 1;
	int DemRauMam = 1;
	int DemCaiThao = 1;
	int DemMuopHuong = 1;
	int DemKhoaiMonChien = 1;
	int DemBacHa = 1;

	public RauNam()
	{
		InitializeComponent();
		lblNamTramTrang.Text = "Nấm trâm trắng: " + DemNamTramTrang;
		lblNamTien.Text = "Nấm tiên: " + DemNamTien;
		lblNamXoe.Text = "Nấm xoè: " + DemNamXoe;
		lblNamHaiSan.Text = "Nấm hải sản: " + DemNamHaiSan;
		lblNamViCuaNau.Text = "Nấm vị cua nâu: " + DemNamViCuaNau;
		lblNamHoangKim.Text = "Nấm hoang kim: " + DemNamHoangKim;
		lblCaiBeXanh.Text = "Cải bẹ xanh: " + DemCaiBeXanh;
		lblBapMi.Text = "Bắp MĨ: " + DemBapMi;
		lblMongToi.Text = "Mồng tơi: " + DemMongToi;
		lblRauMuong.Text = "Rau muống: " + DemRauMuong;
		lblTanO.Text = "Tần ô: " + DemTanO;
		lblRauMam.Text = "Rau mầm: " + DemRauMam;
		lblCaiThao.Text = "Cải thảo: " + DemCaiThao;
		lblMuopHuong.Text = "Mướp hương: " + DemMuopHuong;
		lblKhoaiMonChien.Text = "Khoai môn chiên: " + DemKhoaiMonChien;
		lblBacHa.Text = "Bạc hà: " + DemBacHa;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemNamTramTrang++;
		lblNamTramTrang.Text = "Nấm trâm trắng: " + DemNamTramTrang;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemNamTramTrang > 0)
		{
			DemNamTramTrang--;
			lblNamTramTrang.Text = "Nấm trâm trắng: " + DemNamTramTrang;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemNamTien++;
		lblNamTien.Text = "Nấm tiên: " + DemNamTien;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemNamTien > 0)
		{
			DemNamTien--;
			lblNamTien.Text = "Nấm tiên: " + DemNamTien;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemNamXoe++;
		lblNamXoe.Text = "Nấm xoè: " + DemNamXoe;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemNamXoe > 0)
		{
			DemNamXoe--;
			lblNamXoe.Text = "Nấm xoè: " + DemNamXoe;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemNamHaiSan++;
		lblNamHaiSan.Text = "Nấm hải sản: " + DemNamHaiSan;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemNamHaiSan > 0)
		{
			DemNamHaiSan--;
			lblNamHaiSan.Text = "Nấm hải sản: " + DemNamHaiSan;
		}
	}

	private void OnDauCongDem2Tapped(object sender, EventArgs e)
	{
		DemNamViCuaNau++;
		lblNamViCuaNau.Text = "Nấm vị cua nâu: " + DemNamViCuaNau;

	}
	private void OnDauTruDem2Tapped(object sender, EventArgs e)
	{
		if (DemNamViCuaNau > 0)
		{
			DemNamViCuaNau--;
			lblNamViCuaNau.Text = "Nấm vị cua nâu : " + DemNamViCuaNau;
		}
	}

	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemNamHoangKim++;
		lblNamHoangKim.Text = "Nấm hoang kim: " + DemNamHoangKim;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemNamHoangKim > 0)
		{
			DemNamHoangKim--;
			lblNamHoangKim.Text = "Nấm hoang kim: " + DemNamHoangKim;
		}
	}

	private void OnDauCongDem3Tapped(object sender, EventArgs e)
	{
		DemCaiBeXanh++;
		lblCaiBeXanh.Text = "Cải bẹ xanh: " + DemCaiBeXanh;

	}
	private void OnDauTruDem3Tapped(object sender, EventArgs e)
	{
		if (DemCaiBeXanh > 0)
		{
			DemCaiBeXanh--;
			lblCaiBeXanh.Text = "Cải bẹ xanh: " + DemCaiBeXanh;
		}
	}
	private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemBapMi++;
		lblBapMi.Text = "Bắp MĨ: " + DemBapMi;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemBapMi > 0)
		{
			DemBapMi--;
			lblBapMi.Text = "Bắp MĨ: " + DemBapMi;
		}
	}
	private void OnDauCongDem4Tapped(object sender, EventArgs e)
	{
		DemMongToi++;
		lblMongToi.Text = "Mồng tơi: " + DemMongToi;

	}
	private void OnDauTruDem4Tapped(object sender, EventArgs e)
	{
		if (DemMongToi > 0)
		{
			DemMongToi--;
			lblMongToi.Text = "Mồng tơi : " + DemMongToi;
		}
	}

	private void OnDauCongDem5Tapped(object sender, EventArgs e)
	{
		DemRauMuong++;
		lblRauMuong.Text = "Rau muống: " + DemRauMuong;

	}
	private void OnDauTruDem5Tapped(object sender, EventArgs e)
	{
		if (DemRauMuong > 0)
		{
			DemRauMuong--;
			lblRauMuong.Text = "Rau muống: " + DemRauMuong;
		}
	}

	private void OnDauCongDem6Tapped(object sender, EventArgs e)
	{
		DemTanO++;
		lblTanO.Text = "Tần ô: " + DemTanO;

	}
	private void OnDauTruDem6Tapped(object sender, EventArgs e)
	{
		if (DemTanO > 0)
		{
			DemTanO--;
			lblTanO.Text = "Tần ô: " + DemTanO;
		}
	}
	private void OnDauCongDem7Tapped(object sender, EventArgs e)
	{
		DemRauMam++;
		lblRauMam.Text = "Rau mầm: " + DemRauMam;

	}
	private void OnDauTruDem7Tapped(object sender, EventArgs e)
	{
		if (DemRauMam > 0)
		{
			DemRauMam--;
			lblRauMam.Text = "Rau mầm: " + DemRauMam;
		}
	}
	private void OnDauCongDem8Tapped(object sender, EventArgs e)
	{
		DemCaiThao++;
		lblCaiThao.Text = "Cải thảo: " + DemCaiThao;

	}
	private void OnDauTruDem8Tapped(object sender, EventArgs e)
	{
		if (DemCaiThao > 0)
		{
			DemCaiThao--;
			lblCaiThao.Text = "Rau mầm: " + DemCaiThao;
		}
	}
	private void OnDauCongDem9Tapped(object sender, EventArgs e)
	{
		DemMuopHuong++;
		lblMuopHuong.Text = "Mướp hương: " + DemMuopHuong;

	}
	private void OnDauTruDem9Tapped(object sender, EventArgs e)
	{
		if (DemMuopHuong > 0)
		{
			DemMuopHuong--;
			lblMuopHuong.Text = "Mướp hương: " + DemMuopHuong;
		}
	}
	private void OnDauCongDem10Tapped(object sender, EventArgs e)
	{
		DemKhoaiMonChien++;
		lblKhoaiMonChien.Text = "Khoai Môn Chiên: " + DemKhoaiMonChien;

	}
	private void OnDauTruDem10Tapped(object sender, EventArgs e)
	{
		if (DemKhoaiMonChien > 0)
		{
			DemKhoaiMonChien--;
			lblKhoaiMonChien.Text = "Khoai môn chiên: " + DemKhoaiMonChien;
		}
	}
	private void OnDauCongDem11Tapped(object sender, EventArgs e)
	{
		DemBacHa++;
		lblBacHa.Text = "Bạc hà: " + DemBacHa;

	}
	private void OnDauTruDem11Tapped(object sender, EventArgs e)
	{
		if (DemBacHa > 0)
		{
			DemBacHa--;
			lblBacHa.Text = "Bạc hà: " + DemBacHa;
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

	private void OnNamTramTrangTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nấm trâm trắng", 25000, DemNamTramTrang);

		var NamTramTrang = GioHang.Instance.Items.First(i => i.Ten == "Nấm trâm trắng");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nấm trâm trắng - Tổng số lượng: {DemNamTramTrang}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNamTramTrang = 1;
		lblNamTramTrang.Text = $"Nấm trâm trắng: {DemNamTramTrang}";
	}

	private async void OnNamTramTrangPoint(object sender, PointerEventArgs e)
	{
		await imgNamTramTrang.ScaleTo(1.1, 200);
		await lblNamTramTrang.ScaleTo(1.1, 200);
	}

	private async void OnNamTramTrangPointer(object sender, PointerEventArgs e)
	{
		await imgNamTramTrang.ScaleTo(1.0, 200);
		await lblNamTramTrang.ScaleTo(1.0, 200);
	}
	private void OnNamTienTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nấm tiên", 25000, DemNamTien);

		var baChiBo = GioHang.Instance.Items.First(i => i.Ten == "Nấm tiên");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nấm tiên - Tổng số lượng: {DemNamTien}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNamTien = 1;
		lblNamTien.Text = $"Nấm tiên: {DemNamTien}";
	}


	private async void OnNamTienPoint(object sender, PointerEventArgs e)
	{
		await imgNamTien.ScaleTo(1.1, 200);
		await lblNamTien.ScaleTo(1.1, 200);
	}
	private async void OnNamTienPointer(object sender, PointerEventArgs e)
	{
		await imgNamTien.ScaleTo(1.0, 200);
		await lblNamTien.ScaleTo(1.0, 200);
	}
	private void OnNamXoeTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nấm xoè", 25000, DemNamXoe);

		var NamXoe = GioHang.Instance.Items.First(i => i.Ten == "Nấm xoè");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nấm xoè - Tổng số lượng: {DemNamXoe}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNamXoe = 1;
		lblNamXoe.Text = $"Nấm xoè: {DemNamXoe}";
	}
	private async void OnNamXoePoint(object sender, PointerEventArgs e)
	{
		await imgNamXoe.ScaleTo(1.1, 200);
		await lblNamXoe.ScaleTo(1.1, 200);
	}

	private async void OnNamXoePointer(object sender, PointerEventArgs e)
	{
		await imgNamXoe.ScaleTo(1.0, 200);
		await lblNamXoe.ScaleTo(1.0, 200);
	}
	private void OnNamHaiSanTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nấm hải sản", 25000, DemNamHaiSan);

		var NamHaiSan = GioHang.Instance.Items.First(i => i.Ten == "Nấm hải sản");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nấm hải sản - Tổng số lượng: {DemNamHaiSan}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNamHaiSan = 1;
		lblNamHaiSan.Text = $"Nấm hải sản: {DemNamHaiSan}";
	}

	private async void OnNamHaiSanPoint(object sender, PointerEventArgs e)
	{
		await imgNamHaiSan.ScaleTo(1.1, 200);
		await lblNamHaiSan.ScaleTo(1.1, 200);
	}

	private async void OnNamHaiSanPointer(object sender, PointerEventArgs e)
	{
		await imgNamHaiSan.ScaleTo(1.0, 200);
		await lblNamHaiSan.ScaleTo(1.0, 200);
	}
	private void OnNamViCuaNauTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nấm vị cua nâu ", 25000, DemNamViCuaNau);

		var NamViCuaNau = GioHang.Instance.Items.First(i => i.Ten == "Nấm vị cua nâu ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nấm vị cua nâu  - Tổng số lượng: {DemNamViCuaNau}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNamViCuaNau = 1;
		lblNamViCuaNau.Text = $"Nấm vị cua nâu : {DemNamViCuaNau}";
	}

	private async void OnNamViCuaNauPoint(object sender, PointerEventArgs e)
	{
		await imgNamViCuaNau.ScaleTo(1.1, 200);
		await lblNamViCuaNau.ScaleTo(1.1, 200);
	}

	private async void OnNamViCuaNauPointer(object sender, PointerEventArgs e)
	{
		await imgNamViCuaNau.ScaleTo(1.0, 200);
		await lblNamViCuaNau.ScaleTo(1.0, 200);
	}
	private void OnNamHoangKimTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Nấm hoang kim", 25000, DemNamHoangKim);

		var NamHoangKim = GioHang.Instance.Items.First(i => i.Ten == "Nấm hoang kim");

		DisplayAlert("Chọn món", $"Bạn đã chọn Nấm hoang kim - Tổng số lượng: {DemNamHoangKim}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemNamHoangKim = 1;
		lblNamHoangKim.Text = $"Nấm hoang kim: {DemNamHoangKim}";
	}
	private async void OnNamHoangKimPoint(object sender, PointerEventArgs e)
	{
		await imgNamHoangKim.ScaleTo(1.1, 200);
		await lblNamHoangKim.ScaleTo(1.1, 200);
	}

	private async void OnNamHoangKimPointer(object sender, PointerEventArgs e)
	{
		await imgNamHoangKim.ScaleTo(1.0, 200);
		await lblNamHoangKim.ScaleTo(1.0, 200);
	}

	private void OnCaiBeXanhTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Cải bẹ xanh", 10000, DemCaiBeXanh);

		var CaiBeXanh = GioHang.Instance.Items.First(i => i.Ten == "Cải bẹ xanh");

		DisplayAlert("Chọn món", $"Bạn đã chọn Cải bẹ xanh - Tổng số lượng: {DemCaiBeXanh}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemCaiBeXanh = 1;
		lblCaiBeXanh.Text = $"Cải bẹ xanh: {DemCaiBeXanh}";
	}
	private async void OnCaiBeXanhPoint(object sender, PointerEventArgs e)
	{
		await imgCaiBeXanh.ScaleTo(1.1, 200);
		await lblCaiBeXanh.ScaleTo(1.1, 200);
	}

	private async void OnCaiBeXanhPointer(object sender, PointerEventArgs e)
	{
		await imgCaiBeXanh.ScaleTo(1.0, 200);
		await lblCaiBeXanh.ScaleTo(1.0, 200);
	}


	private void OnBapMiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bắp MĨ", 10000, DemBapMi);

		var BapMi = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Bắp MĨ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bắp MĨ - Tổng số lượng: {DemBapMi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBapMi = 1;
		lblBapMi.Text = $"Bắp MĨ: {DemBapMi}";
	}
	private async void OnBapMiPoint(object sender, PointerEventArgs e)
	{
		await imgBapMi.ScaleTo(1.1, 200);
		await lblBapMi.ScaleTo(1.1, 200);
	}

	private async void OnBapMiPointer(object sender, PointerEventArgs e)
	{
		await imgBapMi.ScaleTo(1.0, 200);
		await lblBapMi.ScaleTo(1.0, 200);
	}

	private void OnMongToiTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mồng tơi ", 10000, DemMongToi);

		var MongToi = GioHang.Instance.Items.First(i => i.Ten == "Mồng tơi ");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mồng tơi  - Tổng số lượng: {DemMongToi}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMongToi = 1;
		lblMongToi.Text = $"Mồng tơi : {DemMongToi}";
	}

	private async void OnMongToiPoint(object sender, PointerEventArgs e)
	{
		await imgMongToi.ScaleTo(1.1, 200);
		await lblMongToi.ScaleTo(1.1, 200);
	}

	private async void OnMongToiPointer(object sender, PointerEventArgs e)
	{
		await imgMongToi.ScaleTo(1.0, 200);
		await lblMongToi.ScaleTo(1.0, 200);
	}
	private void OnRauMuongTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Rau muống", 10000, DemRauMuong);

		var RauMuong = GioHang.Instance.Items.First(i => i.Ten == "Rau muống");

		DisplayAlert("Chọn món", $"Bạn đã chọn Rau muống - Tổng số lượng: {DemRauMuong}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemRauMuong = 1;
		lblRauMuong.Text = $"Rau muống: {DemRauMuong}";
	}
	private async void OnRauMuongPoint(object sender, PointerEventArgs e)
	{
		await imgRauMuong.ScaleTo(1.1, 200);
		await lblRauMuong.ScaleTo(1.1, 200);
	}

	private async void OnRauMuongPointer(object sender, PointerEventArgs e)
	{
		await imgRauMuong.ScaleTo(1.0, 200);
		await lblRauMuong.ScaleTo(1.0, 200);
	}

	private void OnTanOTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Tần ô", 10000, DemTanO);

		var TanO = GioHang.Instance.Items.First(i => i.Ten == "Tần ô");

		DisplayAlert("Chọn món", $"Bạn đã chọn Tần ô - Tổng số lượng: {DemTanO}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemTanO = 1;
		lblTanO.Text = $"Tần ô: {DemTanO}";
	}
	private async void OnTanOPoint(object sender, PointerEventArgs e)
	{
		await imgTanO.ScaleTo(1.1, 200);
		await lblTanO.ScaleTo(1.1, 200);
	}

	private async void OnTanOPointer(object sender, PointerEventArgs e)
	{
		await imgTanO.ScaleTo(1.0, 200);
		await lblTanO.ScaleTo(1.0, 200);
	}


	private void OnRauMamTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Rau mầm", 10000, DemRauMam);

		var RauMam = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Rau mầm");

		DisplayAlert("Chọn món", $"Bạn đã chọn Rau mầm - Tổng số lượng: {DemRauMam}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemRauMam = 1;
		lblRauMam.Text = $"Rau mầm: {DemRauMam}";
	}
	private async void OnRauMamPoint(object sender, PointerEventArgs e)
	{
		await imgRauMam.ScaleTo(1.1, 200);
		await lblRauMam.ScaleTo(1.1, 200);
	}

	private async void OnRauMamPointer(object sender, PointerEventArgs e)
	{
		await imgRauMam.ScaleTo(1.0, 200);
		await lblRauMam.ScaleTo(1.0, 200);
	}

	private void OnCaiThaoTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Cải Thảo", 10000, DemCaiThao);

		var CaiThao = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Cải Thảo");

		DisplayAlert("Chọn món", $"Bạn đã chọn Cải Thảo - Tổng số lượng: {DemCaiThao}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemCaiThao = 1;
		lblCaiThao.Text = $"Cải Thảo: {DemCaiThao}";
	}
	private async void OnCaiThaoPoint(object sender, PointerEventArgs e)
	{
		await imgCaiThao.ScaleTo(1.1, 200);
		await lblCaiThao.ScaleTo(1.1, 200);
	}

	private async void OnCaiThaoPointer(object sender, PointerEventArgs e)
	{
		await imgCaiThao.ScaleTo(1.0, 200);
		await lblCaiThao.ScaleTo(1.0, 200);
	}

	private void OnMuopHuongTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Mướp hương", 10000, DemMuopHuong);

		var MuopHuong = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Mướp hương");

		DisplayAlert("Chọn món", $"Bạn đã chọn Mướp hương - Tổng số lượng: {DemMuopHuong}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemMuopHuong = 1;
		lblMuopHuong.Text = $"Mướp hương: {DemMuopHuong}";
	}
	private async void OnMuopHuongPoint(object sender, PointerEventArgs e)
	{
		await imgMuopHuong.ScaleTo(1.1, 200);
		await lblMuopHuong.ScaleTo(1.1, 200);
	}

	private async void OnMuopHuongPointer(object sender, PointerEventArgs e)
	{
		await imgMuopHuong.ScaleTo(1.0, 200);
		await lblMuopHuong.ScaleTo(1.0, 200);
	}

	private void OnKhoaiMonChienTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Khoai môn chiên", 10000, DemKhoaiMonChien);

		var KhoaiMonChien = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Khoai môn chiên");

		DisplayAlert("Chọn món", $"Bạn đã chọn Khoai môn chiên - Tổng số lượng: {DemKhoaiMonChien}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemKhoaiMonChien = 1;
		lblKhoaiMonChien.Text = $"Khoai môn chiên: {DemKhoaiMonChien}";
	}
	private async void OnKhoaiMonChienPoint(object sender, PointerEventArgs e)
	{
		await imgKhoaiMonChien.ScaleTo(1.1, 200);
		await lblKhoaiMonChien.ScaleTo(1.1, 200);
	}

	private async void OnKhoaiMonChienPointer(object sender, PointerEventArgs e)
	{
		await imgKhoaiMonChien.ScaleTo(1.0, 200);
		await lblKhoaiMonChien.ScaleTo(1.0, 200);
	}


	private void OnBacHaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Bạc hà", 10000, DemBacHa);

		var BacHa = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Bạc hà");

		DisplayAlert("Chọn món", $"Bạn đã chọn Bạc hà - Tổng số lượng: {DemBacHa}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemBacHa = 1;
		lblBacHa.Text = $"Bạc hà: {DemBacHa}";
	}
	private async void OnBacHaPoint(object sender, PointerEventArgs e)
	{
		await imgBacHa.ScaleTo(1.1, 200);
		await lblBacHa.ScaleTo(1.1, 200);
	}

	private async void OnBacHaPointer(object sender, PointerEventArgs e)
	{
		await imgBacHa.ScaleTo(1.0, 200);
		await lblBacHa.ScaleTo(1.0, 200);
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