using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using HotelManagement.Infrastructure.Data;
using System.Configuration;
using HotelManagement.Application.Interfaces;
using HotelManagement.Infrastructure.Repository;
using HotelManagement.Presentation.Forms;

namespace HotelManagement.Presentation
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			var services = new ServiceCollection();

			ConfigureServices(services);
			using (var serviceProvider = services.BuildServiceProvider())
			{
				System.Windows.Forms.Application.EnableVisualStyles();
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
				var mainForm = serviceProvider.GetRequiredService<MainForm>();
				System.Windows.Forms.Application.Run(mainForm);
			}
		}
		private static void ConfigureServices(ServiceCollection services)
		{
			// DbContext registration
			string connectionString = ConfigurationManager.ConnectionStrings["HotelManagementDb"].ConnectionString;

			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString));

			// Dependency injection for repositories and services
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			// Form registration
			services.AddTransient<LoginForm>();
			services.AddTransient<MainForm>();

		}
	}
}