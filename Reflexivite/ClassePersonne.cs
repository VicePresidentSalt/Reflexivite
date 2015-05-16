
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexivite
{
    class ClassPersonne
    {
        string Nom;
        int Age;
        string Nationnalite;
        string CouleurCheveux;
        DateTime ArriverAuPays;

        public ClassPersonne()
        {
            SetAge(18);
            SetNom("Jean Paul");
            SetCouleurCheveux("Brun");
            SetNationnalite("Canadien");
            SetDateArrive(DateTime.Now);
        }

        public ClassPersonne(int age, string nom)
        {
            SetAge(18);
            SetNom("Jean Paul");
            SetCouleurCheveux("Brun");
            SetNationnalite("Canadien");
            SetDateArrive(DateTime.Now);
        }

        public ClassPersonne(int age, string nom, string nationnalite)
        {
            SetAge(age);
            SetNom(nom);
            SetCouleurCheveux("Brun");
            SetNationnalite(nationnalite);
            SetDateArrive(DateTime.Now);
        }
        public ClassPersonne(int age, string nom, string nationnalite, string couleurChx)
        {
            SetAge(age);
            SetNom(nom);
            SetCouleurCheveux(couleurChx);
            SetNationnalite(nationnalite);
            SetDateArrive(DateTime.Now);
        }
        public ClassPersonne(int age, string nom, string nationnalite, string couleurChx, DateTime dateArriverAuPays)
        {
            SetAge(age);
            SetNom(nom);
            SetCouleurCheveux(couleurChx);
            SetNationnalite(nationnalite);
            SetDateArrive(dateArriverAuPays);
        }


        public DateTime GetDateArrive()
        {
            return ArriverAuPays.Date;
        }

        public string getCouleurCheveux()
        {
            return CouleurCheveux;
        }
        public string GetNationnalite()
        {
            return Nationnalite;
        }
        public int GetAge()
        {
            return Age;
        }

        public string GetNom()
        {
            return Nom;
        }
        public void SetDateArrive(DateTime date)
        {
            ArriverAuPays = date;
        }

        public void SetCouleurCheveux(string couleur)
        {
            CouleurCheveux = couleur;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
        public void SetNom(string nom)
        {
            Nom = nom;
        }
        public void SetNationnalite(string nationnalite)
        {
            Nationnalite = nationnalite;
        }
    }
}