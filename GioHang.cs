namespace NhaHang.Services;

public class GioHangItem
{
    public string Ten { get; set; }
    public int Gia { get; set; }
    public int SoLuong { get; set; } 
    public int ThanhTien => Gia * SoLuong;
}

public class GioHang
{
    private static GioHang _instance;
    public static GioHang Instance => _instance ??= new GioHang();

    public List<GioHangItem> Items { get; } = new();
    public int Dem => Items.Sum(i => i.SoLuong);

    public void AddItem(string ten, int gia)
    {
        var existing = Items.FirstOrDefault(i => i.Ten == ten);
        if (existing != null)
        {
            existing.SoLuong++;
        }
        else
        {
            Items.Add(new GioHangItem { Ten = ten, Gia = gia, SoLuong = 1 });
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
