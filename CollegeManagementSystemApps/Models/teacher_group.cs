namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher_group
    {
        public teacher_group()
        {
            teachers = new HashSet<teacher>();
        }

        [Key]
        public int teacher_group_id { get; set; }

        [Required]
        [StringLength(100)]
        public string teacher_group_name { get; set; }

        public virtual ICollection<teacher> teachers { get; set; }
    }
}
