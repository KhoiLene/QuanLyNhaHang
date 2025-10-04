using System;
using System.IO;
using System.Globalization;

namespace NhaHang.Services
{
    public class HoaDonTongTien
    {
        public static decimal TinhTongTatCaHoaDon(string filePath)
        {
            decimal tong = 0;

            if (!File.Exists(filePath))
                return 0;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (line.StartsWith("Tổng tiền hóa đơn này:"))
                {
                    var parts = line.Split(':');
                    if (parts.Length > 1)
                    {
                        string soTienStr = parts[1]
                            .Replace("vnđ", "")
                            .Replace("đ", "")
                            .Replace(",", "")
                            .Trim();

                        if (decimal.TryParse(soTienStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal soTien))
                            tong += soTien;
                    }
                }
            }

            return tong;
        }
    }
}