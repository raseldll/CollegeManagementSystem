namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class group_name
    {
        public group_name()
        {
            subject_category = new HashSet<subject_category>();
        }

        [Key]
        public int group_id { get; set; }

        [Column("group_name")]
        [Required]
        [StringLength(100)]
        public string group_name1 { get; set; }

        public virtual ICollection<subject_category> subject_category { get; set; }
    }
}
