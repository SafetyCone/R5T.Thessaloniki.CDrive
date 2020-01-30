using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Copenhagen.Standard;
using R5T.Dacia;
using R5T.Lombardy.Standard;
using R5T.Thessaloniki.Copenhagen;
using R5T.Troy.Standard;


namespace R5T.Thessaloniki.CDrive
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a <see cref="ITemporaryDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddTemporaryDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddCDriveTemporaryDirectoryPathProvider(
                services.AddCDrivePathProviderAction(),
                services.AddTemporaryDirectoryNameConventionAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds a <see cref="ITemporaryDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<ITemporaryDirectoryPathProvider> AddTemporaryDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITemporaryDirectoryPathProvider>(() => services.AddTemporaryDirectoryPathProvider());
            return serviceAction;
        }
    }
}
