﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    internal class EdadMayor
    {
        private int valor;

        public EdadMayor(int valor)
        {
            this.DebeSerMayorDeEdad();
            this.valor = valor;
        }
        public int Valor()
        {
            return this.valor;
        }
        private void DebeSerMayorDeEdad()
        {
            if (this.valor < 18)
            {
                throw new Exception("El usuario debe ser mayor a 18 años");
            }
        }
    }
}
