using System;
using System.Collections.Generic;
using System.Linq;

namespace BilletLibrary
{
    public class Kunde
    {
        public List<Køretøj> TureOverBroer { get; set; }
        public decimal PrisForAlleTure { get => TureOverBroer.Sum(x => x.Pris()); }

        public Kunde()
        {
            TureOverBroer = new List<Køretøj>();
        }


    }
}
