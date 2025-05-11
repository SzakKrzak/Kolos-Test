using System.Data.SqlClient;
using Kol_Test.DTOs;

namespace Kol_Test.Services;

public interface IDbService
{
}

public class DbService(IConfiguration config) : IDbService
{
    
}