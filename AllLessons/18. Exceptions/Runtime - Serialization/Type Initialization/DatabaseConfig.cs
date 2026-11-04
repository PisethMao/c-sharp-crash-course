namespace FirstProgram._18._Exceptions.Runtime___Serialization.Type_Initialization;

public static class DatabaseConfig
{
    static DatabaseConfig()
    {
        throw new InvalidOperationException("Database configuration missing...!!");
    }

    public static string ConnectionString => "server=>localhost";
}