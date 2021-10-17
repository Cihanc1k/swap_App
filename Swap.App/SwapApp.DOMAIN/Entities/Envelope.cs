using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
    public class Envelope : BaseEntity
    {
        public NoticeRole Role { get; set; }
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int NoticeId { get; set; }
        public Notice Notice { get; set; }
        public int? SwapId { get; set; }
        public Swap Swap { get; set; }
    }

    public enum NoticeRole
    {
        Sender=1,Target
    }
}
