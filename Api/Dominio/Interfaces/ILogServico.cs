using Dominio.Entidades;
using MinimalApi.Infraestrutura.Db;

public interface ILogServico
{
    void Registrar(string usuario, string acao, string detalhes);
}

public class LogServico : ILogServico
{
    private readonly DbContexto _contexto;
    public LogServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public void Registrar(string usuario, string acao, string detalhes)
    {
        var log = new LogAuditoria
        {
            Usuario = usuario,
            Acao = acao,
            Detalhes = detalhes,
            Data = DateTime.Now
        };

        _contexto.Logs.Add(log);
        _contexto.SaveChanges();
    }
}
