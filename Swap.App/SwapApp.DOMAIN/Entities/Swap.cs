using AlGulumVerGulum.DOMAIN.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
    public class Swap:BaseEntity
    {
        public string Message { get; set; }
        public List<Envelope> Envelopes { get; set; }
        public SwapStatus Status { get; set; }
        public string SenderComment { get; set; }
        public string TargetComment { get; set; }
        public byte SenderPoint { get; set; }
        public byte TargetPoint { get; set; }
    }
}