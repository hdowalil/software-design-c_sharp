using System;
using System.Diagnostics.Contracts;

namespace ContractAndAPI.Lab01.Sample.Solution
{
    /// <summary>
    /// Immutable Employee
    /// </summary>
    class Employee
    {
        public readonly string Name;

        public Employee(String name)
        {
            Contract.Requires(name != null);
            Contract.Requires(name.Trim().Length > 0);

            this.Name = name;
        }

        /// <summary>
        /// Will return a new Employee and NOT alter current instance!
        /// So assign return value!
        /// </summary>
        /// <param name="newName">The new Employee´s object instance name</param>
        /// <returns></returns>
        public Employee ChangeName(String newName)
        {
            Contract.Requires(newName != null);
            Contract.Requires(newName.Trim().Length > 0);

            Employee result = new Employee(newName);

            Contract.Ensures(result != null);

            return result;
        }


    }
}
