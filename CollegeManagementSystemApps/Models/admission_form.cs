namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admission_form
    {
        [Key]
        public int admission_student_id { get; set; }

        [Required]
        [StringLength(200)]
        public string student_full_name { get; set; }

        [Required]
        [StringLength(200)]
        public string student_father_name { get; set; }

        [Required]
        [StringLength(50)]
        public string student_mother_name { get; set; }

        public int student_address_id { get; set; }

        [Required]
        [StringLength(50)]
        public string father_education { get; set; }

        [Required]
        [StringLength(50)]
        public string mohter_education { get; set; }

        [Required]
        [StringLength(50)]
        public string father_profession { get; set; }

        [Required]
        [StringLength(200)]
        public string student_refarence { get; set; }

        [Column(TypeName = "date")]
        public DateTime student_dob { get; set; }

        [Required]
        [StringLength(10)]
        public string student_blood_group { get; set; }

        [Required]
        [StringLength(30)]
        public string student_nationality { get; set; }

        public int student_religion_id { get; set; }

        [Required]
        [StringLength(50)]
        public string student_exam_name { get; set; }

        public int student_group_id { get; set; }

        public double student_result { get; set; }

        [Column(TypeName = "date")]
        public DateTime student_passing_year { get; set; }

        [Required]
        [StringLength(200)]
        public string student_school_name { get; set; }

        public long student_father_yearly_income { get; set; }

        [Required]
        [StringLength(50)]
        public string student_email { get; set; }

        [Column(TypeName = "date")]
        public DateTime student_apply_date { get; set; }

        [Required]
        [StringLength(255)]
        public string student_image { get; set; }

        [Required]
        [StringLength(50)]
        public string student_ssc_roll { get; set; }

        [Required]
        [StringLength(50)]
        public string student_ssc_registration_no { get; set; }

        public bool student_admission_result { get; set; }

        [Required]
        [StringLength(255)]
        public string student_admission_password { get; set; }

        public virtual admission_student_address admission_student_address { get; set; }

        public virtual student_religion student_religion { get; set; }
    }
}
