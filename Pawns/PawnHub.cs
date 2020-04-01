using Microsoft.AspNet.SignalR;

namespace Pawns
{
    [Microsoft.AspNet.SignalR.Hubs.HubName("pawnHub")]
    public class PawnHub : Hub
    {
        public void Send(int x, int y, int idx)
        {
            // Call the broadcastMessage method to update clients.
            Clients.Others.broadcastMessage(x, y, idx);
        }
    }
}