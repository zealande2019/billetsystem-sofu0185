using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        private string _nummerplade;

        /// <summary>
        /// Køretøjets _nummerplade
        /// </summary>
        public string Nummerplade
        {
            get => _nummerplade;
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("Nummerplade kan ikke være længere end 7 tegn.");
                _nummerplade = value;
            }
        }
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
