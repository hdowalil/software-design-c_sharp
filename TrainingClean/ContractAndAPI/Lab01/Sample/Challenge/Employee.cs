using System;
using System.Collections.Generic;
using System.Text;

namespace ContractAndAPI.Lab01.Sample.Challenge
{
    class Employee
    {
        public string Name { get; private set; }

        public Employee(String name)
        {
            this.Name = name;
        }

        public Employee ChangeName (String newName)
        {
            return new Employee(newName);
        }

    }
}
