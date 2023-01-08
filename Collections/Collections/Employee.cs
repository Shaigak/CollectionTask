using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
//Employee tipinden ibaret listiniz olacaq. 
//Employee classinin icinde Name, Surname, Birthday, Salary propertileri olacaq.
//Employelerin icinden metoda iki verqli tarix ve salary gelir. 
//Dogum gunu hemin tarixler arasinda olan ve maashi 2000 - den boyuk olan ishcilerin sayini gosteren method yazin.
{
    public class Employee
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime Birhday { get; set; }

        public int Salary { get; set; }

    }
}
