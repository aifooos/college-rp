using System;

namespace CollegeRoleplayGameNamespace
{
    class CollegeRoleplayGame
    {
        static int health = 100;
        static string grades = "Average";
        static string knowledge = "Basic";
        static int entertainment = 5;
        static int money = 1000;

        static int stumbledDownStairsCount = 0;
        static int headacheCount = 0;
        static int walletLostCount = 0;
        static int dizzinessCount = 0;
        static int elevatorStuckCount = 0;
        static int trippedWhileShoppingCount = 0;
        static int foodPoisoningCount = 0;
        static int chokeCount = 0;
        static int rejectedWhileDatingCount = 0;
        static int tooMuchPlayingCount = 0;
        static int cutsWhileWashingCount = 0;
        static int slipsAndFallsWhileMoppingCount = 0;
        static int burnWhileCookingCount = 0;
        static int wrongOrderCount = 0;
        static int fightWithCustomerCount = 0;

        static void Main()
        {
            Console.WriteLine("Welcome to College Roleplay Game! Your journey begins now!\n");

            DisplayStatus();

            Console.WriteLine("\nYou stand in front of the school campus.");

            while (health > 0 && grades != "Failed" && money > 0)
            {
                Console.WriteLine("1. Enter campus");
                Console.WriteLine("2. Skip classes (automatic grade deduction)");
                Console.WriteLine("3. Check status");
                Console.Write("What do you want do? ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterCampus();
                        break;
                    case "2":
                        SkipClasses();
                        break;
                    case "3":
                        DisplayStatus();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Game Over!");
        }

        static void EnterCampus()
        {
            Console.WriteLine("\nYou are inside the campus.");
            Console.WriteLine("1. Classroom");
            Console.WriteLine("2. Canteen");
            Console.WriteLine("3. Gym");
            Console.WriteLine("4. Faculty");
            Console.WriteLine("5. Clinic");
            Console.WriteLine("6. Exit Campus");
            Console.Write("Choose where to go next: ");

            string venueChoice = Console.ReadLine();

            switch (venueChoice)
            {
                case "1":
                    Classroom();
                    break;
                case "2":
                    Canteen();
                    break;
                case "3":
                    Gym();
                    break;
                case "4":
                    Faculty();
                    break;
                case "5":
                    Clinic();
                    break;
                case "6":
                    SkipClasses();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void Classroom()
        {
            Console.WriteLine("\nYou are inside the classroom.");
            Console.WriteLine("1. Listen to class");
            Console.WriteLine("2. Talk to seatmate");
            Console.WriteLine("3. Approach the prof. to ask your grades.");
            Console.WriteLine("4. Answer activity");
            Console.WriteLine("5. Don't do the activity");
            Console.WriteLine("6. Leave the classroom");
            Console.Write("Choose an action: ");

            string actionChoice = Console.ReadLine();
            switch (actionChoice)
            {
                case "1":
                    Console.WriteLine("Knowledge added!");
                    knowledge = "Intermediate";
                    Classroom();
                    break;
                case "2":
                    Console.WriteLine("Entertainment status added!");
                    entertainment += 2;
                    Classroom();
                    break;
                case "3":
                    Console.WriteLine($"Your current grade is {grades}");
                    Classroom();
                    break;
                case "4":
                    Console.WriteLine("Grade added!");
                    grades = "Above Average";
                    Classroom();
                    break;
                case "5":
                    Console.WriteLine("No activity chosen. Grade deducted!");
                    grades = "Below Average";
                    Classroom();
                    break;
                case "6":
                    Console.WriteLine("You left the classroom");
                    EnterCampus();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void Canteen()
        {
            Console.WriteLine("\nYou are inside the canteen");
            Console.WriteLine("1. Buy healthy snacks.");
            Console.WriteLine("2. Buy junk foods");
            Console.WriteLine("3. Sit with your friends");
            Console.WriteLine("4. Sleep");
            Console.WriteLine("5. Study");
            Console.WriteLine("6. Leave Canteen");
            Console.Write("Choose an action: ");

            string CanteenChoice = Console.ReadLine();

            switch (CanteenChoice)
            {
                case "1":
                    Console.WriteLine("Health added!");
                    Console.WriteLine("Money deducted!");
                    Canteen();
                    break;
                case "2":
                    Console.WriteLine("Health deducted!");
                    Console.WriteLine("Money deducted!");
                    Canteen();
                    break;
                case "3":
                    Console.WriteLine("Entertainment status added!");
                    entertainment += 2;
                    Canteen();
                    break;
                case "4":
                    Console.WriteLine("Health added!");
                    Canteen();
                    break;
                case "5":
                    Console.WriteLine("Knowledge added!");
                    Canteen();
                    break;
                case "6":
                    Console.WriteLine("You left the canteen.");
                    EnterCampus();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void Gym()
        {
            Console.WriteLine("You are inside the Gymnasium");
            Console.WriteLine("1. Play sports");
            Console.WriteLine("2. Watch students playing ");
            Console.WriteLine("3. Make a tiktok video");
            Console.WriteLine("4. Leave the gymnasium");
            Console.Write("Choose an action: ");

            string GymChoice = Console.ReadLine();
            switch (GymChoice)
            {
                case "1":
                    Console.WriteLine(" Health added!");
                    Gym();
                    break;
                case "2":
                    Console.WriteLine(" Health added!");
                    Gym();
                    break;
                case "3":
                    Console.WriteLine(" Health added!");
                    Gym();
                    break;
                case "4":
                    EnterCampus();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void Faculty()
        {
            Console.WriteLine("You are inside the Faculty");
            Console.WriteLine("1. Talk to the prof");
            Console.WriteLine("2. Steal files");
            Console.WriteLine("3. Leave the faculty");

            string facultychoice = Console.ReadLine();

            switch (facultychoice)
            {
                case "1":
                    Console.WriteLine("Knowledge added");
                    Faculty();
                    break;
                case "2":
                    Console.WriteLine("EXPULSION!!!!");
                    Environment.Exit(0);
                    break;
                case "3":
                    Console.WriteLine("You left the faculty");
                    EnterCampus();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void Clinic()
        {
            Console.WriteLine("You are inside the Clinic");
            Console.WriteLine("1. Talk to the doctor");
            Console.WriteLine("2. Get medical checkup");
            Console.WriteLine("3. Leave the clinic");

            string clinicChoice = Console.ReadLine();

            switch (clinicChoice)
            {
                case "1":
                    Console.WriteLine("Your health improved!");
                    health += 10;
                    Clinic();
                    break;
                case "2":
                    Console.WriteLine("Health checkup completed.");
                    Clinic();
                    break;
                case "3":
                    Console.WriteLine("You left the clinic");
                    EnterCampus();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void SkipClasses()
        {
            Console.WriteLine("\nYou are outside the Campus.\nChoose an action:");
            Console.WriteLine("1. Go to mall");
            Console.WriteLine("2. Hangout with friends");
            Console.WriteLine("3. Date");
            Console.WriteLine("4. Go to work");
            Console.WriteLine("5. Go back to school");
            Console.WriteLine("6. Check Status");
            Console.WriteLine("7. Exit Game");
            string actionChoice = Console.ReadLine();

            switch (actionChoice)
            {
                case "1":
                    Console.WriteLine("Entertainment increased, money deducted!");
                    entertainment += 3;
                    money -= 50;
                    break;
                case "2":
                    Console.WriteLine("Entertainment increased, money deducted!");
                    entertainment += 2;
                    money -= 30;
                    break;
                case "3":
                    Console.WriteLine("Entertainment increased, money deducted!");
                    entertainment += 4;
                    money -= 40;
                    break;
                case "4":
                    Console.WriteLine("Money increased!");
                    money += 100;
                    break;
                case "5":
                    EnterCampus();
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            CheckAccidents();
        }

        static void CheckAccidents()
        {
            Random random = new Random();

            if (random.Next(1, 101) <= 10)
            {
                Console.WriteLine("You encountered an accident!");

                int accidentType = random.Next(1, 13);

                switch (accidentType)
                {
                    case 1:
                        Console.WriteLine("You stumbled down the stairs!");
                        health -= 10;
                        stumbledDownStairsCount++;
                        break;
                    case 2:
                        Console.WriteLine("You got a headache!");
                        health -= 5;
                        headacheCount++;
                        break;
                    case 3:
                        Console.WriteLine("Your wallet was lost!");
                        money -= 50;
                        walletLostCount++;
                        break;
                    case 4:
                        Console.WriteLine("You got dizzy!");
                        health -= 15;
                        dizzinessCount++;
                        break;
                    case 5:
                        Console.WriteLine("The elevator got stuck!");
                        health -= 20;
                        elevatorStuckCount++;
                        break;
                    case 6:
                        Console.WriteLine("You tripped while shopping!");
                        health -= 10;
                        trippedWhileShoppingCount++;
                        break;
                    case 7:
                        Console.WriteLine("You got food poisoning!");
                        health -= 25;
                        foodPoisoningCount++;
                        break;
                    case 8:
                        Console.WriteLine("You choked on something!");
                        health -= 30;
                        chokeCount++;
                        break;
                    case 9:
                        Console.WriteLine("You were rejected while dating!");
                        entertainment -= 5;
                        rejectedWhileDatingCount++;
                        break;
                    case 10:
                        Console.WriteLine("You played too much!");
                        entertainment -= 10;
                        tooMuchPlayingCount++;
                        break;
                    case 11:
                        Console.WriteLine("You got cuts while washing!");
                        health -= 15;
                        cutsWhileWashingCount++;
                        break;
                    case 12:
                        Console.WriteLine("You slipped and fell while mopping!");
                        health -= 20;
                        slipsAndFallsWhileMoppingCount++;
                        break;
                    default:
                        Console.WriteLine("You burned yourself while cooking!");
                        health -= 25;
                        burnWhileCookingCount++;
                        break;
                }
            }

            // Check if the game should end
            if (health <= 0 || grades == "Failed" || money <= 0)
            {
                Console.WriteLine("Game Over!");
                Environment.Exit(0);
            }
        }

        static void ViewAbout()
        {
            Console.WriteLine("\nCollege Roleplay Game is a text-based simulation game where you navigate through the challenges and decisions of a college student.");
            Console.WriteLine("Your goal is to maintain a balance between health, grades, knowledge, entertainment, and money.");
            Console.WriteLine("Make choices wisely to ensure a successful college experience!");

            Console.WriteLine("\nPress '0' to exit the About section and continue with the game.");
            while (Console.ReadKey().KeyChar != '0')
            {

            }
        }

        static void DisplayStatus()
        {
            Console.WriteLine($"Your Current Status:\nHealth: {health}%\nGrades: {grades}\nKnowledge: {knowledge}\nEntertainment: {entertainment}\nMoney: {money}");
        }
    }
}