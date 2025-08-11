namespace EF_core_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext db = new CompanyDbContext();
            // Database is unmanged resource => solutions
            // object "db" responsible with connection to database


            /* using CompanyDbContext db = new CompanyDbContext(); */

            // using CompanyDbContext db = new CompanyDbContext()
            //{

            //} 

            // try
            //{

            //}
            //finally
            //{
            //    db.Dispose();
            //}  
        }
    }
}
