using System;

namespace BilletLibrary
{
    /// <summary>
    /// Repræsentere en basal bil i systemet
    /// </summary>
    public class Bil : Køretøj
    {
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
