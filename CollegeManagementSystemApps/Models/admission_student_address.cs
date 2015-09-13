namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class admission_student_address
    {
        public admission_student_address()
        {
            admission_form = new HashSet<admission_form>();
        }

        [Key]
        public int student_address_id { get; set; }

        public int admission_student_id { get; set; }

        [Required]
        [StringLength(50)]
        public string parmanent_village { get; set; }

        [Required]
        [StringLength(50)]
        public string parmanent_post { get; set; }

        [Required]
        [StringLength(50)]
        public string parmanent_post_code { get; set; }

        public int parmanent_sub_district_id { get; set; }

        public int present_sub_district_id { get; set; }

        [Required]
        [StringLength(50)]
        public string present_village { get; set; }

        [Required]
        [StringLength(50)]
        public string present_post { get; set; }

        [Required]
        [StringLength(50)]
        public string present_post_code { get; set; }

        [Required]
        [StringLength(20)]
        public string mobile_number { get; set; }

        public virtual ICollection<admission_form> admission_form { get; set; }

        public virtual sub_district sub_district { get; set; }

        public virtual sub_district sub_district1 { get; set; }
    }
}
