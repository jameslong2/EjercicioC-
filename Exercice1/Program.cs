using Microsoft.WindowsAPICodePack.Net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercice1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionStatus="";
            IPStatus[] values=new IPStatus[4];
            try
            {
                for (int i = 0; i < 4; i++)
                {

                    PingReply reply = new Ping().Send("cloudfire.com");
                    values[i] = reply.Status;
                }
                int count=0;
                for (int i = 0; i < 4; i++)
                {
                    if (values[i]==IPStatus.Success)
                    {
                        count++;
                    }
                }
                if (count==4)
                {
                    connectionStatus = "Established";
                }else if (count>0)
                {
                    connectionStatus = "Unstable";
                }else if (count==0)
                {
                    connectionStatus = "Disconnected";
                }
            }
            catch(PingException)
            {

            }
            finally
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(GetDefaultGateway(),GetLocalIPAddress(),GetLocalHostName(),GetUserName(),GetSSID(),GetSSIDStatus(),GetMAC(),GetVirtualBox(),GetVirtualBoxVersion(),connectionStatus));
            }
            
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public static string GetLocalHostName()
        {
            return Environment.MachineName;
        }
        public static string GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                .FirstOrDefault().ToString();
        }
        public static string GetUserName()
        {
            return Environment.UserName;
        }
        public static string GetSSID()
        {
            if (NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected).ToArray().Length>0)
            {
                return NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected).ToArray()[0].Name;
            }
            else
            {
                return "No hay red";
            }
        }
        public static string GetSSIDStatus()
        {
            return NetworkListManager.GetNetworks(NetworkConnectivityLevels.Connected).ToArray()[0].IsConnected?"Conectado":"Desconectado";
        }
        public static string GetMAC()
        {
            return NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault(); ;
        }
        public static string GetVirtualBox()
        {
            return File.Exists(Environment.ExpandEnvironmentVariables("%ProgramW6432%")+ @"\Oracle\VirtualBox\VBoxManage.exe") ?"Si":"No";
        }
        public static string GetVirtualBoxVersion()
        {
            if (File.Exists(Environment.ExpandEnvironmentVariables("%ProgramW6432%") + @"\Oracle\VirtualBox\VBoxManage.exe"))
            {
                var version = FileVersionInfo.GetVersionInfo(Environment.ExpandEnvironmentVariables("%ProgramW6432%") + @"\Oracle\VirtualBox\VBoxManage.exe").FileVersion;

                return version == null ? "Not Installed" : version;
            }
            else
            {
                return "Not Isntalled";
            }
        }
    }
}
