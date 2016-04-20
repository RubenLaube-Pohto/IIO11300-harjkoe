using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    public class Client
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Sales { get; set; }
    }

    public static class ClientService
    {
        public static List<Client> ReadFile(string filepath)
        {
            var lines = File.ReadAllLines(filepath);

            var data = from l in lines.Skip(1)
                       let split = l.Split(';')
                       select new Client
                       {
                           Name = split[0],
                           Contact = split[1],
                           Address = split[2],
                           PostalCode = split[3],
                           City = split[4],
                           Sales = split[5]
                       };

            return data.ToList();
        }
    }
}
