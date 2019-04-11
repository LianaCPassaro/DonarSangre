namespace aspnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Institution")]
    public partial class Institution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Institution()
        {
            Request_Donor = new HashSet<Request_Donor>();
        }

        public int InstitutionId { get; set; }

        [Required]
        [StringLength(255)]
        public string InstitutionDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string InstitutionAdress { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        public int ZipCode { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request_Donor> Request_Donor { get; set; }
    }
}
