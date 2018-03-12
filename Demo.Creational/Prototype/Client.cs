using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Creational.Prototype.Enum;
using Demo.Creational.Prototype.Interface;

namespace Demo.Creational.Prototype
{
    public class Client
    {
        public Client()
        {
            var manager = new VechicleManager();
            var saloon = manager.CreateSaloon();
            var coupe = manager.CreateCoupe();
            var sport = manager.CreateSport();
        }
    }
}
