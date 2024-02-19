using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using ProSoft.Pages;


namespace ProSoft.Data
{
#nullable disable
    public class Contexto : DbContext
    {
        string _connectionString = "Server=127.0.0.1;Database=ProSoftWeb;Uid=root;Pwd=root";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");
                if (string.IsNullOrEmpty(connectionString))
                    connectionString = _connectionString;

               // var connection = new MySqlConnector.MySqlConnection(connectionString);
                optionsBuilder.UseMySQL(connectionString);
                optionsBuilder.EnableDetailedErrors(true);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<cliente> clientes { get; set; }
        public DbSet<mercadoria> mercadorias { get; set; }
        public DbSet<equipamento> equipamentos { get; set; }
        public DbSet<ordemdeservico> ordensdeservico { get; set; }
        public DbSet<orcamento> orcamentos { get; set; }
        public DbSet<itemdoorcamento> itemsdoorcamento { get; set; }
        public DbSet<funcionario> funcionarios { get; set; }
        public DbSet<compra> compras { get; set; }
        public DbSet<venda> vendas { get; set; }
        public DbSet<notacompra> notascompra { get; set; }
        public DbSet<notavenda> notasvenda { get; set; }
        public DbSet<fornecedor> fornecedores { get; set; }
        public DbSet<contaapagar> contasapagar { get; set; }
        public DbSet<contaareceber> contasareceber { get; set; }
        public DbSet<caixa> caixas { get; set; }
        public DbSet<pagamento> pagamentos { get; set; }
    }

    public class iendereco
    {
        public string Endereco_logradouro;
        public int Endereco_numero;
        public string Endereco_complemento;
        public string Endereco_bairro;
        public string Endereco_cidade;
        public string Endereco_cep;
        public string Endereco_uf;
    }

    public class cliente: iendereco
    {
#nullable disable
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long idCliente { get; set; }
        public string Nome { get; set; }
        public string Endereco_logradouro { get; set; }
        public int Endereco_numero { get; set; } = 0;
        public string Endereco_complemento { get; set; }
        public string Endereco_bairro { get; set; }
        public string Endereco_cidade { get; set; }
        public string Endereco_cep { get; set; }
        public string Endereco_uf { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefones { get; set; }
        public string Email { get; set; }
        public virtual ICollection<equipamento> Equipamentos { get; set; } = new HashSet<equipamento>();
        public virtual ICollection<notavenda> Compras { get; set; } = new HashSet<notavenda>();
        public virtual ICollection<orcamento> Orcamentos { get; set; } = new HashSet<orcamento>();
        public virtual ICollection<pagamento> Pagamentos { get; set; } = new HashSet<pagamento>();
        public override string ToString()
        {
            return Nome;
        }
        public static cliente GetOrCreateByDescription(Contexto contexto, string description)
        {
            // name cant be null, must have at least 10char and must have at least two words
            if (string.IsNullOrEmpty(description) || description.Length < 10 || !description.Contains(' '))
                return null;

            cliente c = null;

            if (description.Contains('|'))
            {
                string[] splits = description.Split('|');
                long idcli = -1;
                if (long.TryParse(splits[0], out idcli))
                {
                    c = contexto.clientes.Find(idcli);
                    if (c == null)
                        return c;
                }
            }
            else
            {
                c = contexto.clientes.FirstOrDefault(k => k.Nome == description);
                if (c != null)
                    return c;
            }


            c = new cliente();
            c.Nome = description;

            return c;

        }
    }

    public class equipamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdEquipamento { get; set; }
        public string Descricao { get; set; }
        public string Observacoes { get; set; }

        public long Cliente_IdCliente { get; set; }
        [ForeignKey(nameof(Cliente_IdCliente))]
        public virtual cliente Cliente { get; set; }

