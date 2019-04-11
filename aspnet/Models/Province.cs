namespace aspnet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Province")]
    public partial class Province
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Province()
        {
            City = new HashSet<City>();
        }

        public int ProvinceId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinceDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> City { get; set; }

        public virtual Province Province1 { get; set; }

        public virtual Province Province2 { get; set; }

        public virtual Province Province11 { get; set; }

        public virtual Province Province3 { get; set; }
    }
}
