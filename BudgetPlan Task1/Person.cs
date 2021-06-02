using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlan_Task1
{
    class Person
    {

        public string name;
        public string surname;


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }



    }

}
