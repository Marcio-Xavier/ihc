using colorcom.Models.Localizacao;
using colorcom.Models.NotaFiscal;
using colorcom.Models.Pedidos;
using colorcom.Models.Usuario;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace colorcom.Models.Emitente
{
    [Table("emitente")]
    public class emitente
    {
        //TABELA
        [Key]
        public int em_cod { get; set; }

        [MaxLength(100)]
        public string em_nome { get; set; }

        [MaxLength(100)]
        public string em_nomeFantasia { get; set; }

        [MaxLength(18)]
        [Index(IsUnique = true)]
        public string em_documento { get; set; }

        [MaxLength(100)]
        public string em_endereco { get; set; }

        [MaxLength(14)]
        public string em_telefone { get; set; }

        [MaxLength(14)]
        public string em_celular { get; set; }

        [MaxLength(100)]
        public string em_email { get; set; }

        public bool em_status { get; set; }

        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string em_inscricaoEstadual { get; set; }

        [Required]
        public int em_te_cod { get; set; }

        [Required]
        public int em_ci_cod { get; set; }

        //OBJETOS
        public cidade cidade { get; set; }

        public tipoEmitente tipoEmitente { get; set; }

        public ICollection<pedido> pedidos { get; set; }

        public ICollection<entradaNF> entradasNF { get; set; }
    }
}