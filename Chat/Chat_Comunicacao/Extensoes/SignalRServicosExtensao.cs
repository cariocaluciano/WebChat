using Microsoft.Extensions.DependencyInjection;

namespace Chat_Comunicacao.Extensoes;

public static class SignalRServicosExtensao
{
    public static IServiceCollection AddSignalR(this IServiceCollection services)
    {
        services.AddSignalR();
        return services;
    }
}
