using System;
using System.Collections.Generic;
using System.Text;

namespace Yazilim129.CORE.Utility
{
    public static class Extensions
    {
        // Recursive Method

        // ex.ToInnestException()
        // ex2.ToInnestEx()
        // ex3.ToInnestEx()

        // ex.Innerexception.ToInnest()
        // ex.Inner.Inner.ToInnest()
        // ex.Inner.Inner.Inner.ToInnest()
        // ex.Inner.Inner.Inner.Inner;
        public static Exception ToInnestException(this Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return ex.InnerException.ToInnestException();
        }

        // 5
        // 5*Fakt(4)
        // 5*4*fakt(3)
        // 5*4*3*fakt(2)
        // 5*4*3*2*fakt(1)
        // 5*4*3*2*1*1

        // int faktoriyel = fakt(5);
        // int faktoriyel = 5*4*3*2*1*1;

        // stringDon()

        //public static int Fakt(this int sayi)
        //{
        //    if (sayi==0)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return sayi * Fakt(sayi - 1);
        //    }
        //}
    }
}
