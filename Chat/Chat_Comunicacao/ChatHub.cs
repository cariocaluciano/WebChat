using Microsoft.AspNetCore.SignalR;

namespace Chat_Comunicacao;

public class ChatHub : Hub
{
    public async Task EnviarMensagem(string usuario, string mensagem)
    {
        await Clients.All.SendAsync("ReceiveMessage", usuario, mensagem);
    }

}
