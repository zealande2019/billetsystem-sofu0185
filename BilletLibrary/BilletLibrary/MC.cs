﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        /// <summary>
        /// Prisen for at krydse broen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris() => 125;
        /// <summary>
        /// Retunere køretøjets type
        /// </summary>
        /// <returns></returns>
        public override string KøretøjType() => "MC";
    }
}
