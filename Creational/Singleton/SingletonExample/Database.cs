namespace SingletonExample
{
    public class Database
    {
        private static Database instancia;
        private static object _lock = new object();
        private string random;

        private Database() { }

        public static Database GetInstance(string random)
        {
            //lock(_lock)
            //{ 
                if (instancia == null)
                {
                    instancia = new Database();
                    instancia.random = random;
                }
            //}

            return instancia;
        }

        public string Query(string query)
        {
            return $"SQL {query}{random}";
        }
    }
}
