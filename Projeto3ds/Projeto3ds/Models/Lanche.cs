using System.Globalization;
using System.Reflection;

namespace Projeto3ds.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        // Virtual pois pertence a outra classe 
        public virtual Categoria CategoriaId { get; set; }

        public string DescrCurta { get; set; }

        public string DescrDetalhada { get; set; }

        public string Nome { get; set; }

        public string LanchePreferido { get; set; }

        // Virtual pois pertence a outra classe 
        // PROPRIEDADE DE NAVEGAÇÃO 
        public virtual Categoria Categoria { get; set; }

        public string ImgMini { get; set; }

        public string ImgUrl { get; set; }
        public decimal Preco { get; set; }
        public bool EmEstoque { get; set; }


    }

}
