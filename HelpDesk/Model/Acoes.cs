﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Acoes
    {
        public int Id { get; set; }
        public int CodigoUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime Data { get; set; }

    }
}
