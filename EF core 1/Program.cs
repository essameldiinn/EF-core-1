namespace EF_core_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext db = new CompanyDbContext();

            #region Database is unmanged resource
            // object "db" responsible with connection to database

            // Database is unmanged resource => to solve it :

            //1- using CompanyDbContext db = new CompanyDbContext();

            //2- using CompanyDbContext db = new CompanyDbContext()
            //{

            //}

            //3- try
            //{

            //}
            //finally
            //{
            //    db.Dispose();
            //} 
            #endregion

        }
    }
}
