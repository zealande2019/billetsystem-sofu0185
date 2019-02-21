using System;

namespace OeresundBilletLibrary
{
    public class MC : BilletLibrary.Køretøj
    {
        /// <summary>
        /// Initialiserer et nyt instans af <see cref="MC"/> klassen
        /// </summary>
        public MC() { }

        /// <summary>
        /// Initialiserer et nyt instans af <see cref="MC"/> klassen med en nummerplade og en dato
        /// </summary>
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato) { }


        /// <summary>
        /// Prisen for hvor meget det koster at krydse broen
        /// </summary>
        /// <param name="hasBrobizz">Indikerer om køretøjet har en brobizz</param>
        /// <returns></returns>
        public override decimal Pris(bool hasBrobizz = false) => hasBrobizz ? 73 : NormalPris();

        /// <summary>
        /// Normal prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        protected override decimal NormalPris() => 210;

        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType() => "Øresund MC";
    }
}
