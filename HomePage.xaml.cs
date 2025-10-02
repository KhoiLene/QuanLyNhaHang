namespace NhaHang;

public partial class HomePage : ContentPage
{

    public HomePage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new KhachHang());
    }
}
