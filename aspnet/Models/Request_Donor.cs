namespace aspnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Request_Donor
    {
        [Key]
        public int RequestDonorId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name_Request_Don { get; set; }

        [Required]
        [StringLength(255)]
        public string Last_Name_Request_Don { get; set; }

        public int CityId { get; set; }

        public int ZipCode { get; set; }

        public DateTime Last_Date_Replacement { get; set; }

        public int AmountDonor { get; set; }

        public int InstitutionId { get; set; }

        public int GroupId { get; set; }

        public int FactorId { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(20)]
        public string Phone_Number { get; set; }

        public virtual Blood_Factor Blood_Factor { get; set; }

        public virtual Blood_Group Blood_Group { get; set; }

        public virtual City City { get; set; }

        public virtual Institution Institution { get; set; }
    }
}
