using practica1.Models;
using practica1.Service;

namespace practica1.Bussines
{

    public class Operaciones : IOperaciones

    {
        public double division(Acciones acciones)
        {
            throw new System.NotImplementedException();
        }

        public double multiplicacion(Acciones acciones)
        {
            throw new System.NotImplementedException();
        }

        public double pratica(Acciones acciones)
        {

            return acciones.Dato1 + acciones.Dato2;
        }

        public double resta(Acciones acciones)
        {
            throw new System.NotImplementedException();
        }
    }




}