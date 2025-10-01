namespace NhaHang;
using NhaHang.Services;
public partial class MenuThitPage : ContentPage
{
	int DemLauNam = 1;
	int DemLauNam1 = 1;
	int DemLauTomYum = 1;
	int DemLauXuyenTieu = 1;
	int DemLauCuaDong = 1;
	int DemLauTomYumSua = 1;

	public MenuThitPage()
	{
		InitializeComponent();
		lblLauNam.Text = "Lẩu Nấm: " + DemLauNam;
		lblLauNam1.Text = "Lẩu Nấm 1: " + DemLauNam1;
		lblLauTomYum.Text = "Lẩu TomYum: " + DemLauTomYum;
		lblLauXuyenTieu.Text = "Lẩu Xuyên Tiêu: " + DemLauXuyenTieu;
		lblLauCuaDong.Text = "Lẩu Cua Đồng: " + DemLauCuaDong;
		lblLauTomYumSua.Text = "Lẩu TomYum Sữa: " + DemLauTomYumSua;
	}
	private void OnDauCongDemTapped(object sender, EventArgs e)
	{
		DemLauNam++;
		lblLauNam.Text = "Lẩu Nấm: " + DemLauNam;

	}
	private void OnDauTruDemTapped(object sender, EventArgs e)
	{
		if (DemLauNam > 0)
		{
			DemLauNam--;
			lblLauNam.Text = "Lẩu Nấm: " + DemLauNam;
		}
	}
	private void OnDauCongDem1Tapped(object sender, EventArgs e)
	{
		DemLauNam1++;
		lblLauNam1.Text = "Lẩu Nấm 1: " + DemLauNam1;

	}
	private void OnDauTruDem1Tapped(object sender, EventArgs e)
	{
		if (DemLauNam1 > 0)
		{
			DemLauNam1--;
			lblLauNam1.Text = "Lẩu Nấm 1: " + DemLauNam1;
		}
	}
	private void OnDauCongDemYTapped(object sender, EventArgs e)
	{
		DemLauTomYum++;
		lblLauTomYum.Text = "Lẩu Tom Yum: " + DemLauTomYum;

	}
	private void OnDauTruDemYTapped(object sender, EventArgs e)
	{
		if (DemLauTomYum > 0)
		{
			DemLauTomYum--;
			lblLauTomYum.Text = "Lẩu Tom Yum: " + DemLauTomYum;
		}
	}
	private void OnDauCongDemxTapped(object sender, EventArgs e)
	{
		DemLauXuyenTieu++;
		lblLauXuyenTieu.Text = "Lẩu Xuyên Tiêu: " + DemLauXuyenTieu;

	}
	private void OnDauTruDemxTapped(object sender, EventArgs e)
	{
		if (DemLauXuyenTieu > 0)
		{
			DemLauXuyenTieu--;
			lblLauXuyenTieu.Text = "Lẩu Xuyên Tiêu: " + DemLauXuyenTieu;
		}
	}
	private void OnDauCongDemCTapped(object sender, EventArgs e)
	{
		DemLauCuaDong++;
		lblLauCuaDong.Text = "Lẩu Cua Đồng: " + DemLauCuaDong;

	}
	private void OnDauTruDemCTapped(object sender, EventArgs e)
	{
		if (DemLauCuaDong > 0)
		{
			DemLauCuaDong--;
			lblLauCuaDong.Text = "Lẩu Cua Đồng: " + DemLauCuaDong;
		}
	}
		private void OnDauCongDemYSTapped(object sender, EventArgs e)
	{
		DemLauTomYumSua++;
		lblLauTomYumSua.Text = "Lẩu Tom Yum Sữa: " + DemLauTomYumSua;

	}
	private void OnDauTruDemYSTapped(object sender, EventArgs e)
	{
		if (DemLauTomYumSua > 0)
		{
			DemLauTomYumSua--;
			lblLauTomYumSua.Text = "Lẩu Tom Yum Sữa: " + DemLauTomYumSua;
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

	private void OnLauNamTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lẩu Nấm", 200000, DemLauNam);

		var lauNam = GioHang.Instance.Items.First(i => i.Ten == "Lẩu Nấm");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lẩu Nấm - Tổng số lượng: {DemLauNam}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLauNam = 1;
		lblLauNam.Text = $"Lẩu Nấm: {DemLauNam}";
	}

	private async void OnLauNamPoint(object sender, PointerEventArgs e)
	{
		await imgLauNam.ScaleTo(1.1, 200);      
		await lblLauNam.ScaleTo(1.1, 200);      
	}

	private async void OnLauNamXPoint(object sender, PointerEventArgs e)
	{
		await imgLauNam1.ScaleTo(1.1, 200);      
		await lblLauNam1.ScaleTo(1.1, 200);      
	}
	private void OnLauNamXTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lẩu Nấm 1", 200000, DemLauNam1);

		var lauNam = GioHang.Instance.Items.First(i => i.Ten == "Lẩu Nấm 1");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lẩu Nấm 1 - Tổng số lượng: {DemLauNam1}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLauNam1 = 1;
		lblLauNam1.Text = $"Lẩu Nấm 1: {DemLauNam}";
	}


