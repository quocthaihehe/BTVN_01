using bt_01;
using System;

namespace bt_01 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2 ===");

            try {
                Console.WriteLine("\n--- Vui lòng nhập hệ số ---");

                Console.Write("Nhập hệ số a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập hệ số b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập hệ số c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n===== KẾT QUẢ GIẢI PHƯƠNG TRÌNH ======");
                PTB2 pt = new PTB2(a, b, c);
                pt.Giai();
            }

            catch (FormatException) {
                Console.WriteLine("\nDữ liệu nhập vào không hợp lệ. Vui lòng nhập số.");
            }
            catch (Exception e) {
                Console.WriteLine($"\nXảy ra lỗi: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}