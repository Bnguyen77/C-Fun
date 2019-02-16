using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicOfCSharp

    //basic of Classes and Struct 
{
    class Program
    {

        class PetClass
        {
            public int legs;
            public PetType type;
            public string name;
            public bool hasFur;
        }

        struct PetStruct
        {
            public int legs;
            public PetType type;
            public string name;
            public bool hasFur;
        }

        enum PetType
        {
            dog,
            duck
        }

        //Method to change attribute in the given intance

        static void MultipliedLeg(PetStruct dogLeg, PetClass duckLeg)
        {
            dogLeg.legs = dogLeg.legs * 2;
            duckLeg.legs = duckLeg.legs * 2;

            Console.WriteLine("Internal Method- {0}", dogLeg.legs);
            Console.WriteLine("Internal Method- {0}", duckLeg.legs);
        }


        static void Main(string[] args)
        {
            
            PetStruct dog = new PetStruct();
            dog.type = PetType.dog;
            dog.hasFur = true;
            dog.name = "Anthony";
            dog.legs = 4;

            PetClass duck = new PetClass();
            duck.type = PetType.duck;
            duck.hasFur = true;
            duck.name = "Donald";
            duck.legs = 2;

            Console.WriteLine("the dog name {0} has {1} and is {2} type", dog.name, dog.legs, dog.type);
            Console.WriteLine("the duck name {0} has {1} and is {2} type", duck.name, duck.legs, duck.type);
            MultipliedLeg(dog, duck);
            Console.WriteLine("the dog name {0} has {1} and is {2} type", dog.name, dog.legs, dog.type);
            Console.WriteLine("the duck name {0} has {1} and is {2} type", duck.name, duck.legs, duck.type);

            //initialize without pre-populated array.
            int[] intArray = new int[5];
            string[] stringArray = new string[3];

            //initalize prepopulated array.
            int[] populatedIntArray = new int[] { 1, 2, 3, 4, 5 };
            string[] populatedStringArray = new string[] { "Binh", "Hai, 'Anthony" };

            //asign value can be done for both unpopulated and prepopulated array
            intArray[0] = 2;
            Console.WriteLine(intArray[0]);

            populatedStringArray[1] = "Bento";
            Console.WriteLine(populatedStringArray[1]);

            //********MULTIDIMENTIONAL ARRAY***********
            int[,] multiInt = new int[3, 5];
            int[,] multiPopulatedInt = { { 1, 2, 3 }, { 3, 4, 5 }, { 6, 7, 8 } };

            int val1 = multiPopulatedInt[0, 0]; //val is 1
            int val2 = multiPopulatedInt[1, 2]; //val is 5
            int val3 = multiPopulatedInt[2, 1]; //val is 7

            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);


            //*********LIST************
            //initilize List, not length asigned needed
            List<string> listOfStrings = new List<string>();

            //add or remove item to the list
            listOfStrings.Add("First Item");
            listOfStrings.Add("Second Item");
            listOfStrings.Add("Third Item");
            listOfStrings.Insert(1, "inserted Item"); //insert by index will push the value down instead of overide it

            listOfStrings.Remove("First Item"); //remove particular Item
            listOfStrings.RemoveAt(0);//remove index

            Console.WriteLine(listOfStrings.Count);
            Console.WriteLine(listOfStrings[1]);

            //***********DICTIONARY****************
            Dictionary<string, string> selectedActor = new Dictionary<string, string>();
            selectedActor.Add("name", "Jame Bond");
            selectedActor.Add("nationality", "England");
            selectedActor.Add("job", "MI6-SPY");
            selectedActor.Add("status", "Single");

            Console.WriteLine(selectedActor["name"]);
            Console.WriteLine(selectedActor["nationality"]);
            Console.WriteLine(selectedActor["job"]);
            Console.WriteLine(selectedActor["status"]);


            //************LINQ********************
            List<PetClass> petList = new List<PetClass>();
            petList.Add(new PetClass { name = "Anthony", type = PetType.dog, legs = 4, hasFur = true });
            petList.Add(new PetClass { name = "Dante", type = PetType.duck, legs = 2, hasFur = false });

            //List<PetClass> selectedPet = (from p in petList
              //                            where p.legs == 4
                //                          select p).ToList();
            List<PetClass> selectedPet = petList.Where(p => p.legs == 4).ToList();

            //PetClass selectedPet1 = (from p in petList
              //                          where p.hasFur == false
                //                        select p).FirstOrDefault();
            PetClass selectedPet1 = petList.Where(p => p.hasFur == false).FirstOrDefault();


            Console.WriteLine("result of the selectedPet is " +selectedPet[0].type + " and the name is " + selectedPet[0].name);
            Console.WriteLine("result of the selectedPet is " + selectedPet1.type + " and the name is " + selectedPet1.name);
        }
    }
}
