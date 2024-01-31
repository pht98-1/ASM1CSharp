// See https://aka.ms/new-console-template for more information
Console.WriteLine("******************* Chuong trinh tinh hoa don tien nuoc ****************");

// khai bao ham xu ly chuong trinh
void TinhTienHoaDonNuoc()
{
    Console.WriteLine("Nhap Ho Ten Khach hang : ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Vui long chon loai khac hang");
    Console.WriteLine("Nhap so 1 neu ban la loai khach hang ho gia dinh, roi bam enter");
    Console.WriteLine("Nhap so 2 neu ban la loai khach hang co quan hanh chinh cong, roi bam enter");
    Console.WriteLine("Nhap so 3 neu ban loai khach hang Don vi san xuat, roi bam enter");
    Console.WriteLine("Nhap so 4 neu ban loai khach hang Dich vu kinh doanh, roi bam enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // khach hang ho gia dinh
        // yeu cau so luong thanh vien trong gia dinh
        Console.WriteLine("Nhap so luong thanh vien trong gia dinh");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Nhap chi so dong nuoc cua thang truoc");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chi so dong nuoc cua thang nay");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("Tien nuoc cua gia dinh ban la : {0}", money);
            }
            else
            {
                Console.WriteLine("So nuoc thang truoc khong lon hon cua thang hien tai");
            }
        }
        else
        {
            Console.WriteLine("Ban khong phai khach hang ho gia dinh");
        }
    }
    else if (typeCustomer == 2)
    {
        // khach hang co quan hanh chinh cong
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang truoc");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Vui long nhap chi so dong ho nuoc thang hien tai");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("Tien nuoc cua co quan hanh chinh cong la {0}", m);
        }
        else
        {
            Console.WriteLine("Chi so dong ho nuoc thang truoc khong lon hon cua thang hien tai");
        }
    }
    else if (typeCustomer == 3)
    {
        // khach hang don vi san xuat
    }
    else if (typeCustomer == 4)
    {
        // khach hang Kinh Doanh
    }
    else
    {
        Console.WriteLine("Vui long nhap dung the loai khach hang");
    }
}
// chay chuong trinh
TinhTienHoaDonNuoc();s
