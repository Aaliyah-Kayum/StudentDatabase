string[] students = new string[8];

do
{ 
Console.WriteLine("Welcome to the Student Database! Which student would you like to learn about? Please enter a number 1-7");
int select = int.Parse(Console.ReadLine());



    {
        string[] names = { "Justin", "Lucas", "Aaliyah", "Jon", "Tarik", "Alex", "Josh" };
        string[] hometown = { "Wyoming", "Louisville", "Manchester", "Toledo", "Queens NY", "Ferndale", "Cali" };
        string[] food = { "Baja Blast", "Sushi", "Chicken Wings", "Bacon", "Tacos", "Spaghetti", "Nalesniki" };


        if (select <= 0 || select > 7)
        {
            Console.WriteLine();
        }

        Console.WriteLine("You chose: " + select);
        if (select == 1)
        {
            Console.WriteLine("This is Justin");
        }
        else if (select == 2)
        {
            Console.WriteLine("This is Lucas");
        }
        else if (select == 3)
        {
            Console.WriteLine("This is Aaliyah");
        }
        else if (select == 4)
        {
            Console.WriteLine("This is Jon");
        }
        else if (select == 5)
        {
            Console.WriteLine("This is Tarik");
        }
        else if (select == 6)
        {
            Console.WriteLine("This is Alex");
        }
        else if (select == 7)
        {
            Console.WriteLine("This is Josh");
        }

        Console.WriteLine("Please choose between 'hometown' or 'favourite food' to learn more about the student");
        string choice = Console.ReadLine();

        if (choice == "favourite food" || choice == "food" || choice == "fav food") ;

        else if (select == 1)
        {
            Console.WriteLine("Justin is from Wyoming");
        }
        else if (select == 2)
        {
            Console.WriteLine("Lucas is from Louisville");
        }
        else if (select == 3)
        {
            Console.WriteLine("Aaliyah is from Manchester");
        }
        else if (select == 4)
        {
            Console.WriteLine("Jon is from Toledo");
        }
        else if (select == 5)
        {
            Console.WriteLine("Tarik is from Queens, NY");
        }
        else if (select == 6)
        {
            Console.WriteLine("Alex is from Ferndale");
        }
        else if (select == 7)
        {
            Console.WriteLine("Josh is from Cali");
        }

        if (choice == "hometown" || choice == "home" || choice == "town") ;
        else if (select == 1)
        {
            Console.WriteLine("Justin's favourite food is Baja Blast");
        }
        else if (select == 2)
        {
            Console.WriteLine("Lucas' favourite food is Sushi");
        }
        else if (select == 3)
        {
            Console.WriteLine("Aaliyah's favourite food is Chicken Wings");
        }
        else if (select == 4)
        {
            Console.WriteLine("Jon's favourite food is Bacon");
        }
        else if (select == 5)
        {
            Console.WriteLine("Tarik's favourite food is Tacos");
        }
        else if (select == 6)
        {
            Console.WriteLine("Alex's favourite food is Spaghetti");
        }
        else if (select == 7)
        {
            Console.WriteLine("Josh's favourite food is Nalesniki");
        }

        Console.WriteLine("Would you like to continue (y/n)?");
        string answer = Console.ReadLine();

        if (answer == "y")
        {
            continue;
        }
        if (answer == "n")
        {
            break;
        }
    }
} while (true);