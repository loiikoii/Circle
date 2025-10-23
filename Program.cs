namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 5)
            {
            Console.WriteLine("Vad vill du göra? \n" +
                "1. Räkna ut radie på cirkel\n" +
                "2. Räkna ut omkrets på cirkel\n" +
                "3. Räkna ut volym på klot\n" +
                "4. Räkna ut Area på triangel\n" +
                "5. Avsluta");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            COne();
                            Console.ReadLine();
                            break;

                        case 2:
                            CTwo();
                            Console.ReadLine();
                            break;
                        case 3:
                            SphOne();
                            Console.ReadLine();
                            break;
                        case 4:
                            Triangle();
                            Console.ReadLine();
                            break;
                        case 5:
                            break;
                    }
                }
            }
        }

        static void COne()
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            circle1.GetArea();
            circle1.PrintOne();

            circle2.GetArea();
            circle2.PrintOne();
        }
        static void CTwo()
        {
            Console.WriteLine("Skriv in cirkelns radie");
            if (int.TryParse(Console.ReadLine(), out int radius))
            {

                Circle circle3 = new Circle(radius);
                circle3.GetCircumference();
                circle3.PrintTwo();
            }
        }
        static void SphOne()
        {
            Console.WriteLine("Skriv in radien av klotet.");
            if (int.TryParse(Console.ReadLine(), out int radius))
            {
                Circle circle4 = new Circle(radius);
                circle4.GetVolume();
                circle4.PrintThree();
            }
        }
        static void Triangle()
        {
            Console.Write("hur hög är höjden? ");
            double tHeight = int.Parse(Console.ReadLine());
            Console.Write("hur stor är basen? ");
            double tBase = int.Parse(Console.ReadLine());
            Triangle t1 = new Triangle(tHeight, tBase);
            t1.GetArea();
            t1.TPrintOne();
        }



        //static void CRadius()
        //{
        //    Console.Write("Radie: ");
        //    if (double.TryParse(Console.ReadLine(), out double choice))
        //    {
        //        Circle circle1 = new Circle(choice);
        //        circle1.CRadius();
        //    }
        //}
    }
}
