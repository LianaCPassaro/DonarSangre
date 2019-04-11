namespace aspnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Donor")]
    public partial class Donor
    {
        public int DonorId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name_Don { get; set; }

        [Required]
        [StringLength(255)]
        public string Last_Name_Don { get; set; }

        public int CityId { get; set; }

        public int ZipCode { get; set; }

        public DateTime? Last_Date_Blood_Extract { get; set; }

        public int GroupId { get; set; }

        public int FactorId { get; set; }

        public virtual Blood_Factor Blood_Factor { get; set; }

        public virtual Blood_Group Blood_Group { get; set; }

        public virtual City City { get; set; }
    }
}
