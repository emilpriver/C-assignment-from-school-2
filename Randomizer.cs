using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentamensadministration
{
    class Randomizer
    {
        public static Random rand = new Random();

        public static Kurs RandomKurs()
        {
            string[] adverb = {
            "Kognitiv", "Verksamhetsinriktad", "Interkulturell", "Semiotisk", "Semantisk"};

            string[] substantiv = {
            "informatik", "programmering", "systemering", "gränssnittsdesign",
            "modellering", "informationsteori","kommunikationsteori" };

            Kurs k = new Kurs();


            k.kursnamn =
                adverb[rand.Next(adverb.Length)] + " " +
                substantiv[rand.Next(substantiv.Length)];

            k.högskolepoäng = (rand.Next(14) + 1) / 2;
            return k;
        }

        public static Student RandomStudent()
        {
            string initials = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
            string[] names = {
            "Andersson", "Berghagen", "Bertilsson", "Davidsson", "Eriksson",
            "Fredriksson", "Gustavsson", "Henriksson", "Ivarsson", "Johansson",
            "Karlsson", "Lundström", "Magnusson", "Nilsson", "Olsson", "Pettersson",
            "Rickardsson", "Svensson", "Torstensson", "Viktorsson", "Wernersson"};

            Student e = new Student();

            char initial = initials[rand.Next(initials.Length)];
            string surname = names[rand.Next(names.Length)];

            e.namn = surname + ", " + initial;
            e.personnummer = RandomSSN();
            return e;
        }

        public static string RandomSSN()
        {
            string year = rand.Next(10, 90).ToString();
            int m = rand.Next(12) + 1;
            string month = m.ToString("00");
            int d = rand.Next(28) + 1;
            string day = d.ToString("00");

            string ssn = year + month + day;

            for (int i = 0; i < 4; i++)
            {
                ssn = ssn + rand.Next(10);
            }
            return ssn;
        }

        public static Kurs[] GenerateKurser(int antal)
        {
            //List<Kurs> list = new List<Kurs>();
            Kurs[] list = new Kurs[antal];


            for (int i = 0; i < antal; i++)
            {
                list[i] = RandomKurs();
            }
            return list;
        }

        public static Student[] GenerateStudenter(int antal)
        {
            //List<Student> list = new List<Student>();
            Student[] list = new Student[antal];


            for (int i = 0; i < antal; i++)
            {
                list[i] = RandomStudent();
            }
            return list;
        }

        public static Tentamen[] GenerateTentamina(int antal, Student[] studenter, Kurs[] kurser)
        {
            //List<Tentamen> list = new List<Tentamen>();
            Tentamen[] list = new Tentamen[antal];


            for (int i = 0; i < antal; i++)
            {
                list[i] = RandomTentamen(studenter, kurser);
            }
            return list;
        }


        public static Tentamen RandomTentamen(Student[] studenter, Kurs[] kurser)
        {
            Kurs k = kurser[rand.Next(kurser.Length)];
            Student s = studenter[rand.Next(studenter.Length)];

            Tentamen t = new Tentamen();

            t.kursen = k;
            t.studenten = s;
            t.datum = DateTime.Today;
            t.poäng = rand.Next(1, 60);

            if (t.poäng >= 45)
            {
                t.betyg = "VG";
            }
            else if (t.poäng >= 30)
            {
                t.betyg = "G";
            }
            else
            {
                t.betyg = "U";
            }

            return t;
        }

    }
}
