namespace ConsoleApp_Chuong02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // 5. Viết chương trình tính diện tích và chu vi hình chữ nhật.
            dientichChuvi();

            // 6. Viết chương trình tính thể tích của một hình trụ.
            theTichHinhTru();

            /*
             7. Viết chương trình tính lương thực lãnh của một nhân viên theo công thưc dưới đây :
                Lương cơ bản : $ 12000
                BHYT : 12% lương cơ bản(Bảo hiểm y tế)
                BHXH : $150 (Bảo hiểm xã hội)
                CD : $120 (Tiền Công ñoàn)
                 Thuế :14% lương cơ bản
                Lương thực lãnh = Lương cơ bản - BHYT - BHXH - CD
             */
            Console.WriteLine();
            double luongCB = 12000;
            double luongTL;
            luongTL = luongThucLanh(luongCB);
            Console.WriteLine("Lương thực lãnh : {0:C}$" , luongTL);
        }

        /// <summary>
        /// hàm tính chu vi và diện tích hình chữ nhật
        /// </summary>
        static void dientichChuvi()
        {
            double chieudai;
            double chieurong;
            // Yêu cầu người dùng nhập chiều dài
            Console.Write("Nhập chiều dài: ");
            chieudai = Convert.ToDouble(Console.ReadLine());
            // Yêu cầu người dùng nhập chiều rộng
            Console.Write("Nhập chiều rộng: ");
            chieurong = Convert.ToDouble(Console.ReadLine());
            // Tính diện tích hình chữ nhật
            double dientich = chieudai * chieurong;
            // Tính chu vi hình chữ nhật
            double chuvi = 2 * (chieudai + chieurong);
            // In kết quả ra màn hình
            Console.WriteLine($"Diện tích hình chữ nhật: {dientich}");
            Console.WriteLine($"Chu vi hình chữ nhật: {chuvi}");
        }

        /// <summary>
        /// hàm tính thể tích hình trụ
        /// </summary>
        static void theTichHinhTru() {
            // Khai báo biến
            double banKinh, chieuCao;

            // Yêu cầu nhập bán kính đáy
            Console.Write("Nhập bán kính đáy của hình trụ: ");
            banKinh = Convert.ToDouble(Console.ReadLine());

            // Yêu cầu người dùng nhập chiều cao
            Console.Write("Nhập chiều cao của hình trụ: ");
            chieuCao = Convert.ToDouble(Console.ReadLine());

            // Tính thể tích
            double theTich = Math.PI * Math.Pow(banKinh, 2) * chieuCao;

            // Hiển thị kết quả
            Console.WriteLine($"Thể tích của hình trụ là: {theTich}");
        }
        /// <summary>
        /// hàm tính lương thực lãnh
        /// </summary>
        /// <param name="luongCoBan"> nhập vào lương cơ bản </param>
        /// <returns>
        /// trả về lương thực lãnh sau khi đã trừ hết tất cả chi phí 
        /// </returns>
        static double luongThucLanh(double luongCoBan)
        {
            Console.WriteLine(luongCoBan);
            double BHYT, thue; 
            BHYT = luongCoBan*0.12;
            Console.WriteLine(BHYT);
            const double BHXH = 150;
            const double CD = 120;
            thue = luongCoBan*0.14;
            Console.WriteLine(thue);
            return (luongCoBan - BHYT - BHXH - CD - thue);
        }
    }
}
