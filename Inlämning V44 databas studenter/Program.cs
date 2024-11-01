namespace Inlämning_V44_databas_studenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInfoList studentInfoList = new StudentInfoList();
            studentInfoList.menu.WriteMenu();

            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentsV44;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        }
    }
}
