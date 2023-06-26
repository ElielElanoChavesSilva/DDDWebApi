namespace Domain.Models;

public class Produto : Base
{
    public string? Nome { get; set; }
    public decimal Valor { get; set; }
    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }
}
