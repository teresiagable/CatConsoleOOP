using System;
using System.Collections.Generic;
using System.Text;

namespace CatConsoleOOP
{
    class Cat2
    {

        private static int catCounter=0;

        public static int NumberOfCats { get { return catCounter; } }
        int id;
        string race;
        string color;
        int birthYear;
        string regNr;
        public string name;


        public string RegNr
        {
            get { return regNr; }
            set { regNr =value.ToUpper(); }
        }
        public Cat2(string race, string furColor, int birthYear)
        {
            id=++catCounter;
            this.race = race;
            this.color = furColor;
            this.birthYear = birthYear;
        }

        public Cat2(string race, string furColor, int birthYear ,string name, string regNr) : this( race,  furColor,  birthYear)
        {
            this.name = name;
            RegNr = regNr;
        }

        public string CatInformation()
        {
            return $"Cat id: {id}\nName: {name} \nRace: {race} \nColor: {color} \nBorn: {birthYear} \nRegister number: {regNr}";
        }
    }
}
