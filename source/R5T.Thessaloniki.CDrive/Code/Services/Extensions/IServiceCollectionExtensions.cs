using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Copenhagen.Standard;
using R5T.Lombardy.Standard;
using R5T.Thessaloniki.Copenhagen;
using R5T.Troy.Standard;


namespace R5T.Thessaloniki.CDrive
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTemporaryDirectoryPathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<ITemporaryDirectoryPathProvider, CDriveTemporaryDirectoryPathProvider>()
                .AddCDrivePathProvider()
                .AddTemporaryDirectoryNameConvention()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}
