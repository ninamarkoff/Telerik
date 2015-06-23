using System;

public class IsFemale
{
    public static void Main()
    {
        /* Problem 6, Lecture 2:
         * Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.*/
        bool isFemale;
        Console.WriteLine("Are you female: Yes/No?");
        string genderFemale=Console.ReadLine();
        if (genderFemale == "Yes" || genderFemale == "yes" || genderFemale == "Y" || genderFemale == "y")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }

        Console.WriteLine(isFemale);
    }
}

