namespace Dominio.Entidades
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Ativo { get; set; } = true;

        public DateTime CriadoEm { get; set; }
        public string? CriadoPor { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public string? AtualizadoPor { get; set; }
    }
}
