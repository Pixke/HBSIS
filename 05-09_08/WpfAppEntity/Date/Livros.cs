namespace WpfAppEntity.Date
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Livros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livros()
        {
            LivroAutor = new HashSet<LivroAutor>();
            Locacao = new HashSet<Locacao>();
        }

        public int Id { get; set; }

        public int Registro { get; set; }

        [Required]
        [StringLength(1200)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(15)]
        public string ISBN { get; set; }

        public int Genero { get; set; }

        public int Editora { get; set; }

        [Required]
        public string Sinopse { get; set; }

        [StringLength(1000)]
        public string Observacoes { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }

        public virtual Editora Editora1 { get; set; }

        public virtual Generos Generos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LivroAutor> LivroAutor { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Usuario Usuario1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacao> Locacao { get; set; }
    }
}
