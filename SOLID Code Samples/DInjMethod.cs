public interface IService
{
    void Serve();
}
public class Service1 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service1 Called");
    }
}
public class Service2 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service2 Called");
    }
}
public class Client
{
    // now the dependency is passed to the method using it 
    public void ServeMethod(IService service)
    {
        service.Serve();
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating object
        Service1 s1 = new Service1();

        Client client = new Client();
        client.ServeMethod(s1);

        Service2 s2 = new Service2();
        client.ServeMethod(s2);
    }
}