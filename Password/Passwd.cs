using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class Passwd {
        public int ValidatePassword(string passwd)
        {
            int ball = 0;


            if (passwd.Any(char.IsDigit))
                ball++;


            if (passwd.Any(char.IsLower))
                ball++;


            if (passwd.Any(char.IsUpper))
                ball++;


            if (passwd.Any(ch => !char.IsLetterOrDigit(ch)))
                ball++;


            if (passwd.Length > 10)
                ball++;

            return ball;
        }
    }
}