        public virtual ICollection<ordemdeservico> Servicos { get; set; } = new HashSet<ordemdeservico>();
        public static equipamento GetOrCreateFromDescription(Contexto contexto, long idCliente, string description)
        {
            equipamento eqp = contexto.equipamentos.FirstOrDefault(k => k.Descricao == description && k.Cliente_IdCliente == idCliente);
            if (eqp == null)
            {
                eqp = new equipamento();
                eqp.Descricao = description;
            }
            return eqp;
        }
    }

    public class funcionario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdFuncionario { get; set; }
        public string Nome { get; set; }
        public bool IsSystemUser { get; set; }
        public string Senha { get; set; }
        [InverseProperty("FuncionarioEnt")]
        public virtual ICollection<ordemdeservico> OrdensDeServicoQueRecebeu { get; set; } = new HashSet<ordemdeservico>();
        [InverseProperty("FuncionarioOrc")]
        public virtual ICollection<ordemdeservico> OrdensDeServicoQueOrcou { get; set; } = new HashSet<ordemdeservico>();
    }

    public class ordemdeservico
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key, Display(Name = "Id OS")]
        public long IdOrdemDeServico { get; set; }
        public DateTime Data { get; set; }

        [Display(Name = "Id Equip.")]
        public long Equipamento_IdEquipamento { get; set; }
        [ForeignKey(nameof(Equipamento_IdEquipamento))]
        public virtual equipamento Equipamento { get; set; }

        public long FuncionarioEnt_IdFuncionario { get; set; }
        [ForeignKey(nameof(FuncionarioEnt_IdFuncionario))]
        public virtual funcionario FuncionarioEnt { get; set; }

        public long? FuncionarioOrc_IdFuncionario { get; set; }
        [ForeignKey(nameof(FuncionarioOrc_IdFuncionario))]
        public virtual funcionario FuncionarioOrc { get; set; }

        public string Acessorios { get; set; }
        public string DefeitoApresentado { get; set; }
        public virtual ICollection<orcamento> Orcamentos { get; set; } = new HashSet<orcamento>();
    }

    public class orcamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdOrcamento { get; set; }
        public DateTime Data { get; set; } = DateTime.Today;
        public float Desconto { get; set; }

        public long Cliente_IdCliente { get; set; }
        [ForeignKey(nameof(Cliente_IdCliente))]
        public virtual cliente Cliente { get; set; }

        public long? OrdServico_IdOrdServico { get; set; }
        [ForeignKey(nameof(OrdServico_IdOrdServico))]
        public virtual ordemdeservico OrdemDeServico { get; set; }

        public virtual ICollection<itemdoorcamento> Items { get; set; } = new HashSet<itemdoorcamento>();
    }

    public class itemdoorcamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdItemDoOrcamento { get; set; }
        public long Compra_IdCompra { get; set; }
        [ForeignKey(nameof(Compra_IdCompra))]
        public virtual compra Compra { get; set; }
        public float Quantidade { get; set; }
        public long Orcamento_IdOrcamento { get; set; }
        [ForeignKey(nameof(Orcamento_IdOrcamento))]
        public virtual orcamento Orcamento { get; set; }
        public float Desconto { get; set; }
        public bool? Aprovado { get; set; }
    }

    public class fornecedor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdFornecedor { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public virtual ICollection<notacompra> Compras { get; set; } = new HashSet<notacompra>();

        public string CNPJ { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }

    public enum TipoMercadoria : int
    {
        [Description("Produto")]
        Produto = 0,
        [Description("Servi�o")]
        Servico = 1
    }

    public class mercadoria
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdMercadoria { get; set; }
        [Required]
        public string Codigo { get; set; }
        public string NCM { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public TipoMercadoria Tipo { get; set; } = TipoMercadoria.Produto;
        [Required]
        public string Unidade { get; set; }
        public virtual ICollection<compra> Compras { get; set; } = new HashSet<compra>();

        public static mercadoria GetOrCreateByMerc_Description(Contexto contexto, string idMercadoria_Descricao)
        {
            if (string.IsNullOrEmpty(idMercadoria_Descricao))
                return null;

            // idMercadoria_Descricao � o c�digo?
            mercadoria m = contexto.mercadorias.FirstOrDefault(k => k.Codigo == idMercadoria_Descricao);
            if (m != null)
                return m;

            // tenta com id|descricao
            string[] splits = idMercadoria_Descricao.Split('|');
            if (splits.Length == 2)
            {
                long idmerc = long.Parse(splits[0]);
                m = contexto.mercadorias.Find(idmerc);
                if (m != null)
                    return m;
            }

            // se nada resolver, cria uma mercadoria
            m = new mercadoria();
            m.Descricao = idMercadoria_Descricao;
            m.Tipo = TipoMercadoria.Produto;
            m.Unidade = "UN";

            return m;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }

    public class notacompra
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdNotaCompra { get; set; }
        public DateTime Data { get; set; } = DateTime.Today;
        public long Fornecedor_IdFornecedor { get; set; }
        [ForeignKey(nameof(Fornecedor_IdFornecedor))]
        public virtual fornecedor Fornecedor { get; set; }
        public string Xml { get; set; }
        public string NumeroNF { get; set; }
        public float Total { get {
                return Items.Sum(k => k.Quantidade * k.Custo);
        } }
        public ICollection<compra> Items { get; set; } = new HashSet<compra>();
    }

    public class compra
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdCompra { get; set; }
        public float Quantidade { get; set; } = 1;
        public float Custo { get; set; } = 0;
        public long Mercadoria_IdMercadoria { get; set; }
        [ForeignKey(nameof(Mercadoria_IdMercadoria))]
        public virtual mercadoria Mercadoria { get; set; }
        public float Venda { get; set; } = 0;
        public long NotaCompra_IdNotaCompra { get; set; }
        [ForeignKey(nameof(NotaCompra_IdNotaCompra))]
        public virtual notacompra NotaCompra { get; set; }
        [NotMapped]
        public float Total { get { return Quantidade * Custo; } }
        public string Descricao { get => Mercadoria?.Descricao; }
        public override string ToString()
        {
            return Descricao;
        }

        /// <summary>
        /// Cria um produto a partir de uma descri��o, se ele n�o existir no arquivo.
        /// o c�digo n�o � levado em conta aqui porque ele deve ser reconhecido pelo autocomplete e substituido
        /// pelo c�digo da compra|descri��o da mercadoria
        /// Tamb�m cria uma nota de entrada com a data atual e se necess�rio, cria um fornecedor padr�o
        /// </summary>
        /// <param name="contexto"></param>
        /// <param name="idCompra_Descricao"></param>
        /// <param name="unitario"></param>
        /// <returns></returns>
        public static compra GetOrCreateByProductDescription(Contexto contexto, string idCompra_Descricao, float pVenda)
        {
            if (string.IsNullOrEmpty(idCompra_Descricao))
                return null;

            compra c = new compra();
            c.Custo = 0;

            //c is description?
            c.Mercadoria = contexto.mercadorias.FirstOrDefault(k => k.Descricao == idCompra_Descricao);

            // se n�o foi encontrado, cria pela descri��o
            if (c.Mercadoria == null)
            {
                c.Mercadoria = new mercadoria();
                c.Mercadoria.Descricao = idCompra_Descricao;
                c.Mercadoria.Tipo = TipoMercadoria.Produto;
                c.Mercadoria.Unidade = "UN";

                DateTime dt = DateTime.Now;
                c.Mercadoria.Codigo = "{6}{5}{4}{3}{2}{1}{0}".Format(dt.Millisecond, dt.Second, dt.Minute, dt.Hour, dt.Day, dt.Month, dt.Year);
            }
            c.Custo = 0;
            c.Venda = pVenda;
            c.Quantidade = 0;

            string fornecedor_padrao = "Inclus�o Autom�tica de Compra";
            fornecedor forn = contexto.fornecedores.Include(k => k.Compras).FirstOrDefault(k => k.Nome == fornecedor_padrao);
            if (forn == null)
            {
                forn = new fornecedor();
                forn.Nome = fornecedor_padrao;
            }
            notacompra notaCompra = forn.Compras.FirstOrDefault();
            if (notaCompra == null)
            {
                notaCompra = new notacompra();
                notaCompra.Fornecedor = forn;
                notaCompra.Data = DateTime.Today;
            }

            c.NotaCompra = notaCompra;

            return c;
        }

    }

    public class notavenda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdNotaVenda { get; set; }
        [Display(Name = "Id do Cliente")]
        public long? Cliente_IdCliente { get; set; }
        [ForeignKey(nameof(Cliente_IdCliente))]
        public virtual cliente Cliente { get; set; }

        public DateTime Data { get; set; } = DateTime.Today;
        public float Desconto { get; set; }
        public virtual ICollection<venda> Items { get; set; } = new HashSet<venda>();
        public virtual ICollection<contaareceber> Parcelas { get; set; } = new HashSet<contaareceber>();
        public virtual ICollection<pagamento> PagamentosAVista { get; set; } = new HashSet<pagamento>();
    }

    public class venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdVenda { get; set; }
        public long Compra_IdCompra { get; set; }
        [ForeignKey(nameof(Compra_IdCompra))]
        public virtual compra Compra { get; set; }
        public float Quantidade { get; set; }
        public long NotaSaida_IdNotaSaida { get; set; }
        [ForeignKey(nameof(NotaSaida_IdNotaSaida))]
        public virtual notavenda Nota { get; set; }
        public float Desconto { get; set; }
        public string Descricao { get => Compra.Mercadoria.Descricao; }
    }

    public class contaapagar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdContaPagar { get; set; }
        public DateTime Vencimento { get; set; } = DateTime.Today;
        public long NotaCompra_IdNotaCompra { get; set; }
        [ForeignKey(nameof(NotaCompra_IdNotaCompra))]
        public virtual notacompra NotaCompra { get; set; }
        public float ValorFaturado { get; set; } = 0;
        public float? ValorPago { get; set; } = 0;
        public DateTime? DtPagamento { get; set; }

    }

    public class contaareceber
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdContaAReceber { get; set; }
        public DateTime Vencimento { get; set; } = DateTime.Today;
        public long NotaVenda_IdNotaVenda { get; set; }
        [ForeignKey(nameof(NotaVenda_IdNotaVenda))]
        public virtual notavenda NotaVenda { get; set; }
        public float Valor { get; set; } = 0;
    }

    public enum MeioDePagamento : int
    {
        [Description("F�sico")]
        Fisico = 0,
        [Description("Eletr�nico")]
        Eletronico = 1
    }

    // pagamentos do cliente
    public class pagamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdPagamento { get; set; }
        public DateTime DtPagamento { get; set; }
        public float Valor { get; set; }
        public string Descricao { get; set; }
        public MeioDePagamento Meio { get; set; } = MeioDePagamento.Fisico;

        public long? Cliente_IdCliente { get; set; }
        [ForeignKey(nameof(Cliente_IdCliente))]
        public virtual cliente Cliente { get; set; }

        public long? NotaVenda_IdNotaVenda { get; set; }
        [ForeignKey(nameof(NotaVenda_IdNotaVenda))]
        public virtual notavenda NotaVenda { get; set; }
    }

    public enum TipoMovCaixa : int
    {
        [Description("Entrada")]
        Entrada = 1,
        [Description("Sa�da")]
        Saida = 0
    }

    public class caixa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public long IdCaixa { get; set; }
        public TipoMovCaixa Tipo { get; set; } = TipoMovCaixa.Entrada;
        public DateTime DtPagamento { get; set; } = DateTime.Today;
        public float Valor { get; set; } = 0;
        [StringLength(200)]
        public string Descricao { get; set; }
    }
}
