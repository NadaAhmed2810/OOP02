using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal struct Person
    {
        #region Properties

        public string? Name { get; set; }
        public int Age { get; set; }
        #endregion
        #region Constructors
        public Person(String? Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Name: {Name}\nAge:{Age}";
        }
        #endregion
    }
}
