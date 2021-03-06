﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.Lib.Models;

namespace Hastane.Lib.Data
{
    public class Context
    {
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public List<Hasta> Hastalar { get; set; } = new List<Hasta>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();

    }
}
