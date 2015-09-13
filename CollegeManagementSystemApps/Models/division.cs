namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("division")]
    public partial class division
    {
        public division()
        {
            districts = new HashSet<district>();
        }

        [Key]
        public int division_id { get; set; }

        [Required]
        [StringLength(30)]
        public string division_name { get; set; }

        public virtual ICollection<district> districts { get; set; }
    }
}
