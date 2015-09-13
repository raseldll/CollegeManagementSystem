namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("district")]
    public partial class district
    {
        public district()
        {
            sub_district = new HashSet<sub_district>();
        }

        [Key]
        public int district_id { get; set; }

        [Required]
        [StringLength(30)]
        public string district_name { get; set; }

        public int division_id { get; set; }

        public virtual division division { get; set; }

        public virtual ICollection<sub_district> sub_district { get; set; }
    }
}
