namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class subject_category
    {
        public subject_category()
        {
            subjects = new HashSet<subject>();
        }

        [Key]
        public int subject_category_id { get; set; }

        public int group_id { get; set; }

        [Required]
        [StringLength(100)]
        public string subject_category_name { get; set; }

        public virtual group_name group_name { get; set; }

        public virtual ICollection<subject> subjects { get; set; }
    }
}
