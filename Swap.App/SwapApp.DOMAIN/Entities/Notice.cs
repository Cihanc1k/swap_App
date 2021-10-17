using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.DOMAIN.Entities
{
    public class Notice : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public AppUser Owner { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Picture> Pictures { get; set; }
        [NotMapped]
        public List<Request> Requests { get; set; }
    }
}
