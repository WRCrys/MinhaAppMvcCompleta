using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCA.Business.Models
{
    public class Fornecedor : Entity
    {

        public string Nome { get; set; }

        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor { get; set; }

        public Endereco Endereco { get; set; }

        public bool Ativo { get; set; }

        /* EF Relations */

        public IEnumerable<Produto> Produtos { get; set; }
    }
}
