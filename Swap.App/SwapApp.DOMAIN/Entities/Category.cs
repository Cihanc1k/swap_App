using System;
using System.Collections.Generic;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
    public class Category : BaseEntity
    {
        // 50
        public string Name { get; set; }
        // MAX
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public List<Notice> Notices { get; set; }
    }
}
