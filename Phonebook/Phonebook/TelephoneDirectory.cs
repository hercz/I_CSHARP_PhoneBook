using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class TelephoneDirectory : IEnumerable
    {
        public List<Person> accounts = new List<Person>(50);
        public TelephoneDirectory()
        {
        }

        public IEnumerator GetEnumerator()
        {
            return  accounts.GetEnumerator();
        }
    }
}
