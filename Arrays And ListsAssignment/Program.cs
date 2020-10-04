using System;
using System.Collections.Generic;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        string[] favoriteSongsArray = { "Touch,Peel, and Stand", "Mad World", "Bittersweet Symphony", "White Flag", "Mariners Apartment Complex" };

        Console.WriteLine(" Let us create and populate a single-dimentional array that contains string data type values.\n Type the following code: \n\t\t string[] favoriteSongsArray =  {\"Touch, Peel And Stand\",\"Mad World\", \"Bittersweet Symphony\", \"White Flag\", \"Mariners Apartment Complex\"}");
        Console.ReadLine();
        Console.WriteLine("\n\n The code that you typed created and populated an array named \"favoriteSongsArray[ ]\" with 5 songs. Arrays are containers that hold collections of values. Theses values can be located by their index number. \n Index numbers start with 0 and increase by increments of 1 going left to right within the array. The values stored in the array are called \"elements\".\n\n\tNow, pick a number between 0 and 4 and you will see the song that is stored at that index location within this array.\n\n \t\t Enter the index number:");
        string userChoice = Console.ReadLine();
        int userChoiceIndex = Convert.ToInt32(userChoice);
        Console.WriteLine("You chose the index of " + userChoice + ". \n The song stored at favoriteSongsArray[ " + userChoice + " ] is:");
        string userSongChoice = favoriteSongsArray[userChoiceIndex];
        Console.WriteLine("\n" + userSongChoice + "\n\n\t Good choice! I hope that this exercise gives you a better grasp of how arrays work in C#.");
        Console.ReadLine();

        int[] favoriteNumbersArray = new int[] { 4, 19, 1971, 29, 3, 22, 1, 20, 9, 8, 2, 1996, 1990, 1998, 2000, 1943, 1942, 1963, 11, 10, 31, 1978 };

        Console.WriteLine(" Let us create and populate another single-dimentional array that contains integer data type values.\n Type the following code: \n\t\t int[] favoriteNumbersArray = new int [] {4,19,1971,29,3,22,1,20,9,8,2,1996,1990,1998,2000,1943,1942,1963,11,10,31,1978};");
        Console.ReadLine();
        Console.WriteLine("\n\n The code that you typed created and populated an array named \"favoriteNumbersArray[ ]\" with 22 numbers stored in it. Arrays are containers that hold collections of values. Theses values can be located by their index number. \n Index numbers start with 0 and increase by increments of 1 going left to right within the array. The values stored in the array are called \"elements\".\n\n\tNow, pick a number between 0 and 21 and you will see the number that is stored at that index location within this array.\n\n \t\t Enter the index number:");
        string userChoice1 = Console.ReadLine();
        int userChoiceIndex1 = Convert.ToInt32(userChoice1);
        Console.WriteLine("\n\nYou chose the index of " + userChoice1 + ". \n\nThe number stored at favoriteNumbersArray[ " + userChoice1 + " ] is:");
        int userNumberChoice = favoriteNumbersArray[userChoiceIndex1];
        Console.WriteLine(Convert.ToString(userNumberChoice));


        int lengthArray = favoriteNumbersArray.Length;
        int i = lengthArray - 1;
        Console.WriteLine("\n\n " + Convert.ToString(lengthArray) + " is the length of the favoriteNumbersArray.\n\n  That means the array contains " + Convert.ToString(lengthArray) + " elements.\n To determine the number of indices within the array, subtract 1 from the length of the array ( this is because the index values start at 0).");
        Console.WriteLine("\n\n Now, choose an index location that does not fall within the specified range of 0 to 21. \n \n\t Enter the index number that is out-of-range:");
        int nonExistIndex = Convert.ToInt32(Console.ReadLine());

        string answer = (nonExistIndex > i) ? "\n\n The index you have chosen does not exist within the favoriteNumbersArray !!!\n  Therefore, there is no existing value to display that meets the criteria that you requested because it does not exist in this array." : "You Chose " + Convert.ToString(nonExistIndex) + " and that index location holds the value of :\n;\n\t\t" + Convert.ToString(favoriteNumbersArray[nonExistIndex]) + "\n\n BUT the you were asked to enter a number that is not in the range of the specified array... if you HAD choosen an iidex location that was out of range you would have recieved a message stating that there is no information to give you because it doesn'yt exist within the favoriteNumbersArray.";

        Console.WriteLine(answer);
        Console.WriteLine("\n\n I hope this helps you to understand arrays in C#\n\n ");
        Console.ReadLine();


        Console.WriteLine("\n\n Lastly,... I will create a List of Strings. \n\n Here is the code that I will be using:" +
            " \n\n\t\t List<string> shoppingList = new List<string>()");

        List<string> shoppingList = new List<string>();
        shoppingList.Add("cat food");
        shoppingList.Add("dog food");
        shoppingList.Add("cheese");
        shoppingList.Add("Doritos");
        shoppingList.Add("toilet paper");
        shoppingList.AddRange(favoriteSongsArray);

        Console.WriteLine("\n\n I have added " + shoppingList.Count + " items to my shopping list.\n\n Here is my Shopping list:");
        shoppingList.ForEach(Console.WriteLine);
        Console.WriteLine(" \n\n Now , ENTER the INDEX of the ITEM you wish to REMOVE from the shopping list: ");
        int removeItemIndex = Convert.ToInt32(Console.ReadLine());
        bool alteredShoppingList = shoppingList[removeItemIndex] != null;
        if (alteredShoppingList = true)
        {
            shoppingList.RemoveAt[removeItemIndex];
            Console.WriteLine(" \n\n You Chose the index location: " + Convert.ToString(removeItemIndex) + "\n\n The item to be removed from the list is: " + shoppingList[removeItemIndex] "\n\n The updated list is as follows:\n\n\t\t" + shoppingList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The item you wish to be removed does not exist.");
            Console.ReadLine();
        }




        
        
        
        Console.WriteLine("\n\n The newly revised version of our shopping list is as follows: \n\n  ");
        shoppingList.ForEach(Console.WriteLine);
        
        Console.ReadLine();














    }
    }

;