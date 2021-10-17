using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
   public class Request : BaseEntity
    {
        public RequestStatus Status { get; set; }

        [NotMapped]
        public List<Notice> Notices { get; set; }
    }

    public enum RequestStatus
    {
        Waiting=1,Denied,Accepted
    }
}