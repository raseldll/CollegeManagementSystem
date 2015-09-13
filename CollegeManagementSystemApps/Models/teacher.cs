namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("teacher")]
    public partial class teacher
    {
        [Key]
        public int teacher_id { get; set; }

        [Required]
        [StringLength(200)]
        public string teacher_full_name { get; set; }

        [Required]
        [StringLength(50)]
        public string teacher_degination { get; set; }

        [Required]
        [StringLength(200)]
        public string teacher_eduaction { get; set; }

        [Required]
        [StringLength(255)]
        public string teacher_image { get; set; }

        [Column(TypeName = "date")]
        public DateTime teacher_join_date { get; set; }

        public int teacher_group_id { get; set; }

        public bool teacher_active { get; set; }

        [Required]
        [StringLength(200)]
        public string teacher_address { get; set; }

        [Required]
        [StringLength(20)]
        public string teacher_mobile_number { get; set; }

        [Required]
        [StringLength(50)]
        public string teacher_email { get; set; }

        public virtual teacher_group teacher_group { get; set; }
    }
}
