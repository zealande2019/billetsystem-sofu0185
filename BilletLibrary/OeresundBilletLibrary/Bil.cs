using System;

namespace OeresundBilletLibrary
{
    public class Bil : BilletLibrary.Køretøj
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
        /// Prisen for hvor meget det koster at krydse broen
        /// </summary>
        /// <param name="hasBrobizz">Indikerer om køretøjet har en brobizz</param>
        /// <returns></returns>
        public override decimal Pris() => HasBrobizz ? 161 : NormalPris();

        /// <summary>
        /// Normal prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        protected override decimal NormalPris() => 410M;

        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType() => "Øresund Bil";
    }
}
