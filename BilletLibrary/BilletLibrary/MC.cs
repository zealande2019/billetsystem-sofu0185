using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        /// <summary>
        /// Motercyklens nummerplade
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// Hvornår motercyklen kørte over broen
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        public decimal Pris() => 125;
        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public string Køretøj() => "MC";
    }
}
