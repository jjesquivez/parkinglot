using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using parkinglot.Database.Interfaces;
using parkinglot.DTO;

namespace parkinglot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        #region Private Properties
        private IParkingContext _parkingContext;
        #endregion

        #region Constructor
        public ClientController(IParkingContext parkingContext)
        {
            _parkingContext = parkingContext;
        }
        #endregion

        #region Methods
        [HttpPost("Create")]
        public string CreateNewClient([FromBody] Car car)
        {
            try
            {
                var code = _parkingContext.EnterNewClient(car);
                return code;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpGet("payment/{id}")]
        public double GetTotalToPay(string id)
        {
            try
            {
                var total = _parkingContext.ExitClient(id);
                return total;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
