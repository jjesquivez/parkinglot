﻿using Microsoft.EntityFrameworkCore;
using parkinglot.Database.Interfaces;
using parkinglot.Database.Model;
using parkinglot.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parkinglot.Database
{
    public class ParkinglotContext : DbContext, IParkingContext
    {
        #region Private Properties
        private DbSet<ClientsModel> clientsModels { get; set; }
        #endregion

        #region Constructor
        public ParkinglotContext(DbContextOptions options) : base(options)
        {

        }
        #endregion

        #region CRUD
        public string EnterNewClient(Car car)
        {
            var code = "";
            try
            {
                ClientsModel client = new ClientsModel
                {
                    id = car.brand.Substring(0, 1) + car.model.Substring(0, 1) + car.plates,
                    brand = car.brand,
                    model = car.model,
                    plates = car.plates,
                    enter = DateTime.Now,
                    exit = null
                };
                clientsModels.Add(client);
                SaveChangesAsync();
                code = client.id;
            }
            catch(Exception ex)
            {
                throw;
            }
            return code;
        }

        public double ExitClient(string clientId)
        {
            double payment = 0;
            try
            {
                var enteredTime = clientsModels.Find(clientId).enter;
                var now = DateTime.Now;
                var timePassed = now - enteredTime;
                payment = timePassed.TotalMinutes / 60 * 10;
            }
            catch(Exception ex)
            {
                throw;
            }
            return payment;
        }
        #endregion
    }
}
