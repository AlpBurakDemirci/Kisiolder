using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisifolder
{
    public class Management
    {
        Boolean controlVar;
        String userInput;
        Kisi kisi2;
        public void getinput()
        {
            School school1 = new School();
            School school2 = new School();
            School school3 = new School();
            Food favorieyemek = new Food();

            school1.district = "izmir";
            school1.name = "abızıdttın ilkokulu";
            school1.city = "asdad";
            school1.score = 5;

            school2.district = "izmir";
            school2.name = "abızıdttın ilkokulu";
            school2.city = "asdad";
            school2.score = 5;

            school3.district = "izmir";
            school3.name = "abızıdttın ilkokulu";
            school3.city = "asdad";
            school3.score = 5;


            favorieyemek.cost = 2912;
            favorieyemek.name = "makarna";
            favorieyemek.type = "hamur";






            Kisi kisi1 = new Kisi();
            kisi1.name = "egehan";
            kisi1.surname = "cakir";
            kisi1.age = 28;
            kisi1.schools = new List<School>();
            kisi1.schools.Add(school1);
            kisi1.schools.Add(school2);
            kisi1.schools.Add(school3);
            kisi1.favoriteFood = new List<Food>();
            kisi1.favoriteFood.Add(favorieyemek);

            Console.WriteLine("First person is named " + kisi1.name + " " + kisi1.surname + " and that person is " + kisi1.age + " years old.");
            Console.WriteLine("This person went to " + kisi1.schools[0].name + ", " + kisi1.schools[1].name + " and " + kisi1.schools[2].name + ".");
            Console.WriteLine("This persons favorite food is " + kisi1.favoriteFood[0].name + ".");

            // İKİNCİ KİŞİ BAŞLANGICI
            kisi2 = new Kisi();
            kisi2.schools = new List<School>();
            kisi2.favoriteFood = new List<Food>();

            Console.WriteLine("Please input the second persons name:");
            kisi2.name = Console.ReadLine();
            Console.WriteLine("Please input the second persons surname:");
            kisi2.surname = Console.ReadLine();
            Console.Write("Please input the second persons age.");
            do
            {

                Console.WriteLine("Please enter an integer value:");
                var inputs = CheckInput();
                controlVar = inputs.Item1;
                userInput = inputs.Item2;

            }

            while (controlVar == false);
            kisi2.age = Convert.ToInt32(userInput);


            School school4 = new School();

            //ilk okul yazışı
            Console.WriteLine("What is the name of the school this person went to:");
            school4.name = Console.ReadLine();
            Console.WriteLine("In which city is the school located:");
            school4.city = Console.ReadLine();
            Console.WriteLine("In which district is the school located:");
            school4.district = Console.ReadLine();
            Console.Write("What is the score of the school.");
            do
            {
                Console.WriteLine("Please enter an integer value:");
                var inputs = CheckInput();
                controlVar = inputs.Item1;
                userInput = inputs.Item2;

            }

            while (controlVar == false);//int check
            school4.score = Convert.ToInt32(userInput);
            kisi2.schools.Add(school4);


            while (true)
            {

                Console.Write("Did " + kisi2.name + " went to any other schools.");
                Console.WriteLine("Y or N:");
                string userInput = Console.ReadLine();
                if (AnswerControl(userInput))
                {

                    OtherSchoolsWent(); //sonraki okul yazışları

                }

                else break;
            }


            //ilk yemek yazışı
            Food favoriteFood2 = new Food();
            Console.WriteLine("What is the name of that persons favorite food:");
            favoriteFood2.name = Console.ReadLine();
            Console.WriteLine("What type of food is it:");
            favoriteFood2.type = Console.ReadLine();
            Console.Write("How much does that food cost.");
            do
            {

                Console.WriteLine("Please enter an integer value:");
                var inputs = CheckInput();
                controlVar = inputs.Item1;
                userInput = inputs.Item2;

            }

            while (controlVar == false);
            favoriteFood2.cost = Convert.ToInt32(userInput);
            kisi2.favoriteFood.Add(favoriteFood2);

            while (true)
            {

                Console.Write("Does " + kisi2.name + " have any other favorite foods.");
                Console.WriteLine("Y or N:");
                string userInput = Console.ReadLine();
                if (AnswerControl(userInput))
                {

                    OtherFavoriteFood();

                }

                else break;

            }


            Console.WriteLine("");
            Console.WriteLine("Second person is named " + kisi2.name + " " + kisi2.surname + " and that person is " + kisi2.age + " years old.");
            Console.WriteLine("The name of the schools that " + kisi2.name + "went to:");




            for (int i = 0; i < kisi2.schools.Count; i++)
            {

                Console.WriteLine(kisi2.schools[i].name);

            }



            Console.WriteLine("-------------------------------------------------------------------------------------------");

            Console.WriteLine("This persons favorite foods are:");

            for (int i = 0; i < kisi2.favoriteFood.Count; i++)
            {

                Console.WriteLine(kisi2.favoriteFood[i].name);

            }






            /*ilk kişiye ait tüm bilgileri consoledan bu kod satırı içerisinde yazdır

        bı  girilen bilgileri console üzerinden al.
        Console.ReadLine();

        */
        }

        public void OtherSchoolsWent()
        {
            School skul = new School();
            Console.WriteLine("What is the name of that school:");
            skul.name = Console.ReadLine();
            Console.WriteLine("In which city is the school located:");
            skul.city = Console.ReadLine();
            Console.WriteLine("In which district is the school located:");
            skul.district = Console.ReadLine();
            Console.Write("What is the score of the school.");
            do
            {

                Console.WriteLine("Please enter an integer value:");
                var inputs = CheckInput();
                controlVar = inputs.Item1;
                userInput = inputs.Item2;

            }

            while (controlVar == false);
            skul.score = Convert.ToInt32(userInput);
            kisi2.schools.Add(skul);
        }
        public void OtherFavoriteFood()
        {

            Food foot = new Food();
            Console.WriteLine("What is the name of that persons favorite food:");
            foot.name = Console.ReadLine();
            Console.WriteLine("What type of food is it:");
            foot.type = Console.ReadLine();
            Console.Write("How much does that food cost.");
            do
            {

                Console.WriteLine("Please enter an integer value:");
                var inputs = CheckInput();
                controlVar = inputs.Item1;
                userInput = inputs.Item2;

            }

            while (controlVar == false);

            foot.cost = Convert.ToInt32(userInput);
            kisi2.favoriteFood.Add(foot);

        }

        public (Boolean, string) CheckInput()
        {
            string userInput = Console.ReadLine();
            try
            {

                Convert.ToInt32(userInput);
                return (true, userInput);

            }
            catch (Exception nonIntValue)
            {

                return (false, userInput);

            }

        }
        public Boolean AnswerControl(string answer){

            Boolean pAnswers = pozitiveAnswers(answer);
            Boolean nAnswers = negativeAnswers(answer);

            if (pAnswers == true)
            {

                return true;

            }

            else if (nAnswers == true)
            {

                return false;

            }

            else
            {

                Console.WriteLine("That answer is not acceptable, please answer with a yes or no:");
                string userAnswer = Console.ReadLine();
                return AnswerControl(userAnswer);
            
            }
    
        } 
        

        public Boolean pozitiveAnswers(string answer)
        {

            List<string> pozitiveAnswers = new List<string>();
            pozitiveAnswers.Add("Yes");
            pozitiveAnswers.Add("Y");
            pozitiveAnswers.Add("YES");
            pozitiveAnswers.Add("YEs");
            pozitiveAnswers.Add("YeS");
            pozitiveAnswers.Add("yES");
            pozitiveAnswers.Add("yEs");
            pozitiveAnswers.Add("yeS");
            pozitiveAnswers.Add("yes");

            if (pozitiveAnswers.Contains(answer) == true)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public Boolean negativeAnswers(string answer)
        {

            List<string> negativeAnswers = new List<string>();
            negativeAnswers.Add("No");
            negativeAnswers.Add("N");
            negativeAnswers.Add("NO");
            negativeAnswers.Add("no");
            negativeAnswers.Add("nO");

            if (negativeAnswers.Contains(answer) == true)
            {

                return true;

            }
            else

                return false;
        }


    }
}