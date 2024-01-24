using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace APICatalogo.Models;

public class Categorias
{
    public Categorias()
    {
        Produtos = new Collection<Produto>();
    }

  
    public int CategoriaId { get; set; }

    [Required]
    [MaxLength(80)]
    public string? Nome { get; set; }

    [Required]
    [MaxLength(300)]
    public string ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; }
}
