using System;

namespace BilletLibrary
{
    /// <summary>
    /// Repræsentere en basal bil i systemet
    /// </summary>
    public class Bil : Køretøj
    {
        /// <summary>
        /// Initialiserer et nyt instans af <see cref="Bil"/> klassen
        /// </summary>
        public Bil() { }

        /// <summary>
        /// Initialiserer et nyt instans af <see cref="Bil"/> klassen med en nummerplade og en dato
        /// </summary>
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato) {}

        /// <summary>
        /// Prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        protected override decimal SpecifikPris() => 240;

        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType() => "Bil";

    }
}
