using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class elsuma
    {
        //campo propiedades, como es
        private int n1;
        private int n2;

      /*  public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }
       
        /* private double n1; 
         * private double n2;*/



        //constructor
          public elsuma(int n1, int n2)
          {
              this.n1 = n1;
              this.n2 = n2;
          }

          //metodo, accion, lo que hace
          public int sumar()
          {
              return (n1 + n2);
          }

          public double meno()
          {
              return (n1 - n2);
          }
          public double dividir()
          {
              return (n1 / n2);
          }
          public double multi()
          {
              return (n1 * n2);
          }
    }
}
