using ASC.BC;
using ASC.BC.Interfaces;
using ASC.UI.UtilForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASC.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection();

            //Services
            serviceCollection.AddDbContext<ASCContext>(options => options.UseSqlite(config.GetConnectionString("ASCDB")));

            serviceCollection.AddScoped<IAttributeBC, AttributeBC>();
            serviceCollection.AddScoped<IClassBC, ClassBC>();
            serviceCollection.AddScoped<IRaceBC, RaceBC>();
            serviceCollection.AddScoped<ISkillBC, SkillBC>();
            serviceCollection.AddScoped<ILevelBC, LevelBC>();

            //Forms
            serviceCollection.AddTransient<Main>();
            serviceCollection.AddTransient<CharacterCreationForm>();

            serviceCollection.AddTransient<AttributeLoad>();
            serviceCollection.AddTransient<ClassLoad>();
            serviceCollection.AddTransient<RaceLoad>();
            serviceCollection.AddTransient<SkillLoad>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
            Application.Run(ServiceProvider.GetRequiredService<Main>());
        }
    }
}