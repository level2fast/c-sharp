namespace interfaces_and_extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // demonstates open/closed princple
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();

            var dbMigrator2 = new DbMigrator(new FileLogger("c:\\temp\\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}
