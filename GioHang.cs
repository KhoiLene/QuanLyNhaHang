using System.ComponentModel;
using System.Collections.ObjectModel;
using System;
using System.Globalization;
using Microsoft.Maui.Controls;
namespace NhaHang.Services;
public class SoLuongNhoHonBangMotConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int soLuong)
            return soLuong <= 9;
        return false;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
public class GioHangTen
{
        public string Tenk { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int SDT { get; set; }
        public string SoBan { get; set; }
}

public class GioHangItem : INotifyPropertyChanged
{
    public int Dem { get; set; }
    
    public string Ten { get; set; }
    public int Gia { get; set; }
    public int ThanhTien => Gia * SoLuong;
    private int _soLuong;
    public int SoLuong
    {
        get => _soLuong;
        set
        {
            if (_soLuong != value)
            {
                _soLuong = value;
                OnPropertyChanged(nameof(SoLuong));
                OnPropertyChanged(nameof(ThanhTien));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}

    
public class GioHang
{


    private static GioHang _instance;
    public static GioHang Instance => _instance ??= new GioHang();
    public string MaHoaDon { get; private set; }
    public string NgayXuat { get; private set; }
    public static string TaoMaHoaDon()
    {
        string ngay1 = DateTime.Now.ToString("dd");
        int soNgauNhien = new Random().Next(1000, 9999);
        return $"HD-Hcmute-{ngay1}{soNgauNhien}"; // Ví dụ: HD202510021234
    }
    public static string NgayXuatHD()
    {
        string ngay = DateTime.Now.ToString("hh:mm:ss:dd/MM/yyy");
        return $"{ngay}"; // Ví dụ: HD202510021234
    }
    // Gán giá trị trả về của hàm cho biến MaHoaDon
    private GioHang()
    {
        MaHoaDon = TaoMaHoaDon();
        NgayXuat = NgayXuatHD();
    }

    public void ClearKhachHang()
{
    KhachHang = null;
}

    public ObservableCollection<GioHangItem> Items { get; } = new();
    public ObservableCollection<GioHangTen> Ten { get; } = new();
    public int Dem => Items.Sum(i => i.SoLuong);
    public GioHangTen KhachHang { get; private set; }
    public void AddTen(string tenk, DateTime? ngaySinh, int sdt, string soBan)
    {
        KhachHang = new GioHangTen
        {
            Tenk = tenk,
            NgaySinh = ngaySinh,
            SDT = sdt,
            SoBan = soBan.ToString()
        };
    }


    public void AddItem(string ten, int gia, int soLuong = 0)
    {
        var existing = Items.FirstOrDefault(i => i.Ten == ten);
        if (existing != null)
        {
            existing.SoLuong += soLuong;
        }
        else
        {
            Items.Add(new GioHangItem { Ten = ten, Gia = gia, SoLuong = soLuong });
        }
    }
    public void RemoveItem(GioHangItem item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
        }
    }
    public void Clear()
    {
        Items.Clear();
    }

    public int GetTotal()
    {
        return Items.Sum(i => i.Gia * i.SoLuong);
    }
}

