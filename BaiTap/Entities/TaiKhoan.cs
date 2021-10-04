using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.Entities
{
    public class TaiKhoan
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public static List<TaiKhoan> GetList()
        {
            var ls = new List<TaiKhoan>();
            ls.Add(new TaiKhoan()
            {
                UserName = "ndungithue",
                Password = "Abc@123"
            });
            return ls;
        }

        public static TaiKhoan Get(string username, string password)
        {
            var dbTaiKhoan = GetList();
            var taikhoan = dbTaiKhoan.Where(t => t.UserName == username & t.Password==password ).FirstOrDefault();
            return taikhoan;

        }
    }
}
