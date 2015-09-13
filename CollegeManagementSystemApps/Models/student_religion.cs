namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_religion
    {
        public student_religion()
        {
            admission_form = new HashSet<admission_form>();
        }

        [Key]
        public int student_religion_id { get; set; }

        [Required]
        [StringLength(100)]
        public string student_religion_name { get; set; }

        public virtual ICollection<admission_form> admission_form { get; set; }
    }
}
