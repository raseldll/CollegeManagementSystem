namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_department
    {
        [Key]
        public int student_department_id { get; set; }

        [Required]
        [StringLength(100)]
        public string student_department_name { get; set; }
    }
}
