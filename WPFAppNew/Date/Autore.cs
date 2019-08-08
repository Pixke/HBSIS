namespace WPFAppNew.Date
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Autore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autore()
        {
            LivroAutors = new HashSet<LivroAutor>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(1200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(2000)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LivroAutor> LivroAutors { get; set; }
    }
}
