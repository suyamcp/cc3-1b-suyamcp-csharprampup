namespace csharprampup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight in pounds: ");
            double weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weight in lbs = " + weight);
            double kgs = weight * 0.453;
            Console.WriteLine("Weight in kgs = " + kgs);
            Console.WriteLine("=============================");


            Console.WriteLine("Enter distance in miles: ");
            double miles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Distance in miles = " + miles);
            double kms = miles * 1.6;
            Console.WriteLine("Distance in kilometers = " + kms);
            Console.WriteLine("=============================");

            Console.WriteLine("Enter temperature in Fahrenheit:");
            double F = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Temparature in Fahrenheit = " + F);
            double C = (F - 32) * 0.5556;
            Console.WriteLine("Temperature in Celsius = " + C);
            Console.WriteLine("=============================");

            Console.WriteLine("Enter age for student #1: ");
            int studentOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #2: ");
            int studentTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #3: ");
            int studentThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #4: ");
            int studentFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #5: ");
            int studentFive = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #6: ");
            int studentSix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #7: ");
            int studentSeven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #8: ");
            int studentEight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #9: ");
            int studentNine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age for student #10: ");
            int studentTen = Convert.ToInt32(Console.ReadLine());

            double average = (studentOne + studentTwo + studentThree + studentFour + studentFive + studentSix + studentSeven + studentEight + studentNine + studentTen) / 10;
            Console.WriteLine("The average age of the students is: " + average);

            string hero1Name = "Elysia";
            string hero2Name = "Thorne";
            string hero3Name = "Darius";
            string hero4Name = "Lorelei";
            string hero5Name = "Faelan";


            string hero1Weapon = "Blade of Radiance";
            string hero2Weapon = "Shadowmeld Bow";
            string hero3Weapon = "Thunderstrike Hammer";
            string hero4Weapon = "Scepter of Enchantment";
            string hero5Weapon = "Whispering Cloak";

            Console.WriteLine("=================================");
            Console.WriteLine("");

            string intro = $"Embark on an epic journey with {hero1Name}, {hero2Name}, {hero3Name}, {hero4Name}, and {hero5Name}.";
            string questStart = "Their quest begins in the mystical land of Eldoria.";

            string challenge1 = $"{hero1Name} wields the mighty {hero1Weapon}, its radiant blade illuminating the treacherous path.";
            string challenge2 = $"{hero2Name}, armed with the {hero2Weapon}, blends into the shadows, scouting ahead with unparalleled precision.";
            string challenge3 = $"{hero3Name} swings the {hero3Weapon}, a thunderous force clearing obstacles in their way.";
            string challenge4 = $"{hero4Name} enchants the surroundings using the magical {hero4Weapon}, unraveling secrets hidden in ancient runes.";
            string challenge5 = $"{hero5Name} dons the {hero5Weapon}, a cloak that whispers through the air, granting unparalleled stealth.";


            string victory = "With their combined strength and unique abilities, they triumph over challenges, bringing peace to Eldoria.";

            string fantasyStory = $"{intro}\n\n{questStart}\n\n{challenge1}\n{challenge2}\n{challenge3}\n{challenge4}\n{challenge5}\n\n{victory}";


            Console.WriteLine(fantasyStory);
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("");

            Console.Write("Enter a pattern number >> ");
            int pattern1 = Convert.ToInt32(Console.ReadLine());

            if (pattern1 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= pattern1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=================================");

            Console.Write("Enter a pattern number >> ");
            int pattern2 = Convert.ToInt32(Console.ReadLine());
            int add = 0;

            if (pattern2 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int i = 1; i <= pattern2; i++)
                {
                    add += i;
                }
                Console.WriteLine("Output:" + add);
            }
            Console.WriteLine("=================================");

            Console.Write("Enter a pattern number >> ");
            int pattern3 = Convert.ToInt32(Console.ReadLine());
            if (pattern3 <= 0)
            {
                Console.WriteLine("Invalid Input");
            }
            else if (pattern3 > 0) { }
            {
                for (int i = 1; i <= pattern3;)
                {
                    for (int j = 1; j <= pattern3; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                    pattern3--;
                }
            }
        }
    }
}
