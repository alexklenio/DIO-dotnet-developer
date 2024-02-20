using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subitrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}