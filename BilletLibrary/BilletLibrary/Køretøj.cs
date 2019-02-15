using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        /// <summary>
        /// Køretøjets nummerplade
        /// </summary>
        public string Nummerplade { get; set; }
        /// <summary>
        /// Hvornår køretøjet kørte over broen
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();
        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public abstract string KøretøjType();
    }
}
