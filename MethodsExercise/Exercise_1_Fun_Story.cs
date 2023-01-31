using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Exercise_1_Fun_Story
    {
        public static void StoryCreator ()
        {
            string userNameL;
            string userNameU;
            char charUserNameU;

            Console.WriteLine("What is your name?"); //output
            string userName = Console.ReadLine(); //input from user

            userNameL = userName.ToLower();
            char[] charUserName = userNameL.ToCharArray();
            charUserName[0] = char.ToUpper(charUserName[0]);
            userNameU = new string(charUserName);

            //---------------------------------------------------------------------
            //Alternatively (Cleaner)
            //string userNameL;
            //string userNameU;

            //Console.WriteLine("What is your name?"); //output
            //string userName = Console.ReadLine(); //input from user

            //userNameL = userName.ToLower();
            //userNameU = char.ToUpper(userNameL[0]) + userNameL.Substring(1);

            //----------------------------------------------------------------------


            string favoriteColorL; // all lowercase color
            string favoriteColorU; // first letter capitalized, everything else lowercase

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            favoriteColorL = favoriteColor.ToLower();
            char[] charFavoriteColor = favoriteColorL.ToCharArray();
            charFavoriteColor[0] = char.ToUpper(charFavoriteColor[0]);
            favoriteColorU = new string (charFavoriteColor);


            string favoriteAnimalL; // all lowercase color
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            favoriteAnimalL = favoriteAnimal.ToLower();


            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"{userNameU} loves everything {favoriteColorL}.");
            Console.WriteLine($"He even dyed his pet {favoriteAnimalL} {favoriteColorL}!");
            Console.WriteLine($"He named his pet {favoriteAnimalL} \"{favoriteColorU}\" too!");
            Console.WriteLine($"He takes it so far that he will only go watch his favorite band, {favoriteBand}," +
                $"if each member of the band is wearing {favoriteColorL}.");
        }
    }
}