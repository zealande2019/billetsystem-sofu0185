using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Repræsentere en basal Motorcykel i systemet
    /// </summary>
    public class MC : Køretøj
    {
        /// <summary>
        /// Initialiserer et nyt instans af <see cref="MC"/> klassen
        /// </summary>
        public MC() {}

        /// <summary>
        /// Initialiserer et nyt instans af <see cref="MC"/> klassen med en nummerplade og en dato
        /// </summary>
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato) { }

        /// <summary>
        /// Prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        protected override decimal SpecifikPris() => 125;
        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType() => "MC";
    }
}
