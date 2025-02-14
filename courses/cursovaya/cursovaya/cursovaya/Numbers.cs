﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cursovaya;


namespace cursovaya
{
    public class Numbers<T> : INumbers
    {
        public int Hotelnumber { get; set; }
        Type INumbers.Type => typeof(T);

        public int Codeofnumber { get; set; }
        public int Floor { get; set; }
        public string Status { get; set; }
        public T Price { get; set; }
        public Numbers(int codeOfnumber, int hotelnumber, int floor, string status, T price)
        {
            this.Codeofnumber = codeOfnumber;
            this.Price = price;
            this.Floor = floor;
            this.Status = status;
            this.Hotelnumber = hotelnumber;
        }
        public override string ToString()
        {
            return Price.ToString();
        }
    }
}
