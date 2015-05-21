using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexivite.Classes
{
    class ClassAnimal
    {
        string Nom;
        int Age;
        string Race;
        string TypeAnimal;
        DateTime AdoptionDate;

        public ClassAnimal()
        {
            SetAge(1);
            SetNom("Rodolf");
            SetRace("Bengal");
            SetType("Chat");
            SetAdoptionDate(DateTime.Now);
        }

        public ClassAnimal(int age, string nom)
        {
            SetAge(age);
            SetNom(nom);
            SetRace("Bengal");
            SetType("Chat");
            SetAdoptionDate(DateTime.Now);
        }

        public ClassAnimal(int age, string nom, string type)
        {
            SetAge(age);
            SetNom(nom);
            SetRace("Bengal");
            SetType(type);
            SetAdoptionDate(DateTime.Now);
        }
        public ClassAnimal(int age, string nom, string type, string race)
        {
            SetAge(age);
            SetNom(nom);
            SetRace(race);
            SetType(type);
            SetAdoptionDate(DateTime.Now);
        }
        public ClassAnimal(int age, string nom, string type, string race, DateTime adoptionDate)
        {
            SetAge(age);
            SetNom(nom);
            SetRace(race);
            SetType(type);
            SetAdoptionDate(adoptionDate);
        }


        public DateTime GetAdoptionDate()
        {
            return AdoptionDate.Date;
        }

        public string getType()
        {
            return TypeAnimal;
        }
        public string GetRace()
        {
            return Race;
        }
        public int GetAge()
        {
            return Age;
        }

        public string GetNom()
        {
            return Nom;
        }
        public void SetAdoptionDate(DateTime adoptionDate)
        {
            AdoptionDate = adoptionDate;
        }

        public void SetRace(string race)
        {
            Race = race;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
        public void SetNom(string nom)
        {
            Nom = nom;
        }
        public void SetType(string type)
        {
            TypeAnimal = type;
        }

    }
}