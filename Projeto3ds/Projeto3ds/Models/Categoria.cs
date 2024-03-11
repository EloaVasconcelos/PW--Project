namespace Projeto3ds.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string CategoriaNome { get; set; }

        public string Descricao { get; set; }

        //Criando um lista para os tipos de lanche 
        // PROPRIEDADE DE NAVEGAÇÃO 
        public List <Lanche> Lanche { get; set; } 

    }
}
