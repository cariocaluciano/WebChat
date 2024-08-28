using Microsoft.AspNetCore.SignalR;

namespace Teste_Chat.Chat;

public class ChatHub : Hub 
{
    // Método para o usuário entrar em um grupo/sala de chat privado
    public async Task JoinRoom(string roomName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
    }

    // Método para o usuário sair de um grupo/sala de chat privado
    public async Task LeaveRoom(string roomName)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
    }

    // Método para enviar uma mensagem para um grupo/sala específica
    public async Task SendMessageToRoom(string roomName, string user, string message)
    {
        await Clients.Group(roomName).SendAsync("ReceiveMessage", user, message);
    }

    //Luciano novos ajustes para testar
    //private static Dictionary<string, string> UserRooms = new Dictionary<string, string>();
    //public async Task CreateRoomAndInviteUser(string roomName, string hostEmail, string inviteeEmail)
    //{
    //    await Groups.AddToGroupAsync(Context.ConnectionId, roomName);
    //    UserRooms[inviteeEmail] = roomName;
    //    await Clients.Caller.SendAsync("RoomCreated", roomName);
    //}

    //public override async Task OnConnectedAsync()
    //{
    //    var userEmail = Context.User!.Identity?.Name;

    //    // Verifica se o usuário está associado a alguma sala
    //    if (UserRooms.TryGetValue(userEmail!, out var roomName))
    //    {
    //        // Adiciona o usuário à sala
    //        await Groups.AddToGroupAsync(Context.ConnectionId, roomName);

    //        // Notifica o usuário de que ele foi adicionado à sala
    //        await Clients.Caller.SendAsync("AddedToRoom", roomName);
    //    }

    //    await base.OnConnectedAsync();
    //}
    // Luciano Fim

}
