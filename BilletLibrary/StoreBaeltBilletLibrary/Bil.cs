using System;

namespace StoreBaeltBilletLibrary
{
    public class Bil : BilletLibrary.Bil
    {
        /// <summary>
        /// Initialiserer et nyt instans af <see cref="Bil"/> klassen
        /// </summary>
        public Bil() { }

        /// <summary>
        /// Initialiserer et nyt instans af <see cref="Bil"/> klassen med en nummerplade og en dato
        /// </summary>
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato) { }

        /// <summary>
        /// Prisen for at krydse broen, 20% rabat hvis der er weekend
        /// </summary>
        /// <returns></returns>
        protected override decimal NormalPris()
        {
            bool skalHaveRabat;
            switch (this.Dato.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    skalHaveRabat = true;
                    break;
                default:
                    skalHaveRabat = false;
                    break;
            }
            
            decimal pris = base.NormalPris();
            if (skalHaveRabat)
                pris -= pris * 0.20M;
            return pris;
        }
    }
}
