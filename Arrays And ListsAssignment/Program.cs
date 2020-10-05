using System;
using System.Collections.Generic;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
        //One-dimensional array of strings
        string[] favoriteSongsArray = { "Touch,Peel, and Stand", "Mad World", "Bittersweet Symphony", "White Flag", "Mariners Apartment Complex" };

        Console.WriteLine("\n\n Let us create and populate a single-dimentional array that contains string data type values." +
            "\n\n Type the following code:" +
            " \n\n\t\t string[] favoriteSongsArray =  {\"Touch, Peel And Stand\",\"Mad World\", \"Bittersweet Symphony\"," +
            " \"White Flag\", \"Mariners Apartment Complex\"};");
        Console.ReadLine();

        Console.WriteLine("\n\n The code that you typed accomplished two objectives.\n It created an array named \"favoriteSongsArray[ ]\"." +
            " \n Then, it populated that array with 5 songs.\n\n Arrays are containers that hold collections of values." +
            "\n These values (called \"elements\") can be located by their index number." +
            " \n\n Index numbers start with 0 and increase by increments of 1 going left to right within the array." +
            "\n The index number makes it possible to specify the exact location of each element within an array. "+
            "\n Software developers are then able to utilize the index number to retrieve and/or manage the data as necessary." +
            "\n\n Now, pick a number between 0 and 4 and you will see the song that is stored at that index location within this array." +
            "\n\n  Enter the index number:");
        string userChoice = Console.ReadLine();
        int userChoiceIndex = Convert.ToInt32(userChoice);

        Console.WriteLine("\n You chose the index of " + userChoice + ". \n The song stored at favoriteSongsArray[ " + userChoice + " ] is:");

        string userSongChoice = favoriteSongsArray[userChoiceIndex];

        Console.WriteLine("\n " + userSongChoice + "\n\n\t Good choice! I hope that this exercise gives you a better grasp of how string arrays work in C#.");
        Console.ReadLine();

        //One-dimensional array of integers 
        int[] favoriteNumbersArray = new int[] { 4, 19, 1971, 29, 3, 22, 1, 20, 9, 8, 2, 1996, 1990, 1998, 2000, 1943, 1942, 1963, 11, 10, 31, 1978 };

        Console.WriteLine("\n\n Let us create and populate another single-dimentional array that contains integer data type values" +
            ".\n Type the following code: " +
            "\n\n\t\t int[] favoriteNumbersArray = new int [] {4,19,1971,29,3,22,1,20,9,8,2,1996,1990,1998,2000,1943,1942,1963,11,10,31,1978};");
        Console.ReadLine();

        Console.WriteLine("\n\n The code that you typed created an array named \"favoriteNumbersArray[ ]\"." +
            " \n\n We also populated this newly created array with 22 integer values." +
            "\n\n Arrays provide developers with places to store and organize collections of data." +
            "\n You can think of an array as container that holds values of a specific type ( a collection of data, so to speak)." +
            "\n\n As mentioned above, these values can be located by their index number." +
            " \n Index numbers start with 0 and increase by increments of 1 going left to right within the array." +
            "\n The values stored in the array are called \"elements\"." +
            "\n\n Another useful aspect of indices is that you can use them to iterate through the elements in an array." +
            "\n This can be a very handy when using conditional statements to search and/or sort through the information stored within arrays." +
            "\n\n Now, pick a number between 0 and 21 and you will see the number that is stored at that index location within this array." +
            "\n\n Enter the index number:");
       
        string userChoice1 = Console.ReadLine();
        int userChoiceIndex1 = Convert.ToInt32(userChoice1);

        Console.WriteLine("\n\n You chose the index of " + userChoice1 + ". " +
            "\n\n The number stored at favoriteNumbersArray[ " + userChoice1 + " ] is:");
     

        int userNumberChoice = favoriteNumbersArray[userChoiceIndex1];

        Console.WriteLine(Convert.ToString(userNumberChoice));
        Console.ReadLine();

        int lengthArray = favoriteNumbersArray.Length;
        int i = lengthArray - 1;

        Console.WriteLine("\n\n " + Convert.ToString(lengthArray) + " is the length of the favoriteNumbersArray." +
            "\n\n  That means the array contains " + Convert.ToString(lengthArray) + " elements." +
            "\n To determine the number of indices within the array, subtract 1 from the length of the array ( this is because the index values start at 0)." +
            "\n The Code for finding the length of an array is: \n\n\t\t int lengthArray = favoriteNumbersArray.Length;");


        Console.WriteLine("\n\n Now, choose an index location that does not fall within the specified range of 0 to 21." +
            " \n \n Enter the index number that is \"out-of-range\":");
       
        int nonExistIndex = Convert.ToInt32(Console.ReadLine());

        // this "answer" uses a ternary conditional statement with a boolean and also includes an exception handler statement(so to speak) in case the user doesn't enter and index that is out of range
         
        string answer = (nonExistIndex > i) ? "\n\n The index you have chosen does not exist within the favoriteNumbersArray !!!" +
            "\n Therefore, there is no existing value to display that meets the criteria that you requested because it does not exist in this array." :
            "\n\n You chose " + Convert.ToString(nonExistIndex) + " and that index location holds the value of :\n\n\t\t" 
            + Convert.ToString(favoriteNumbersArray[nonExistIndex]) + 
            "\n\n Which is great!!... BUT, the instructions asked you to enter an idex number that does not fall within the range of the specified array..." +
            "\n So, let's pretend that you DID choose an index location that was out of range." +
            "\n Then, you would have recieved a message stating that there is no information to give you," +
            "\nWhy ??? -- Because I said so!!! Just kidding...Because that INDEX location does NOT exist within the favoriteNumbersArray!!!";

        Console.WriteLine(answer);
        Console.WriteLine("\n\n I hope this exercise using integers with arrays makes you more confident when using arrays in your C# programming.\n\n ");
        Console.ReadLine();

        Console.WriteLine("\n Lastly,... I will create a List of Strings.\n\n Here is the code that I will be using:" +
            " \n\n\t\t List<string> shoppingList = new List<string>()");

        List<string> shoppingList = new List<string>();
        shoppingList.Add("cat food");
        shoppingList.Add("dog food");
        shoppingList.Add("cheese");
        shoppingList.Add("Doritos");
        shoppingList.Add("toilet paper");
        shoppingList.AddRange(favoriteSongsArray);

        Console.WriteLine("\n\n I have added " + shoppingList.Count + " items to my shopping list.\n\n Let's take a look at my Shopping List:");

        shoppingList.ForEach(Console.WriteLine); // displays the whole shopping list on the console (vertically)

        Console.WriteLine(" \n\n Now it's your turn, ENTER the INDEX of the ITEM you wish to REMOVE from the shopping list: ");

        int removeItemIndex = Convert.ToInt32(Console.ReadLine());

        bool alteredShoppingList = shoppingList[removeItemIndex] != null; //assign boolean  to check and see if the index specified by the user exists
        if (alteredShoppingList == true) //iif it does exist then proceed
        {
             Console.WriteLine(" \n\n You Chose the index location: " + Convert.ToString(removeItemIndex) + //restate the INDEX number the user has chosen
                 "\n\n The item to be removed from the list is: " + shoppingList[removeItemIndex]); //tell the user what item that index number is connected to
            Console.ReadLine();
            shoppingList.RemoveAt(removeItemIndex); // remove the chosen item from the shopping list

            Console.WriteLine("\n\n The Updated Shopping List is as follows:\n\n\t\t"); //tell user this is the updated list

            foreach (var str in shoppingList) //use foreach loop to display each string value that remains in the shopping list NOTE: foreach loops do NOT keep track of index
            {
                Console.WriteLine(str);//.display newly revised shopping list to the console
            }
            Console.WriteLine("\n\n\n While Lists and Arrays seem like twins, THEY ARE NOT!!!" +
                " \n\n  Arrays are collections that are fixed in size and contain only one type of data." +
                " \n\n Lists are more flexible and provide the developer with many more useful methods to manipulate and manage the data they hold." +
                "\n For example: Lists are not fixed in size and they can hold multiple types of data." +
                "\n\n I hope this exercise has strengthened your C# programming knowledge bank and will serve you well on your journey to becoming an excellent software developer!!!");
            Console.ReadLine();// makes the content display until <Enter> is pressed by the user , then program ends
        }
 














    }
    }

;