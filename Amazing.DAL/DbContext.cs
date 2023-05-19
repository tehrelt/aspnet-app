using Npgsql;

namespace Amazing.DAL
{
    public class DbContext : IDisposable
    {
        private readonly string CONNECTION_STRING = $"Host=localhost;Username=postgres;Password=1337;Database=amazing";
        private NpgsqlConnection _connection;

        public DbContext()
        {
            _connection = new NpgsqlConnection(CONNECTION_STRING);
            _connection.Open();
        }
        
        

        public void Dispose()
        {
            _connection.Close();
        }
    }
}