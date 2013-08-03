using Microsoft.AspNet.SignalR;

namespace WebUI
{
    public class Chart : Hub
    {
        public void SendData(double data)
        {
            Clients.All.sendData(data);
        }
    }
}