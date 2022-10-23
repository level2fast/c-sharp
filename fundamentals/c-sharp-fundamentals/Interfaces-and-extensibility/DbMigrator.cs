using Interfaces_and_extensibility;

namespace interfaces_and_extensibility
{

    public class DbMigrator
    {
        private readonly ILogger _logger;

        /// <summary>
        /// This constructor demonstrates dependency injection
        /// Logger 
        /// </summary>
        /// <param name="logger"></param>
        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            // Details of migrating the database
            _logger.LogInfo("Migration finished ast{0}"+ DateTime.Now);
        }
    }
}
