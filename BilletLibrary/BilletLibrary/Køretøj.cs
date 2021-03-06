﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Repræsentere et generalt køretøj som kryder en bro
    /// </summary>
    public abstract class Køretøj
    {
        private string _nummerplade;

        /// <summary>
        /// Indikerer om køretøjet har en brobizz
        /// </summary>
        public bool HasBrobizz { get; set; }

        /// <summary>
        /// Initialiserer et nyt instans af <see cref="Køretøj"/> klassen
        /// </summary>
        public Køretøj() {}

        /// <summary>
        /// Initialiserer et nyt instans af <see cref="Køretøj"/> klassen med en nummerplade og en dato
        /// </summary>
        public Køretøj(string nummerplade, DateTime dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

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
        /// Prisen for hvor meget det koster at krydse broen
        /// </summary>
        /// <returns></returns>
        public virtual decimal Pris()
        {
            decimal rabat = 0;
            if (HasBrobizz)
                rabat = NormalPris() * 0.05M;
            return NormalPris() - rabat;
        }

        /// <summary>
        /// Køretøjets specifike pris for at krydse broen
        /// </summary>
        /// <returns></returns>
        protected abstract decimal NormalPris();
        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public abstract string KøretøjType();
    }
}
