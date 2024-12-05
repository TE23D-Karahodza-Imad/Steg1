//Första

// if (6 >= 3)
// {
//     Console.WriteLine("Hello world!");
//     Console.ReadLine();
// }



//Andra

// string userName = "";
// Console.WriteLine("Hello user, type in your username to log in.");
// Console.Write(">");
// userName = Console.ReadLine();
// if (userName == "kalleanka")
// {
//     Console.WriteLine("Welcome!");
// }
// Console.ReadLine();



// Tredje

// string userName = "";
// string passWord = "";

// Console.WriteLine("Hello user, type in your username and password to log in.");
// Console.Write(">");
// userName = Console.ReadLine();
// Console.Write(">");
// passWord = Console.ReadLine();

// if (userName == "kalleanka" && passWord == "12345")
// {
//     Console.WriteLine("Welcome!");
//     Console.ReadLine();
// }


// else
// {
//     Console.WriteLine("Wrong username or password.");
//     Console.ReadLine();
// 



//Fjärde

// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Hello, world!");
// }

// Console.ReadLine();



//Femte

// string passWord = "";

// Console.WriteLine("Please write in your password");
// Console.Write(">");

// while (passWord != "12345")
// {
//     passWord = Console.ReadLine();
//     if (passWord != "12345")
//     {
//         Console.WriteLine("Wrong password, try again.");
//     }
// }

// Console.WriteLine("Welcome!");
// Console.ReadLine();



//Sexte och sjunde


// Koden körs fem gånger
// for (int i = 0; i < 5; i++)
// {
//     int tal = 0;
//     bool correctParse = false;
//     //Säger till att användaren skriver rätt
//     while (correctParse == false)
//     {
//         string talInput = Console.ReadLine();
//         correctParse = int.TryParse(talInput, out tal);
//         if (!correctParse)
//         {
//             Console.WriteLine("Skriv in rätt tal");
//         }
//     }

//     //Kollar att siffranär större eller mindre än fem
//     if (tal > 5)
//     {
//         Console.WriteLine("Större än 5");
//     }
//     else
//     {
//         Console.WriteLine("Mindre än 5");
//     }
// }

// Console.ReadLine();

//SISTA

// System.Console.WriteLine("Hello player.. u need to guess a number between 1 and 10.. and guess the right one");

// string rightChoice = "";


// while (rightChoice != "3")
// {
//     rightChoice = Console.ReadLine();
//     if(rightChoice != "3")
//     {
//         System.Console.WriteLine("You didnt guess right.. Try again.");
//     }
// }



// Console.WriteLine("Good job! you guessed right.");
// Console.ReadLine();


     Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 10;
        int guess;
        int number;
        int guesses;
x
        while(playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);

            while(guess != number)
            {
                System.Console.WriteLine("Guess a number between " + min + "-" + max + ":");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > number)
                {
                    System.Console.WriteLine(guess + " is too high");
                }
                else if (guess < number)
                {
                    System.Console.WriteLine(guess + " is too low" );
                }

                guesses++;

            
            }
            System.Console.WriteLine("Good job you won!");
            System.Console.WriteLine("Number :" + number);
            System.Console.WriteLine("Guesses:" + guesses);
        }



    
