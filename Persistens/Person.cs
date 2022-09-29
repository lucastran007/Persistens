using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string name;

        public string Name
        {
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Der er opstået en fejl... eller hvad der nu er relevant at skrive her");
                }
                else
                    name = value;
            }
            get { return name; }
        }


        private DateTime birthDate;
        public DateTime BirthDate
        {
            set
            {
                if (value < new DateTime(1900, 1, 1))
                {
                    throw new Exception("Fødselsdatoen for en person må ikke være før 1. januar 1900.");
                }
                else
                    birthDate = value;
            }
            get { return birthDate; }

        }


        private double height;
        public double Height

        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Højden på en person skal være større end 0");
                }
                else

                    height = value;
            }
            get { return height; }
        }



        private bool isMarried;
        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        private int noOfChildren;
        public int NoOfChildren
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("En person må ikke have et negativt antal børn");
                }
                else
                    noOfChildren = value;
            }
            get { return noOfChildren; }
        }


        //Constructor
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Height = height;
            this.IsMarried = isMarried;
            this.NoOfChildren = noOfChildren;
        }

        //MakeTitle
        public string MakeTitle()
        {
            string title;

            title = this.name + ";" + this.birthDate + ";" + this.height + ";" + this.isMarried + ";" + this.noOfChildren;

            return title;
        }
        public Person(string name, DateTime birthDate, double height, bool isMarried) : this(name, birthDate, height, isMarried, 0)
        {
        }
    }
}




