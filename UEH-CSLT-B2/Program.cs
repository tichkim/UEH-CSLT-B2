using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bai3();
        }
        static void bai1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool gioitinh;
            Console.Write("Nhập họ tên của bạn: ");
            string hoten = Console.ReadLine();
            Console.Write("Nhập giới tính của bạn: ");
            string gt = Console.ReadLine();
            gioitinh = (gt == "Nam") ? true : false;
            string xinchao;
            xinchao = (gioitinh == true) ? "Chào anh " : "Chào chị ";
            Console.WriteLine(xinchao + hoten);
            Console.ReadKey();
        }
        static void bai2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một giá trị số: ");
            int a = int.Parse(Console.ReadLine());
            char symbol = (char)a;               
            string kq;
            kq = (a >= 48 && a <= 57) ? "Là mã của kí tự số {0}" : (a >= 65 && a <= 90) ? "Là mã của kí tự in hoa {0}" : (a >= 97 && a <= 122) ? "Là mã của kí tự thường {0}" : "Là mã của các kí tự khác";
            Console.WriteLine(kq,  (char)symbol);
            Console.ReadKey();
        }
        static void bai3()
        { 
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một kí tự thường : ");
            char b = char.Parse(Console.ReadLine());
            int e;
            e = b >= 97 && b <= 122 ? b - 32 : 0;
            string h;
            h = e != 0 ? "Kí tự in hoa của kí tự trên là {0}" : "Không phải kí tự viết thường";
            Console.WriteLine(h, (char)e);
            Console.ReadKey();
        }
    }

        
        }
    

