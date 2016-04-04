using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public struct Person
    {
        private string address;
        private int age;
        private int mobile;
        private string name;
        private Types type;

        public Person(string name, string address, int age, int telephoneNumber, Types type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = telephoneNumber;
            this.type = type;
        }

        public override string ToString()
        {
            return "Name: " + name + " Address: " + address + " Age: " + age + " Mobile: " + mobile + " Type: " + type;
        }
    }

    public enum Types
    {
        Home, Workplace, Mobile
    }

}

