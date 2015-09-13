namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sub_district
    {
        public sub_district()
        {
            admission_student_address = new HashSet<admission_student_address>();
            admission_student_address1 = new HashSet<admission_student_address>();
        }

        [Key]
        public int sub_district_id { get; set; }

        [Required]
        [StringLength(40)]
        public string sub_district_name { get; set; }

        public int district_id { get; set; }

        public virtual ICollection<admission_student_address> admission_student_address { get; set; }

        public virtual ICollection<admission_student_address> admission_student_address1 { get; set; }

        public virtual district district { get; set; }
    }
}
