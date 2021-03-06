using System.Data;
using System.Data.SqlClient;

namespace SqlServer.Management.IntegrationServices
{
    public interface ISsisApplication
    {
        SsisConfiguration Configuration { get; }
        ISsisCatalog GetCatalog(SqlConnectionStringBuilder connectionStringBuilder);
    }
}