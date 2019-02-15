using System;

namespace BilletLibrary
{
    /// <summary>
    /// Repræsentere en basal bil i systemet
    /// </summary>
    public class Bil
    {
        /// <summary>
        /// Bilens nummerplade
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// Hvornår bilen kørte over broen
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        public decimal Pris() => 240;
        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public string Køretøj() => "Bil";

    }
}
