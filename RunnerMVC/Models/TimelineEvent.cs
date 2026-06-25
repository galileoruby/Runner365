using System.ComponentModel.DataAnnotations;

namespace RunnerMVC.Models
{
    public class TimelineEvent
    {
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Descripcion { get; set; } = string.Empty;

        [StringLength(50)]
        public string? Categoria { get; set; }

        [StringLength(500)]
        public string? ImagenUrl { get; set; }

        [StringLength(500)]
        public string? EnlaceCompleto { get; set; }

        // Etiqueta de categoría para mostrar (ej: "Economía Global", "Ciencia")
        public string EtiquetaCategoria => Categoria ?? "General";
    }
}