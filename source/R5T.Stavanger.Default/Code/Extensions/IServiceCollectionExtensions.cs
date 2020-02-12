using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Stavanger.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ShortcutPathConventions"/> implementation of <see cref="IShortcutPathConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultShortcutPathConventions(this IServiceCollection services)
        {
            services.AddSingleton<IShortcutPathConventions, ShortcutPathConventions>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ShortcutPathConventions"/> implementation of <see cref="IShortcutPathConventions"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IShortcutPathConventions> AddDefaultShortcutPathConventionsAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IShortcutPathConventions>(() => services.AddDefaultShortcutPathConventions());
            return serviceAction;
        }
    }
}
