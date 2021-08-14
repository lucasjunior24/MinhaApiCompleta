using System;
using System.Collections.Generic;

namespace DevIO.Business.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relation  */

        /// Fornecedor tem muitos produtos
        /// E produto tem apenas um fornecedor
        /// fornecedor tem uma lista de produtos
        /// Relacionamento 1 pra N (Muitos)
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
