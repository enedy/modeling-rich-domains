using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects
{
    public class AssertionConcern
    {
        public static void ValidarSeIgual(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
                throw new DomainException(message);
        }

        public static void ValidarSeVazio(string valor, string message)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeMenorIgualMinimo(decimal valor, decimal minimo, string message)
        {
            if (valor < minimo)
            {
                throw new DomainException(message);
            }
        }
    }
}
