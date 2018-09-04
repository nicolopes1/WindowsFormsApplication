using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    class Estado
    {
            public int Id { get; set; }
            public string Nome { get; set; }

            public override string ToString()
            {
                return this.Nome;
            }

            public static List<Estado> Lista()
            {
                var lista = new List<Estado>();
                var e1 = new Estado();
                e1.Nome = "SP";
                e1.Id = 1;
                lista.Add(e1);

                e1 = new Estado();
                e1.Nome = "MG";
                e1.Id = 2;
                lista.Add(e1);

                e1 = new Estado();
                e1.Nome = "PR";
                e1.Id = 3;
                lista.Add(e1);

                e1 = new Estado();
                e1.Nome = "GO";
                e1.Id = 4;
                lista.Add(e1);


                List<string> Estados = new List<string>();
                Estados.Add("SP");
                Estados.Add("MG");
                Estados.Add("RJ");
                Estados.Add("GO");

                return lista;
            }
    }
}
