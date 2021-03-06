﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace databaseConn
{
    class PreviousVisit
    {
        private int numChildren;
        private int numAdults;
        private DateTime date = new DateTime();
        
        public PreviousVisit()
        {
            DateTime d=new DateTime ();
            setPreviousVisit(0,0,d);
        }

        public PreviousVisit(int numC, int numA, DateTime d)
        {
            setPreviousVisit(numC, numA, d);
        }

        public int NumChildren
        {
            set { numChildren = value; }
            get { return numChildren; }
        }

        public int NumAdults
        {
            set { numAdults = value; }
            get { return numAdults; }
        }

        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }

        public void setPreviousVisit(int numC, int numA, DateTime d)
        {
            this.numAdults = numA;
            this.numChildren = numC;
            this.date = d;
        }
    }

    
}
