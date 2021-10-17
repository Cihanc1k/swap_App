using System;
using System.Collections.Generic;
using System.Text;

namespace AlGulumVerGulum.DOMAIN.Constants
{
   
    public enum RequestStatus
    {
        Waiting,Accepted,Denied
    }

    public enum SwapStatus
    {
        Request,DeniedRequest,Waiting,Canceled,Success
    }
}
