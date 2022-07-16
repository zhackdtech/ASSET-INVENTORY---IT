using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Inventory
{
    internal class ConnectionInfo
    {
        //check private network if the database server is available
        public static bool CheckNetwork()
        {
            try
            {
                //create a new instance of Ping 
                Ping myPing = new Ping();
                //host to check connection of
                //the database server in this case
                String host = "10.10.1.100";
                //buffer of 32 bytes of data to transmit
                byte[] buffer = new byte[32];
                //wait 10 seconds for a reply
                int timeout = 10000;
                // Set options for transmission:
                // The data can go through 64 gateways or routers
                // before it is destroyed, and the data packet
                // cannot be fragmented.
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                //not connected
                return false;
            }
        }
    }
}
