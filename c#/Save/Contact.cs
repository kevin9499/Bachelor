using System;
using System.Collections.Generic;

namespace Save
{
    [Serializable()]
    public class Contact
    {
        private String name;
        public String Name { get => name; set => name = value; }


        private String number;
        public String Number { get => number; set => number = value; }

        public Contact()
        {

        }
        public Contact(String name, String number)
        {
            this.name = name;
            this.number = number;

        }

        public override string ToString()
        {
            return this.name + " : " + this.number;
        }
    }
}