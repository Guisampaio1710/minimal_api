namespace Dominio.Entidades
{
    public class LogAuditoria
    {
        public int Id { get; set; }
    public string Usuario { get; set; } = string.Empty; // quem fez
    public string Acao { get; set; } = string.Empty; // exemplo: "Criou Veículo"
    public string Detalhes { get; set; } = string.Empty; // exemplo: "Veículo: Fusca, Ano: 1970"
    public DateTime Data { get; set; } = DateTime.Now;
    }
}
