using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_proyecto
{
    internal class Nodo
    {
        // Campos privados: 'valor' almacena el dato (un número), y 'sig' guarda la referencia al siguiente nodo.
        private int valor;
        private Nodo sig;

        // Constructor: permite crear un nodo asignando un valor específico. El siguiente nodo (sig) comienza siendo null.
        public Nodo(int valor)
        {
            this.valor = valor;
            sig = null;
        }

        // Propiedades: estas son "getters" y "setters" para acceder o modificar los valores de los campos privados.
        // 'Valor' permite obtener o modificar el valor del nodo.
        public int Valor { get => valor; set => valor = value; }

        // 'Sig' permite acceder o modificar el siguiente nodo.
        internal Nodo Sig { get => sig; set => sig = value; }
    }
}