using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio
{
    public class Nombre
    {
        private String valor;

        public Nombre(String valor)
        {
            this.DebeContenerMasDe4Caracteres();
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeContenerMasDe4Caracteres()
        {
            if (this.valor.Length < 4)
            {
                throw new Exception("El nombre debe contener, al menos, 4 caractreres");
            }
        }
    }
}
