namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello Omar Saad!");
            app.MapGet("/Index", () => "Hello World!");
            app.MapControllerRoute(name: "Default", 
                pattern: "Controller/action/id");
            app.Run();
        }
    }
}
