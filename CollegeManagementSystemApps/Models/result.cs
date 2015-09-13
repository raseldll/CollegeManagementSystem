namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("result")]
    public partial class result
    {
        [Key]
        public int result_id { get; set; }

        public int exam_type_id { get; set; }

        public int student_id { get; set; }

        public int student_selected_subject_id { get; set; }

        public double subject_gpa { get; set; }

        public double gpa { get; set; }

        public virtual exam_type exam_type { get; set; }

        public virtual student_info student_info { get; set; }

        public virtual student_selected_subject student_selected_subject { get; set; }
    }
}
