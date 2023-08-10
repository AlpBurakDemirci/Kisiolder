using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisifolder
{
    public class Kisi
    {

        public string name ;
        public string surname;
        public int age;
        public List<Food> favoriteFood { get; set; }
        public List<School> schools { get; set; }

        //public Kisi() {

        //    this.fillFoodList();
        //    this.fillSchoolList();

        //}

        //public void fillFoodList()
        //{

        //    Food newFood1 = new("Banana", "Fruit", "10$");
        //    favoriteFood.Add(newFood1);
        //    Food newFood2 = new("Spinach", "Vegetable", "12$");
        //    favoriteFood.Add(newFood2);
        //    Food newFood3 = new("Broccoli", "Vegetable", "8$");
        //    favoriteFood.Add(newFood3);
        //    Food newFood4 = new("Steak", "Meat", "52$");
        //    favoriteFood.Add(newFood4);
        //    Food newFood5 = new("Apple", "Fruit", "15$");
        //    favoriteFood.Add(newFood5);
        //}

        //public void fillSchoolList()
        //{

        //    School newSchool1 = new("Harmony Primary School", "London", "Harrow", "46");
        //    schools.Add(newSchool1);
        //    School newSchool2 = new("Aoyama Gakuin Senior High School", "Tokyo", "Shibuya", "79.8");
        //    schools.Add(newSchool2);
        //    School newSchool3 = new("Bogazici University", "Istanbul", "Besiktas", "87");
        //    schools.Add(newSchool3);

        //}

    }

}

