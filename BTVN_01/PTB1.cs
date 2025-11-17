using System;

namespace bt_01 {
    class PTB1 {
        protected double a, b;

        public PTB1(double a, double b) {
            this.a = a;
            this.b = b;
        }

        public virtual void Giai() {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"\nGiải phương trình bậc 1: {a}x + {b} = 0");

            if (a == 0) {
                if (b == 0)
                    Console.WriteLine("Phương trình vô số nghiệm");
                else
                    Console.WriteLine("Phương trình vô nghiệm");
            }
            else {
                double x = -b / a;
                Console.WriteLine($"Nghiệm x = {x:F2}");
            }
        }
    }
}
