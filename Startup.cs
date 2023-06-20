// using Microsoft.AspNetCore.Builder;  
// using Microsoft.AspNetCore.Hosting;  
// using Microsoft.EntityFrameworkCore;  
// using Microsoft.Extensions.Configuration;  
// using Microsoft.Extensions.DependencyInjection;  
// using Microsoft.Extensions.Hosting;  
// using PatientTesting.DataAccess;  
  
// namespace PatientTesting  
// {  
//     public class Startup  
//     {  
//         public Startup(IConfiguration configuration)  
//         {  
//             Configuration = configuration;  
//         }  
  
//         public IConfiguration Configuration { get; }  
  
//         // This method gets called by the runtime. Use this method to add services to the container.  
//         public void ConfigureServices(IServiceCollection services)  
//         {  
//             services.AddControllers();  
  
//             var sqlConnectionString = Configuration["PostgreSqlConnectionString"];  
  
//             services.AddDbContext<PostgreSqlContext>(options => options.UseNpgsql(sqlConnectionString));  
  
//             services.AddScoped<IDataAccessProvider, DataAccessProvider>();  

//             // services.AddDbContext<PostgreSqlContext>(options =>
//             //     options.UseSqlServer(Configuration.GetConnectionString("PostgreSqlConnectionString")));
//         }  
  
//         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.  
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)  
//         {  
//             if (env.IsDevelopment())  
//             {  
//                 app.UseDeveloperExceptionPage();  
//             }  
  
//             app.UseRouting();  
  
//             app.UseAuthorization();  
  
//             app.UseEndpoints(endpoints =>  
//             {  
//                 endpoints.MapControllers();  
//             });  
//         }  
//     }  
// }  