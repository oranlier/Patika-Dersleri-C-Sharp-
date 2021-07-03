using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     // 1 byte yer kaplar, 0 ile 255 arasında tamsayı değer alabilir
            sbyte c = 5;    // 1 byte yer kaplar, -128 ile 127 arasında tamsayı değer alabilir
            short s = 5;    // 2 byte yer kaplar, -32768 ile +32768 arasında tamsayı değer alabilir
            ushort us = 5;  // 2 byte yer kaplar, 0 ile +65265 arasında tamsayı değer alabilir

            Int16 i16 = 2;  // 2 byte yer kaplar
            int i = 2;      // 4 byte yer kaplar
            Int32 i32 = 2;  // 4 byte yer kaplar
            Int64 i64 = 2;  // 8 byte yer kaplar

            uint ui = 2;    // 4 byte yer kaplar
            long l = 2;     // 8 byte yer kaplar
            ulong ul = 2;   // 8 byte yer kaplar, negatif değer alamaz

            //REEL SAYILAR
            float f = 2;    // 4 byte yer kaplar
            double d = 5;   // 8 byte yer kaplar
            decimal de = 2; // 16 byte yer kaplar

            char ch = '2';  // 2 byte yer kaplar
            string str = "2";// sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            // Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString(); // cıktısı 2020

            int int30 = int20 + Convert.ToInt32(str20); // cıktısı 40
            int int31 = int20 + int.Parse(str20); // cıktısı 40

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");

            //saat
            string hour = DateTime.Now.ToString("HH:mm");

        }
    }
}
