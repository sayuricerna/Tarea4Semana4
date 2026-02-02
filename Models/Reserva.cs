using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace Tarea4Semana4.Models;

[Table("Reserva")]
public partial class Reserva
{
    [Key]
    public int ReservaId { get; set; }

    public int ServicioId { get; set; }

    public int ClienteId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }

    [StringLength(500)]
    public string? Comentario { get; set; }

    [Column(TypeName = "decimal(2, 1)")]
    public decimal? Calificacion { get; set; }

    [StringLength(50)]
    public string? MetodoPago { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Total { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaReserva { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Reservas")]
    [ValidateNever]
    public virtual Cliente Cliente { get; set; } = null!;

    [InverseProperty("Reserva")]
    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    [ForeignKey("ServicioId")]
    [InverseProperty("Reservas")]
    [ValidateNever]
    public virtual Servicio Servicio { get; set; } = null!;
}
