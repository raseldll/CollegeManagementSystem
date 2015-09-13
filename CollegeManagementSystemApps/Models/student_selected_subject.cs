namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_selected_subject
    {
        public student_selected_subject()
        {
            results = new HashSet<result>();
        }

        [Key]
        public int student_selected_subject_id { get; set; }

        public int student_id { get; set; }

        public int subject_id { get; set; }

        public virtual ICollection<result> results { get; set; }

        public virtual subject subject { get; set; }
    }
}
