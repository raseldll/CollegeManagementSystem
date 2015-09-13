namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student_info
    {
        public student_info()
        {
            results = new HashSet<result>();
        }

        [Key]
        public int student_id { get; set; }

        [Required]
        [StringLength(100)]
        public string student_full_name { get; set; }

        [Required]
        [StringLength(100)]
        public string student_father_name { get; set; }

        [Required]
        [StringLength(100)]
        public string student_mother_name { get; set; }

        [Required]
        [StringLength(50)]
        public string student_father_mobile_number { get; set; }

        [Required]
        [StringLength(200)]
        public string student_address { get; set; }

        [Required]
        [StringLength(50)]
        public string student_mobile_number { get; set; }

        [Required]
        [StringLength(50)]
        public string student_email { get; set; }

        public int student_group_id { get; set; }

        [Required]
        [StringLength(255)]
        public string student_image { get; set; }

        [Column(TypeName = "date")]
        public DateTime student_dob { get; set; }

        [Required]
        [StringLength(50)]
        public string student_session { get; set; }

        [Column(TypeName = "date")]
        public DateTime student_passing_year { get; set; }

        [Required]
        [StringLength(50)]
        public string student_hsc_roll { get; set; }

        [Required]
        [StringLength(50)]
        public string student_hsc_registration_no { get; set; }

        public bool student_active { get; set; }

        public virtual ICollection<result> results { get; set; }
    }
}
