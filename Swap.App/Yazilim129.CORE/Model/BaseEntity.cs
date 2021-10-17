using System;
using System.Collections.Generic;
using System.Text;

namespace Yazilim129.CORE.Model
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}
