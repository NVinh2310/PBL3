using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    public class Process
    {
        public static bool IsEmpty(string text)
        {
            if (text == "")
                return true;
            return false;
        }
    }
}
