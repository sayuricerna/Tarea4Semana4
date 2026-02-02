using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace Tarea4Semana4.Models;

[Table("Pago")]
public partial class Pago
{
    [Key]
    public int PagoId { get; set; }

    public int ReservaId { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Monto { get; set; }

    [StringLength(50)]
    public string? MetodoPago { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPago { get; set; }

    [StringLength(50)]
    public string? Estado { get; set; }

    [StringLength(200)]
    public string? Comprobante { get; set; }

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [StringLength(50)]
    public string? Factura { get; set; }

    [StringLength(200)]
    public string? Comentario { get; set; }

    [ForeignKey("ReservaId")]
    [InverseProperty("Pagos")]
    [ValidateNever]
    public virtual Reserva Reserva { get; set; } = null!;
}