	private async void OnLauNamXPointer(object sender, PointerEventArgs e)
	{
		await imgLauNam1.ScaleTo(1.0, 200);
		await lblLauNam1.ScaleTo(1.0, 200);
	}
	private async void OnLauNamPointer(object sender, PointerEventArgs e)
	{
		await imgLauNam.ScaleTo(1.0, 200);
		await lblLauNam.ScaleTo(1.0, 200);
	}
	private void OnLauTomYumTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lẩu Tom Yum", 250000, DemLauTomYum);

		var lauTomYum = GioHang.Instance.Items.First(i => i.Ten == "Lẩu Tom Yum");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lẩu Tom Yum - Tổng số lượng: {DemLauTomYum}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLauTomYum = 1;
		lblLauTomYum.Text = $"Lẩu Tom Yum: {1}";
	}
	private async void OnLauTomYumPoint(object sender, PointerEventArgs e)
	{
		await imgLauTomYum.ScaleTo(1.1, 200);
		await lblLauTomYum.ScaleTo(1.1, 200);
	}

	private async void OnLauTomYumPointer(object sender, PointerEventArgs e)
	{
		await imgLauTomYum.ScaleTo(1.0, 200);
		await lblLauTomYum.ScaleTo(1.0, 200);
	}
	private void OnLauXuyenTieuTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lẩu Xuyên Tiêu", 250000, DemLauXuyenTieu);

		var lauXuyenTieu = GioHang.Instance.Items.First(i => i.Ten == "Lẩu Xuyên Tiêu");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lẩu Xuyên Tiêu - Tổng số lượng: {DemLauXuyenTieu}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLauXuyenTieu = 1;
		lblLauXuyenTieu.Text = $"Lẩu Xuyên Tiêu: {1}";
	}

	private async void OnLauXuyenTieuPoint(object sender, PointerEventArgs e)
	{
		await imgLauXuyenTieu.ScaleTo(1.1, 200);
		await lblLauXuyenTieu.ScaleTo(1.1, 200);
	}

	private async void OnLauXuyenTieuPointer(object sender, PointerEventArgs e)
	{
		await imgLauXuyenTieu.ScaleTo(1.0, 200);
		await lblLauXuyenTieu.ScaleTo(1.0, 200);
	}
	private void OnLauCuaDongTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lẩu Cua Đồng", 250000, DemLauCuaDong);

		var lauCuaDong = GioHang.Instance.Items.First(i => i.Ten == "Lẩu Cua Đồng");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lẩu Cua Đồng - Tổng số lượng: {DemLauCuaDong}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLauCuaDong = 1;
		lblLauCuaDong.Text = $"Lẩu Cua Đồng: {1}";
	}
	private async void OnLauCuaDongPoint(object sender, PointerEventArgs e)
	{
		await imgLauCuaDong.ScaleTo(1.1, 200);
		await lblLauCuaDong.ScaleTo(1.1, 200);
	}

	private async void OnLauCuaDongPointer(object sender, PointerEventArgs e)
	{
		await imgLauCuaDong.ScaleTo(1.0, 200);
		await lblLauCuaDong.ScaleTo(1.0, 200);
	}
		private void OnLauTomYumSuaTapped(object sender, TappedEventArgs e)
	{
		GioHang.Instance.AddItem("Lẩu Tom Yum Sữa", 250000, DemLauTomYumSua);

		var lauTomYumSua = GioHang.Instance.Items.FirstOrDefault(i => i.Ten == "Lẩu Tom YumSua");

		DisplayAlert("Chọn món", $"Bạn đã chọn Lẩu Tom Yum Sữa - Tổng số lượng: {DemLauTomYumSua}", "OK");

		lblCartCount.Text = GioHang.Instance.Dem.ToString();
		DemLauTomYumSua = 1;
		lblLauTomYumSua.Text = $"Lẩu Tom Yum Sữa: {1}";
	}
	private async void OnLauTomYumSuaPoint(object sender, PointerEventArgs e)
	{
		await imgLauTomYumSua.ScaleTo(1.1, 200);
		await lblLauTomYumSua.ScaleTo(1.1, 200);
	}

private async void OnLauTomYumSuaPointer(object sender, PointerEventArgs e)
	{
		await imgLauTomYumSua.ScaleTo(1.0, 200);
		await lblLauTomYumSua.ScaleTo(1.0, 200);
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