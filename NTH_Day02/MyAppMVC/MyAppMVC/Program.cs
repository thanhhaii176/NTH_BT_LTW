using Microsoft.AspNetCore.Mvc;

namespace MyAppMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            //Account
            app.MapControllerRoute(
                name: "account",
                pattern: "Account",
                defaults: new
                {
                    controller = "Account",
                    action = "Index"
                });

            //Product
            app.MapControllerRoute(
                name: "product",
                pattern: "San-pham",
                defaults: new
                {
                    controller = "Product",
                    action = "Index"
                });

            //Product Category
            app.MapControllerRoute(
                name: "product_category",
                pattern: "San-pham/danh-muc/{categoryId}",
                defaults: new
                {
                    controller = "Product",
                    action = "Category"
                });

            //Product Detail
            app.MapControllerRoute(
                name: "product_detail",
                pattern: "Chi-tiet-san-pham/{id}",
                defaults: new
                {
                    controller = "Product",
                    action = "Detail"
                });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();
            app.Run();
        }
    }
}
