using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_3_polimorfismo
{
    public static class Helper
    {

        public static bool verificaIdade(int idade)
        {

            if (idade >= 18)
            {

                return true;

            }
            else
            {
                return false;
            }

        }


    }
}
