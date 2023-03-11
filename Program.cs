using System;
using System.Collections.Generic;

namespace CollectionsHashkey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> subjects = new HashSet<string>();
            subjects.Add("CIT");
            subjects.Add("ENG");
            subjects.Add("PSY");
            subjects.Add("BIO");
            subjects.Add("ACC");

            HashSet<string> offersOnline = new HashSet<string>();
            offersOnline.Add("ACC");
            offersOnline.Add("ART");
            offersOnline.Add("BIO");
            offersOnline.Add("PHL");
            offersOnline.Add("MTH");

            HashSet<string> offersInperson = new HashSet<string>();
            offersInperson.Add("ACC");
            offersInperson.Add("BIO");
            offersInperson.Add("AST");
            offersInperson.Add("AVF");
            offersInperson.Add("CUL");

            Console.WriteLine("These subjects offer online options: ");
            subjects.UnionWith(offersOnline);
            foreach (string subject in subjects) 
            {
                Console.WriteLine(subject);
            }
            Console.WriteLine();

            Console.WriteLine("These subjects offer in persion options: ");
            HashSet<string> inPerson = new HashSet<string>();
            inPerson = subjects;
            inPerson.IntersectWith(offersInperson);
            foreach (string person in inPerson) 
            { 
                Console.WriteLine(person);
            }

        }
    }
}