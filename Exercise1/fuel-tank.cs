﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Fueltank
    {
        private int capacity;
        private int amount;

        public Fueltank(int capacity)
        {
            this.capacity = capacity;
        }

        public void Fill(int amount)
        {
            if (this.amount + amount > capacity)
            {
                
            }
            else
            {
                this.amount += amount;
            }

        }
        public int GetAmount()
        {
            return amount;
        }
    }
}







