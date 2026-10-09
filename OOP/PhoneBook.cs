using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal struct PhoneBook
    {
        string[] numbers;
        string[] names;


        //int size; //Capacity of phone book
        //[max number of elements can be saved in phonebook]
        //public int Size { get { return size; } }
        public int Size { get; private set; }


        //int count;  //number of current elements in phonebook
        //public int Count { get { return count; } }
        //public int Count { get; private set; }
        public int Count
        {
            get
            {
                int counter = 0;
                foreach (string number in numbers)
                {
                    if (number is not null)
                        counter++;
                }
                return counter;
            }
        }

        ///clr will generate a default constructor 
        ///that will initialize the attributes with their default values

        //Constructor Chaining : 
        ///calling one constructor from another constructor in the same Struct or Class
        public PhoneBook() : this(0) //=> refer to anthor constructor that take one parameter
        {
            //size = default;
            //numbers = default; //=> null
            //names = default;   //=> null
            //numbers = new string[10];
            //names = new string[10];
        }

        public PhoneBook(int _size)
        {
            //Count = 0;
            Size = _size < 3 ? 3 : _size;
            numbers = new string[Size];
            names = new string[Size];
        }

        public void AddContact(string name, string number/*, int _postion*/)
        {
            //if (_postion < 0 || _postion >= Size)
            //{
            //    Console.WriteLine("the postion you select is out of range");
            //    return;
            //}
            //names[_postion] = name;
            //numbers[_postion] = number;
            //Count++;
            int index = Array.IndexOf(names, null);
            if (index == -1)
            {
                //Console.WriteLine("Phone book is full");
                //return;
                this.Resize();
                index = Count;
            }
            names[index] = name;
            numbers[index] = number;

        }

        public void RemoveContact(string name)
        {
            int index = Array.IndexOf(names, name);
            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }

            numbers[index] = null;
            names[index] = null;
        }

        public string GetNumber(string _name)
        {
            int index = Array.IndexOf(names, _name);
            if (index == -1)
            {
                return "Contact not found";
            }
            return numbers[index];
        }
        public void SetNumber(string _name, string _number)
        {
            int index = Array.IndexOf(names, _name);
            if (index == -1)
            {
                Console.WriteLine("Contact not found");
                return;
            }
            numbers[index] = _number;
        }

        // indexer for number by name
        /// indexer is a special type of property 
        /// that allows you to access elements in a collection 
        public string this[string _name]
        {
            get
            {
                int index = Array.IndexOf(names, _name);
                if (index == -1)
                {
                    return "Contact not found";
                }
                return numbers[index];
            }
            set
            {
                int index = Array.IndexOf(names, _name);
                if (index == -1)
                {
                    Console.WriteLine("Contact not found");
                    return;
                }
                numbers[index] = value;
            }
        }

        public string this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    Console.WriteLine("out of range");
                    return string.Empty;
                }
                return $"{names[i]} => {numbers[i]}";
            }
        }

        private void Resize()
        {
            Size *= 2;
            string[] newnumbers = new string[Size];
            string[] newnames = new string[Size];

            numbers.CopyTo(newnumbers, 0);
            names.CopyTo(newnames, 0);

            numbers = newnumbers;
            names = newnames;
        }
    }
}
