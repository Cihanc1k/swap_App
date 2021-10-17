using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
    public class Picture : IBaseEntity
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int NoticeId { get; set; }
        public Notice Notice { get; set; }
    }
}
