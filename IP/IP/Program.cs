using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine(IPcam.getInstance("111:111:111").IPaddress);
                WriteLine(IPcam.getInstance("111:111:111").IPaddress);
                WriteLine(IPcam.getInstance("111:111:111").IPaddress);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }

        }
    }
    class IPcam
    {
        private static Dictionary<string, IPcam> dict = new Dictionary<string, IPcam>();
        public string IPaddress { get => paddress; }
        private string paddress;

        public static IPcam getInstance(string IPaddress)
        {
            if (dict.Count > 3)
            {
                throw (new Exception("Impossible to create more then 3 Ip's"));
            }
            else
            if (!dict.ContainsKey(IPaddress))
            {
                dict.Add(IPaddress, new IPcam(IPaddress));
            }
            return dict[IPaddress];
        }
        public IPcam(string pAddress)
        {
            this.paddress = pAddress;
        }

    }
}
