using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tarea4Semana4.Models;

[Table("Profesional")]
public partial class Profesional
{
    [Key]
    public int ProfesionalId { get; set; }

    [StringLength(20)]
    public string Cedula { get; set; } = null!;

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    public string Apellido { get; set; } = null!;

    [StringLength(100)]
    public string Especialidad { get; set; } = null!;

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [StringLength(20)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [Column(TypeName = "decimal(2, 1)")]
    public decimal? Rating { get; set; }

    [InverseProperty("Profesional")]
    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
