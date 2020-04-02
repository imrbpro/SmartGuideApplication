using Microsoft.Extensions.Configuration;
using Model;
using Repository.Helpers;
using Repository.Helpers.Interfaces;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Implementations
{
    public class EventRepository : IEventRepository
    {
        private readonly IDBhelper db;
        private IConfiguration configuration;
        private DataTable dt = new DataTable();
        private bool isCreated = false;
        private bool isDeleted = false;
        private bool isUpdated = false;
        public EventRepository(IDBhelper _db, IConfiguration config)
        {
            db = _db;
            configuration = config;
        }
        public bool AddEvent(Event _event)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@shopid",_event.ShopId),
                    new SqlParameter("@brandid",_event.BrandId),
                    new SqlParameter("@eventname",_event.Name),
                    new SqlParameter("@eventdetails",_event.Details),
                    new SqlParameter("@eventdate",_event.DateTime)
                };
                return db.ExecuteNonQuery(SpConstants.SP_ADD_EVENT, parameter);
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public string GetEventsByBrand(int id)
        {
            try
            {
                SqlParameter[] parameter = { new SqlParameter("@BrandId", id) };
                return db.GetBy(SpConstants.SP_GET_EVENT_BY_BRAND, parameter);
            }
            catch (Exception ex)
            {
                return "Error while fetching data from Database";
            }
        }
        public string GetEventById(int id)
        {
            try
            {
                SqlParameter[] parameter = { new SqlParameter("@EventId", id) };
                return db.GetBy(SpConstants.SP_GET_EVENT_BY_ID, parameter);
            }
            catch (Exception ex)
            {
                return "Error while fetching data from Database";
            }
        }
        public string GetEventsByShop(int id)
        {
            try
            {
                SqlParameter[] parameter = { new SqlParameter("@ShopId", id) };
                return db.GetBy(SpConstants.SP_GET_EVENT_BY_SHOP, parameter);
            }
            catch (Exception ex)
            {
                return "Error while fetching data from Database";
            }
        }

        public bool Update(Event _event)
        {
            try
            {
                SqlParameter[] parameter =
                {
                    new SqlParameter("@ShopId", _event.ShopId),
                    new SqlParameter("@BrandId", _event.BrandId),
                    new SqlParameter("@EventName", _event.Name),
                    new SqlParameter("@EventDetails", _event.Details),
                    new SqlParameter("@EventDateTime", _event.DateTime)
                };
                return db.ExecuteNonQuery("SpUpdateEvent", parameter);
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                SqlParameter[] parameter = { new SqlParameter("@EventId",id) };
                return db.ExecuteNonQuery(SpConstants.SP_DELETE_EVENT_BY_ID,parameter);
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public string GetAllEvents(int page)
        {
            try
            {
                SqlParameter[] parameter = { new SqlParameter("@Page", page) };
                return db.GetBy(SpConstants.SP_GET_ALL_EVENTS, parameter);
            }
            catch (Exception ex)
            {
                return "Error while fetching data from Database";
            }
        }
    }
}
