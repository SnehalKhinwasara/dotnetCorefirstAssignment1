using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_App.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }

        private int ContactNo;

        public void SetContatcNo(int no)
        {
            ContactNo = no;
        }
        public int GetContactNo()
        {
            return ContactNo;
        }

        private int Income;


        public void SetIncome(int inc)
        {
            Income = inc;
        }
        public int GetIncome()
        {
            return Income;
        }
    }

}
