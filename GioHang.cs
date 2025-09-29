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

    public ObservableCollection<GioHangItem> Items { get; } = new();
    public int Dem => Items.Sum(i => i.SoLuong);

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

