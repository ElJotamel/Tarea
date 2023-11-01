using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Table("Pedidos")]
public class Pedidos
{
    [Key] 
    public int Id { get; set; }

    public DateTime Fecha { get; set; }
    public string NombreCliente { get; set; }
    public decimal MontoPedido { get; set; }
    public string Distrito { get; set; }
}