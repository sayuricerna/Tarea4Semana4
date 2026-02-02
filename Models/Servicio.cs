using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace Tarea4Semana4.Models;

[Table("Servicio")]
public partial class Servicio
{
    [Key]
    public int ServicioId { get; set; }

    public int ProfesionalId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Precio { get; set; }

    public int Duracion { get; set; }

    [StringLength(50)]
    public string? Categoria { get; set; }

    public bool? Disponible { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "decimal(2, 1)")]
    public decimal? Rating { get; set; }

    [ForeignKey("ProfesionalId")]
    [InverseProperty("Servicios")]
    [ValidateNever]
    public virtual Profesional Profesional { get; set; } = null!;

    [InverseProperty("Servicio")]
    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
