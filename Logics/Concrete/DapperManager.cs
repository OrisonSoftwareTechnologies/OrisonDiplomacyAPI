using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using OrisonSPMSAPI.Logics.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonSPMSAPI.Logics.Concrete
{
    public class DapperManager:IDapperManager
    {
        private readonly IConfiguration _config;
        public DapperManager(IConfiguration config)
        {
            _config = config;
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        }

        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }

        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            return db.Execute(sp, parms, commandType: commandType);
        }
        public long Insert(string sp, DynamicParameters parms, IDbConnection db, IDbTransaction tran, CommandType commandType = CommandType.StoredProcedure)
        {
            long newID;
            parms.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
            var result = db.Execute(sp, parms, transaction: tran, null, CommandType.StoredProcedure);
            newID = parms.Get<long>("@NewID");
            return newID;
        }
        public long InsertTable(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            //long result;
            long newID;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    parms.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
                    var result = db.Execute(sp, parms, transaction: tran, null, CommandType.StoredProcedure);
                    newID = parms.Get<long>("@NewID");

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return newID;
            //return result;

        }
        public void Insertvoid(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {

            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    db.Execute(sp, parms, transaction: tran, null, CommandType.StoredProcedure);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

        }
        public T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }

        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }
        public long UpdateTable(string sp, DynamicParameters parms, IDbConnection db, IDbTransaction tran, CommandType commandType = CommandType.StoredProcedure)
        {
            long newID;
            try
            {
                parms.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
                var result = db.Execute(sp, parms, commandType: commandType, transaction: tran);
                newID = parms.Get<long>("@NewID");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return newID;
        }
        public long Update(string sp, DynamicParameters parms, CommandType commandType)
        {
            long newID;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    parms.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
                    var result = db.Execute(sp, parms, transaction: tran, null, CommandType.StoredProcedure);
                    newID = parms.Get<long>("@NewID");

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return newID;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
