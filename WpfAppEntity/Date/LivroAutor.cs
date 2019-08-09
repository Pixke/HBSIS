namespace WpfAppEntity.Date
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LivroAutor")]
    public partial class LivroAutor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? Livro { get; set; }

        public int Autor { get; set; }

        public virtual Autores Autores { get; set; }

        public virtual Livros Livros { get; set; }
    }
}
