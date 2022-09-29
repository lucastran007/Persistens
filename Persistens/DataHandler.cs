using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Persistens
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }

        public DataHandler (string dataFileName)
        {
            this.dataFileName = dataFileName;
        }


        public void SavePerson(Person person)
        {
            using (StreamWriter sw = new StreamWriter(dataFileName))
            {
                sw.WriteLine(person.MakeTitle());

                
            }
        }

        public Person LoadPerson()
        {

            using (StreamReader sr = new StreamReader(dataFileName))
            {
                string text = sr.ReadLine();

                string[] array = text.Split(';');

                Person person = new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));

               
                return person;
            }
        }

        public void SavePerson(Person [] persons)
        {
            using (StreamWriter sw = new StreamWriter(dataFileName))
            {

                for (int i = 0; i < persons.Length; i++)
                {

                    sw.WriteLine(persons[i].MakeTitle());
                }
             
            }

        }
        public Person[] LoadPersons()
        {

            using (StreamReader sr = new StreamReader(dataFileName))

            {
                string text;
                Person[] persons = new Person[10];
                int count = 0;


                while ((text = sr.ReadLine()) != null)
                {
                    string[] array = text.Split(';', StringSplitOptions.RemoveEmptyEntries); //Remove ";"

                    //Declare person
                    persons[count] = new Person(array[0], DateTime.Parse(array[1]), double.Parse(array[2]), bool.Parse(array[3]), int.Parse(array[4]));
                    count++;
                }
                return persons;

            }
        }

    }
}
