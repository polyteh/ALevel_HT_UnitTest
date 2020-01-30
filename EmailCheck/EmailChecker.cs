using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck
{
    public static class EmailChecker
    {
        public static bool CheckEmail(string email)
        {
            //проверили, что адрес не может быть меньше 4 символов
            if (email.Length<4)
            {
                return false;
            }

            char addresSignCharacter = '@';
            int addressSignFirstIndex = email.IndexOf(addresSignCharacter);

            //проверили, что есть символ @
            if (addressSignFirstIndex==0)
            {
                return false;
            }

            int addressSignLastIndex = email.LastIndexOf(addresSignCharacter);
            //проверили, что есть только один символ @
            if (addressSignFirstIndex != addressSignLastIndex)
            {
                return false;
            }
            int maxDomennameLenght = 3;
            //проверили, что после символа @ не больше 3 символов
            if (email.Length-addressSignLastIndex> maxDomennameLenght)
            {
                return false;
            }

            return true;       
        }
    }
}
