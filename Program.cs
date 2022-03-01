using System;

namespace VendingMachine // Name of my project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Varuatomaten startar..."); //  I tried to picture an actuall vendingmachine and it´s small display. So i made a small welcoming messege.
            Console.ReadLine();

            string[] menuOptions = new string[] { "Mackor", "Läsk", "Godis", "Energidryck", "Avsluta",}; // Displays the options of the vending machine
            int menuSelected = 0;
            while (true)
    
            {
                Console.Clear(); // Clears the welcome messege from the console. 

            Console.CursorVisible = false;


        if (menuSelected == 0) // Setup for my menusystem with arrows to simplify the experiance. 
        {

        Console.WriteLine(menuOptions[0] + "<---");

        Console.WriteLine(menuOptions[1]);

        Console.WriteLine(menuOptions[2]);

        Console.WriteLine(menuOptions[3]);

        Console.WriteLine(menuOptions[4]);

       

    }

    else if (menuSelected == 1)
    {

        Console.WriteLine(menuOptions[0]);

        Console.WriteLine(menuOptions[1] + "<---");

        Console.WriteLine(menuOptions[2]);

        Console.WriteLine(menuOptions[3]);

        Console.WriteLine(menuOptions[4]);

      

    }

    else if (menuSelected == 2)
    {

        Console.WriteLine(menuOptions[0]);

        Console.WriteLine(menuOptions[1]);

        Console.WriteLine(menuOptions[2] + "<---");

        Console.WriteLine(menuOptions[3]);

        Console.WriteLine(menuOptions[4]);

       

    }
    else if (menuSelected == 3)
    {

        Console.WriteLine(menuOptions[0]);

        Console.WriteLine(menuOptions[1]);

        Console.WriteLine(menuOptions[2]);

        Console.WriteLine(menuOptions[3] + "<---");

        Console.WriteLine(menuOptions[4]);

       

    }   
    else if (menuSelected == 4)
    {

        Console.WriteLine(menuOptions[0]);

        Console.WriteLine(menuOptions[1]);

        Console.WriteLine(menuOptions[2]);

        Console.WriteLine(menuOptions[3]);

        Console.WriteLine(menuOptions[4] + "<---");

        

    }
    var keyPressed = Console.ReadKey();
    if (keyPressed.Key == ConsoleKey.DownArrow && menuSelected != menuOptions.Length -1)// Setup for how you navigate the arrow menu. It detects when you press the up/down arrow key on your keyboard.
    {
        menuSelected++;
    }
    else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelected >= 1)
    {
        menuSelected--;
    }
    else if (keyPressed.Key == ConsoleKey.Enter)
    {
        switch (menuSelected)// The switch Case that displays our options listed above. 
        {
        case 0:
            FirstChoice();
        break;
        case 1:
            SecondChoice();
        break;
        case 2:
            ThirdChoice();
        break;
        case 3:
            FourthChoice();
        break;
        case 4:
            FifthChoice();
        break; 
        }




    

    static void FirstChoice() // Let´s the user choose from a two different sandwiches in our vendingmachine
        {
            //I use a class to call the defined paremeters of the Mackor class. 
            
            Console.WriteLine("Mackor"); 
            Mackor macka1 = new Mackor();// I add attributes to objects in the Mackor class.
            macka1.pålägg = "ost";
            macka1.bröd = "vitt";
            macka1.price = 30;
            
            Mackor macka2 = new Mackor(); // I add attributes to objects in the Mackor class.
            macka2.pålägg = "Skinka";
            macka2.bröd = "Mörkt";
            macka2.price = 20;

                // I use the defined class objects to form to optiones that the user can choose from. Below i created a sub-menu.
                Console.WriteLine("Varuatomaten erbjuder två alternativ. Välj mellan 1 & 2. ");
                Console.WriteLine("[1] Macka med " + macka1.bröd + " bröd och " + macka1.pålägg + " som kostar " + macka1.price + "kr\n");
                Console.WriteLine("[2] Macka med " + macka2.bröd + " bröd och " + macka2.pålägg + " som kostar " + macka2.price + "kr");
                
                int mackmenu = Convert.ToInt32(Console.ReadLine()); // The user can choose options in the sub-menu between 1 & 2. 
        
                if (mackmenu == 1)
                {   
                    // The user picked the first option. Then presses Enter to finalise the purchase.
                    Console.WriteLine("Ni har valt altnernativ 1. Tryck Enter för att fortsätta.");
                    var endKey = Console.ReadKey();
                    if (endKey.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Köpt bekräftat för" + macka1.price + "kr, varan finns i varuuttaget. "); // Returns the price of the item to the users
                        Console.ReadKey();
                    }
                    else if (mackmenu == 2)
                    {     // The user picked the second option. Then presses Enter to finalise the purchase.
                        Console.WriteLine("Ni har valt altnernativ 2. Tryck Enter för att fortsätta.");
                        var endKey2 = Console.ReadKey();
                        if (endKey2.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Köpt bekräftat för" + macka2.price + "kr, varan finns i varuuttaget. "); // Returns the price of the item to the users
                            Console.ReadKey();
                        }
                    }else
                    {      // In case the user enters a wrong number it will break the loop and return to the main menu.
                        wrongAnswer();
                        Console.ReadKey();
                    }


                }
            }
    static void SecondChoice()
    {
    Console.WriteLine("Läsk");

    Soda soda1 = new Soda(); //I add attributes to objects in the Soda class.
    soda1.märke = "Coca Cola"; 
    soda1.storlek = 0.33;
    soda1.price = 30;

    Soda soda2 = new Soda(); //I add attributes to objects in the Soda class.
    soda2.märke = "Fanta"; 
    soda2.storlek = 0.5;
    soda2.price = 35;

    Soda soda3 = new Soda(); //I add attributes to objects in the Soda class.
    soda3.märke = "Sprite";
    soda3.storlek = 1;
    soda3.price = 40;

    Console.WriteLine("Varuatomaten erbjuder tre alternativ av läsk. Välj mellan 1, 2 & 3. "); // I use the class attributes and create a sub-menu. The user can make the choice by using the keypad on the keyboard.
    Console.WriteLine("[1]" + soda1.märke + " storlek " +  soda1.storlek + "liter, med pris " + soda1.price);
    Console.WriteLine("[2]" + soda2.märke + " storlek " +  soda2.storlek + "liter, med pris " + soda2.price);
    Console.WriteLine("[3]" + soda3.märke + " storlek " +  soda3.storlek + "liter, med pris " + soda3.price);
    int sodamenu = Convert.ToInt32(Console.ReadLine()); // Convert user input to a number and uses it in the sub-menusystem below
    if (sodamenu == 1)
    {
        Console.WriteLine("Ni har valt altnernativ 1. Tryck Enter för att fortsätta.");
        var endKey = Console.ReadKey();
        if (endKey.Key == ConsoleKey.Enter) // The customer presses enter to confim the purchase
        {
            Console.WriteLine("Bekräftar köpt av" + soda1.märke +  " för " + soda1.price + "kr, varan finns i varuuttaget. "); // Returns the price of the item to the users
            Console.ReadKey();
        }    

    }
    else if (sodamenu == 2)
    {
        Console.WriteLine("Ni har valt altnernativ 2. Tryck Enter för att fortsätta.");
        var endKey = Console.ReadKey();
        if (endKey.Key == ConsoleKey.Enter)// The customer presses enter to confim the purchase
        {
            Console.WriteLine("Bekräftar köpt av" + soda2.märke +  " för " + soda2.price + "kr, varan finns i varuuttaget. "); // Returns the price of the item to the users
            Console.ReadKey();
        }   
    }
    else if (sodamenu == 3){
        Console.WriteLine("Ni har valt altnernativ 3. Tryck Enter för att fortsätta.");
        var endKey = Console.ReadKey();
        if (endKey.Key == ConsoleKey.Enter) // The customer presses enter to confim the purchase
        {
            Console.WriteLine("Bekräftar köpt av" + soda3.märke +  " för " + soda3.price + "kr, varan finns i varuuttaget. ");// Returns the price of the item to the users
            Console.ReadKey();
        }   
    }
    else
    {
        wrongAnswer(); // In case of invalid input, returns to main menu. 
    }
    Console.ReadLine();
    }
    static void ThirdChoice()
    {
    Candy candy1 = new Candy(); //I add attributes to objects in the Candy class.
    candy1.märke = "plopp";
    candy1.Sockerfri = "Nej";
    candy1.price = 12;

    Candy candy2 = new Candy(); //I add attributes to objects in the Candy class.
    candy2.märke = "Center";
    candy2.Sockerfri = "Nej";
    candy2.price = 15;

    Candy candy3 = new Candy(); //I add attributes to objects in the Candy class.
    candy3.märke = "Marabou";
    candy3.Sockerfri = "Nej";
    candy3.price = 20;

    Candy candy4 = new Candy(); //I add attributes to objects in the Candy class.
    candy4.märke = "torkad banan";
    candy4.Sockerfri = "Ja";
    candy4.price = 20;
    candy4.vikt  = 1.4;

    Candy candy5 = new Candy(); //I add attributes to objects in the Candy class.
    candy5.märke = "nötter";
    candy5.Sockerfri = "Ja";
    candy5.price = 30;
    candy5.vikt = 1.2;

    Candy candy6 = new Candy(); //I add attributes to objects in the Candy class.
    candy6.märke = "dadlar";
    candy3.Sockerfri = "Ja";
    candy6.price = 35;
    candy6.vikt = 1.3;

    Console.WriteLine("Godis"); // I create another sub-menu for the options regarding candy. The user the key 1-3 to choose. 
    Console.WriteLine("Varuautomaten erbjuder tre alternativ.\n ");
    Console.WriteLine("[1] Välj egna godissorter ");
    Console.WriteLine("[2] Slumpa en ett alternativ");
    Console.WriteLine("[3] Sockerfritt");
    int candymenu = Convert.ToInt32(Console.ReadLine());

        if (candymenu == 1)
        {
        Console.Clear();    
        string [] candyK = new string [4]; // An arrray that displays a list of prices, created by using class attributes. 
        candyK[1] = "[1]" +  candy1.märke + ", pris:" + candy1.price;
        candyK[2] = "[2]" + candy2.märke + ", pris:" + candy2.price;
        candyK[3] = "[3]" + candy3.märke + ", pris:" + candy3.price;
        foreach (string s in candyK)
        Console.WriteLine(s);
        Console.WriteLine("\nTryck Enter för att fortsätta");
        Console.ReadKey();
       
        Console.WriteLine("\nSkriv in siffran på den godis ni önskar köpa");
        string[] candy = new string[] {candy1.märke +": kostnad: " + candy1.price, candy2.märke + ": kostnad:" +  candy2.price, candy3.märke + ": kostnad:" + candy3.price };// diplsys a list that will allow the user to choose from our menu. 
        int index = Convert.ToInt32(Console.ReadLine()); // input from the user acts as an index indicator and chooses the correct item from the list
        Console.WriteLine($"Er godis är  {candy[index]}"); // This module target the index the user entered and acces the correct item in my list. Then diplsays the information. 
        Console.ReadKey();      
        
    }
    else if (candymenu == 2)
    {   Console.Clear(); // Clear the console of the previous menu options.
        string[] candyL = new string[] {candy1.märke +": kostnad:" + candy1.price, candy2.märke + ": kostnad:" +  candy2.price, candy3.märke + ": kostnad:" + candy3.price };// Displays the items in our list.
        Random rnd = new Random(); // Picks a random item from the list in case the user dont wan´t to choose. 
        int index = rnd.Next(candyL.Length); // This will randomize a number from the lists index and display it´s counterpart. 
        Console.WriteLine($"Er slumpmässiga godis är {candyL[index]}\n");
        var endKey = Console.ReadKey();
        Console.WriteLine("Tryck ENTER för att bekräfta köp. tryck övrig tangent för att avbryta.");

        if (endKey.Key == ConsoleKey.Enter) // The customer presses enter to confim the purchase
        {
            Console.WriteLine("Köpt bekräftat, varan finns i varuuttaget. ");
        }
        else
        {
            Console.WriteLine("Köp avbrutet"); // If the user presser another key than Enter the purchase won´t go trough.
        }    
        

    
    }
    else if (candymenu == 3)
    {   Console.Clear(); // Clear the console of the previous menu options.
        Console.WriteLine("Sockerfritt\n");
        Console.WriteLine("Sockerfritt godis köps i lösvikt, skriv in önskad mängd automaten så skapas en påse.");
        Console.Write("Varuatomaten har tre olika sockerfria alternativ: " + candy4.märke + ", " + candy5.märke + " och " + candy6.märke); // presents the options using attribyes from the Candy class.

        Console.WriteLine("\nSkriv in önskad vikt av " + candy4.märke); // I added an option that adds the value the user inputs and multipli it with the price set in the class attribute. 
        double weight4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("pris:" + weight4 * candy4.price);
        double all4 = weight4 * candy4.price;

        Console.WriteLine("Skriv in önskad vikt av " + candy5.märke); // Same as above,I added an option that adds the value the user inputs and multipli it with the price set in the class attribute.
        double weight5 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("pris: " + weight5 * candy5.price);
        double all5 = weight5 * candy5.price;

        Console.WriteLine("Skriv in önskad vikt av " + candy6.märke);// Same as above,I added an option that adds the value the user inputs and multipli it with the price set in the class attribute.
        double weight6 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("pris: " + weight6 * candy6.price);
        double all6 = weight6 * candy6.price;

        double total = all4 + all5 + all6;
        Console.WriteLine("Totala kostnaden för ert inköp är: " + total); // The result from the user input is saves in double variable and added togheter to show the total price. 
        Console.ReadKey();
    }
    else
    {
        wrongAnswer(); // Returs to the main meny in case the user inputs the wrong symbols.
    }

    }
    static void FourthChoice()
    {
        
        Energy energy1 = new Energy(); //I add attributes to objects in the Energy class.
        energy1.märke = "Redbull";
        energy1.storlek = 0.5;
        energy1.price = 30;

        Energy energy2 = new Energy(); //I add attributes to objects in the Energy class.
        energy2.märke = "Nocco";
        energy2.storlek = 0.33;
        energy2.price = 25;

        Energy energy3 = new Energy(); //I add attributes to objects in the Energy class.
        energy3.märke = "Celsius";
        energy3.storlek = 0.5;
        energy3.price = 32;

    Console.Clear();
    Console.WriteLine("Varuatomaten erbjuder tre alternativ av energidricka. Välj mellan 1, 2 & 3. "); // I create another sub-menu for the options regarding energydrinks. The user the key 1-3 to choose. 
    Console.WriteLine("[1]" + energy1.märke + " storlek " +  energy1.storlek + "liter, med pris " + energy1.price); // i use the attributes from the Energyclass to make an menusystem.
    Console.WriteLine("[2]" + energy2.märke + " storlek " +  energy2.storlek + "liter, med pris " + energy2.price); // i use the attributes from the Energyclass to make an menusystem.
    Console.WriteLine("[3]" + energy3.märke + " storlek " +  energy3.storlek + "liter, med pris " + energy3.price); // i use the attributes from the Energyclass to make an menusystem.
    int energymenu = Convert.ToInt32(Console.ReadLine());
    if (energymenu == 1)
        {   
            Console.WriteLine("Ni har valt altnernativ 1. Tryck Enter för att fortsätta.");
            var endKey = Console.ReadKey();
            if (endKey.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Bekräftar köpt av " + energy1.märke +  " för " + energy1.price + "kr, varan finns i varuuttaget. "); // Displays the brand and price of the purchase.
                Console.ReadKey();
            }else
            {
                wrongAnswer();  // Returns to the main meny in case the user inputs the wrong symbols.
            }    

        }
    else if (energymenu == 2){
        Console.WriteLine("Ni har valt altnernativ 2. Tryck Enter för att fortsätta.");
        var endKey = Console.ReadKey();
        if (endKey.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Bekräftar köpt av " + energy2.märke +  " för " + energy2.price + "kr, varan finns i varuuttaget. "); // Displays the brand and price of the purchase.
            Console.ReadKey();
        }else
        {
           wrongAnswer(); // Returns to the main meny in case the user inputs the wrong symbols.
        }   
    }
        else if (energymenu == 3)
        {
        Console.WriteLine("Ni har valt altnernativ 3. Tryck Enter för att fortsätta.");
        var endKey = Console.ReadKey();
        if (endKey.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Bekräftar köpt av " + energy3.märke +  " för " + energy3.price + "kr, varan finns i varuuttaget. "); // Displays the brand and price of the purchase.
            Console.ReadKey();
        }
        else
        {
           wrongAnswer(); // Returns to the main meny in case the user inputs the wrong symbols.
        }
    }







    }
    static void FifthChoice()
    {
        Console.WriteLine("Avsluta \n"); // An option the quit the application.
        Console.ReadKey();
        Environment.Exit(1); // Shuts down the console application.
    }


                                                        //Functions//  
    static void wrongAnswer() // Function that displays en error messege to the user, used multiple times throughout the code. 
    {
        Console.WriteLine("Felaktigt inmatning, försök igen.");
    }




    }
            }

        }
    }
}