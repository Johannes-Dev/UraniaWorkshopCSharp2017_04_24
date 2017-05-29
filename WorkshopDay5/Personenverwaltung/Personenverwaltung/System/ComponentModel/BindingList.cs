using System.Collections.Generic;
using Personenverwaltung;

namespace System.ComponentModel
{
    internal class BindingList
    {
        private List<Person> list;

        public BindingList(List<Person> list)
        {
            this.list = list;
        }
    }
}