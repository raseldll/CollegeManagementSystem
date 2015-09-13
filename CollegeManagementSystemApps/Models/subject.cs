namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("subject")]
    public partial class subject
    {
        public subject()
        {
            student_selected_subject = new HashSet<student_selected_subject>();
        }

        [Key]
        public int subject_id { get; set; }

        public int subject_category_id { get; set; }

        [Required]
        [StringLength(100)]
        public string subject_name { get; set; }

        public virtual ICollection<student_selected_subject> student_selected_subject { get; set; }

        public virtual subject_category subject_category { get; set; }
    }
}
