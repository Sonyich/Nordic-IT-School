using System;
using System.Windows.Markup;

namespace ClassWork10_2
{
    enum petKind
    {
        Mouse,
        Cat,
        Dog
    }

    class Pet
    {
        private string _birthPlace;
        private char _sex;
        private byte _age;

        public petKind Kind;
        public string Name;

        public string PropertyString
        {
            get
            {
                return $"{Name} is a {Kind}({Sex}) of {Age} years old.";
            }
        }

        public void SetBirthPlace(string birthPlace)
        {
            if (birthPlace == null)
            {
                throw new ArgumentNullException(birthPlace);
            }

            if(_birthPlace !=null)
            {
                throw new Exception("Tok 1 raz pishi");
            }    

            _birthPlace = birthPlace;
        }
        
        public char Sex 
        { 
            get 
            {
                return _sex;
            } 

            set 
            {
                if (value == 'M'|| value == 'm'|| value == 'f' || value == 'F')
                {
                    _sex = char.ToUpper(value);
                }

                else
                {
                    throw new Exception("Sex should be one of two options: M/F");
                }
            } 
        }

        public byte Age {
            get 
            {
                return _age;
            }

            set
            {
                if (value>150)
                {
                    throw new Exception("Age should be < 150");
                }
                _age = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet();

            pet1.Age = 7;
            pet1.Kind = petKind.Mouse;
            pet1.Name = "Murzik";
            pet1.Sex = 'M';

            pet1.SetBirthPlace("Kaliningrad");
            //pet1.SetBirthPlace("Kaluga");

            Pet pet2 = new Pet();

            pet2.Age = 13;
            pet2.Kind = petKind.Cat;
            pet2.Name = "Klukva";
            pet2.Sex = 'F';

            Console.WriteLine(pet1.PropertyString);
            Console.WriteLine(pet2.PropertyString);
        }
    }
}
