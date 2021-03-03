using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CatConsoleOOP
{
    class Car
    {

        private static int carCounter = 0;


        public static int NumberOfCars { get { return carCounter; } }

        //If no access modifiers is present for a field/method/property, thay will all defualt to Private.
        int id;
        string brand;
        string model;
        int year;
        public int maxSpeed;
        string regPlate;

        public string RegPlate
        {
            get
            {
                return regPlate;
            }

            set
            {
                regPlate = value.ToUpper();
            }
        }
        public Car(string brand, string modelName, int year)
        {
            id = ++carCounter;
            this.brand = brand;
            model = modelName;
            this.year = year;
            //this.maxSpeed = maxSpeed;
        }

        //chained constructor
        public Car(string brand, string modelName, int year, int maxSpeed, string regPlate) : this(brand, modelName, year)
        {
            this.maxSpeed = maxSpeed;
            this.regPlate = regPlate;  //leave this for Ulf to find during test later 
            
        }
/*        public override string ToString()
        {
           // return $"{brand} - {model} - {RegPlate}";

            return $"Car id: {id}\nBrand: {brand} \nModel: {model} \nYear: {year} \nMax Speed: {maxSpeed} \nReg Plate: {regPlate}";

        }*/

        public string CarToString()
        {
            return $"Car id: {id}\nBrand: {brand} \nModel: {model} \nYear: {year} \nMax Speed: {maxSpeed} \nReg Plate: {regPlate}";

        }
    }
}



/*private string RegPlateToString()
{
    StringBuilder reg = new StringBuilder();

    foreach (var item in regPlate)
    {
        reg.Append(item);
    }

    return reg.ToString().ToUpper();
}*/