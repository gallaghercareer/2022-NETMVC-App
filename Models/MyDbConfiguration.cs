    using System.Data.Entity;
    using System.Data.Entity.SqlServer;

    namespace FinalProReRe
    {
        public class MyDbConfiguration : DbConfiguration
        {
            public MyDbConfiguration()
            {
            //     The default retry limit is 5, which means that the total amount of time spent
            //     between retries is 26 seconds plus the random factor.
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            }
        }
    }
    