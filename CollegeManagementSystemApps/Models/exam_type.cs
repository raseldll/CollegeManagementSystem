namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exam_type
    {
        public exam_type()
        {
            results = new HashSet<result>();
        }

        [Key]
        public int exam_type_id { get; set; }

        [Required]
        [StringLength(100)]
        public string exam_type_name { get; set; }

        public virtual ICollection<result> results { get; set; }
    }
}
