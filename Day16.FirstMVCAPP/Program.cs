internal class Program
{

    //static void main is the main entry point of the application
    //string[] args is the entry parameters

    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();//enables MVC

        var app = builder.Build();//this will create a web application

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();//js,css,images

        app.UseRouting();//this will route your request to controller

        app.UseAuthorization();//enable authentecation/authorization

        app.MapControllerRoute(//default controller route setting
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();//start our application with all the configuration done above this line.
    }
}