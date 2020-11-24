using parkinglot.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parkinglot.Database.Interfaces
{
    interface IParkingContext
    {
        string EnterNewClient(Car car);
        double ExitClient(string clientId);
    }
}
