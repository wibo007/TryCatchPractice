namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("height ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("width ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("length ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("no of windows ");
            double windowNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("paint capacity");
            double paintCapacity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("paint cost");
            double price = Convert.ToDouble(Console.ReadLine());

            try
            {
                
                Room r = new Room();
                double ans = r.SurfaceAreaCalculator(w, h, l, windowNo);
                Console.WriteLine(ans);
                Paint p = new Paint();
                double noCans = p.paintCanNoCalculator(ans, paintCapacity);
                Console.WriteLine(noCans);
                double Cprice = p.TotalPrice(price, noCans);
                Console.WriteLine(Cprice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        class Paint
        {
            public double paintCapacity;
            public double pricePerCan;
            public double noOfCans;
            public double price;
            public double totalVolumeNeeded;

            public double paintCanNoCalculator(double ans, double paintCapacity)
            {
                totalVolumeNeeded = (((ans * 100) * 2) / 1000);
                if (totalVolumeNeeded < paintCapacity)
                {
                    noOfCans = 1;
                }
                else
                {
                    noOfCans = Convert.ToInt32(Math.Ceiling(totalVolumeNeeded / paintCapacity));
                }
                return noOfCans;
            }
            public double TotalPrice(double pricePerCan, double noOfCans)
            {
                price = pricePerCan * noOfCans;
                return price;

            }

        }

        class Walls
        {
            public double length;
            public double width;
            public double area;

            public double Area(double length, double width)
            {
                area = length = width;
                return area;
            }
        }

        class Room : Walls
        {
            public double height;
            public double surfaceArea;
            public double windowNo;
            public double SurfaceAreaCalculator(double width, double height, double length, double windowNo)
            {
                surfaceArea = ((length * height) * 2) + ((width * height) * 2) + ((width * length) * 2);
                surfaceArea = surfaceArea - (windowNo * (0.635 * 0.89)) - (0.762 * 1.981);
                return surfaceArea;
            }
        }



    }
}
