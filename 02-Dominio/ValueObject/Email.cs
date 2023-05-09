﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Email
    {
        private String valor;

        public Email(String valor)
        {
            this.DebeTenerSintaxisValida();
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeTenerSintaxisValida()
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            if (regex.IsMatch(this.valor))
            {
                throw new Exception("El email no es válido");
            }
        }
    }
}
