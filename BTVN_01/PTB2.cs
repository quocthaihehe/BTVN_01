using bt_01;
using System;

namespace bt_01 {
    class PTB2 : PTB1 {
        private double c;

        public PTB2(double a, double b, double c) : base(a, b) {
            this.c = c;
        }

        public override void Giai() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"\nGiải phương trình bậc 2: {a}x^2 + {b}x + {c} = 0");

            if (a == 0)
            {
                Console.WriteLine("\nĐây là phương trình bậc 1!");
                PTB1 pt1 = new PTB1(b, c);
                pt1.Giai();
                return;
            }

            // --- Tính delta
            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Delta = {delta:F2}");

            if (delta < 0) {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta == 0) {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x = {x:F2}");
            }
            else {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine($"x1 = {x1:F2}");
                Console.WriteLine($"x2 = {x2:F2}");
            }
        }
    }
}

