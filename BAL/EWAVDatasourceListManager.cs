﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using CDC.ISB.EIDEV.DAL;
using CDC.ISB.EIDEV.DTO;
using CDC.ISB.EIDEV.Security;

namespace CDC.ISB.EIDEV.BAL
{
    /// <summary>
    /// Manager for the list of data sources avail to the application   
    /// </summary>
    public class EWAVDatasourceListManager
    {
        string metaDatabaseType = ConfigurationManager.AppSettings["MetaDatabaseType"];
        string metaDataConnectionString = ConfigurationManager.AppSettings["MetaDataConnectionString"];
        string metaDataViewName = ConfigurationManager.AppSettings["MetaDataViewName"];
        /// <summary>
        /// Constructor  
        /// </summary>
        public EWAVDatasourceListManager()
        {


            Cryptography cy = new Cryptography();
            MetaDatabaseTypeEnum = (DataBaseTypeEnum)Enum.Parse(typeof(DataBaseTypeEnum), metaDatabaseType);
            this.metaDataConnectionString = cy.Decrypt(this.metaDataConnectionString);

        }

        /// <summary>
        /// Gets or sets the type of the meta database.
        /// </summary>
        /// <value>The type of the meta database.</value>
        public string MetaDatabaseType
        {
            get
            {
                return this.metaDatabaseType;
            }
            set
            {
                this.metaDatabaseType = value;
            }
        }
        /// <summary>
        /// Gets or sets the meta database type enum.
        /// </summary>
        /// <value>The meta database type enum.</value>
        public DataBaseTypeEnum MetaDatabaseTypeEnum { get; set; }
        /// <summary>
        /// Gets or sets the meta data connection string.
        /// </summary>
        /// <value>The meta data connection string.</value>
        public string MetaDataConnectionString
        {
            get
            {
                return this.metaDataConnectionString;
            }
            set
            {
                this.metaDataConnectionString = value;
            }
        }
        /// <summary>
        /// Gets or sets the name of the meta data view.
        /// </summary>
        /// <value>The name of the meta data view.</value>
        public string MetaDataViewName
        {
            get
            {
                return this.metaDataViewName;
            }
            set
            {
                this.metaDataViewName = value;
            }
        }
        /// <summary>
        /// Creates the connection string.
        /// </summary>
        /// <param name="externalDataBaseType">Type of the external data base.</param>
        /// <param name="dr">The dr.</param>
        /// <returns></returns>
        public static string xcreateConnectionString(DataBaseTypeEnum externalDataBaseType, DataRow[] dr)
        {
            string extConnectionString;

            switch (externalDataBaseType)
            {
                case DataBaseTypeEnum.MySQL:

                    extConnectionString =
                        string.Format("Server={0};Database={1};User Id={2};Pwd={3}", dr[0]["DatasourceServerName"].ToString(), dr[0]["InitialCatalog"], dr[0]["DatabaseUserID"], dr[0]["Password"]);                  //     shorterd01"   

                    break;
                case DataBaseTypeEnum.PostgreSQL:

                    extConnectionString = "";

                    break;
                case DataBaseTypeEnum.SQLServer:

                    extConnectionString =
                        string.Format("Data Source={0};Initial Catalog={1};Persist Security Info={2};User ID={3};Password={4}", dr[0]["DatasourceServerName"].ToString(), dr[0]["InitialCatalog"], dr[0]["PersistSecurityInfo"], dr[0]["UserID"], dr[0]["Password"]);                  //     shorterd01"   

                    break;
                default:
                    extConnectionString = "";

                    break;
            }

            return extConnectionString;
        }

        List<EWAVDatasourceDto> CreateDatasoureDtoList(DataTable dtDataSources, string userName)
        {

            Cryptography cy = new Cryptography();

            List<EWAVDatasourceDto> edsList = new List<EWAVDatasourceDto>();

            int x_sa = 0;

            //  All datasource rocords    
            //DataTable dt = GetAllDatasourceRecords(userName);

            try
            {

                for (int x = 0; x < dtDataSources.Rows.Count; x++)
                {
                    x_sa = x;

                    //if (dtDataSources.Rows[x]["DataBaseType"].ToString() != "MySQL")
                    //{
                    //  List<EWAVColumn> allCols = GetColumnsForDatasource(dtDataSources.Rows[x]["DatasourceName"].ToString(), userName, dtDataSources);


                    //if (allCols != null)
                    //{
                    EWAVDatasourceDto datasourceItem = new EWAVDatasourceDto()
                    {
                        // AllColumns = allCols,
                        AllColumns = new List<EWAVColumn>(),
                        DatasourceName = dtDataSources.Rows[x]["DatasourceName"].ToString(),
                        DatasourceID = int.Parse(dtDataSources.Rows[x]["DatasourceID"].ToString()),
                        TableName = cy.Decrypt(dtDataSources.Rows[x]["DatabaseObject"].ToString()),
                        TotalRecords = 0,          // long.Parse(getTotalRecords(dtDataSources.Rows[x]["DatasourceName"].ToString(),
                        //  dtDataSources.Rows[x])),
                        DataBaseType = dtDataSources.Rows[x]["DataBaseType"].ToString(),
                        OrganizationId = Convert.ToInt32(dtDataSources.Rows[x]["OrganizationId"].ToString())
                    };

                    edsList.Add(datasourceItem);
                    //  }
                    //             }
                }
            }
            catch (Exception ex)
            {


                throw new Exception("Error with CreateDatasourceDtoList ====  Datasourcename =  " +
                        dtDataSources.Rows[x_sa]["DatasourceName"].ToString() +
                      " Tahlename =  " + cy.Decrypt(dtDataSources.Rows[x_sa]["DatabaseObject"].ToString()) + "  " +
                      ex.Message + ex.StackTrace);

            }

            return edsList;
        }

        //  CODE CLEAN  
        /// <summary>
        /// Get a data table and map it to the Datasource dto           
        /// </summary>
        /// <returns>A list of EWAVDatasourceDto </returns>
        //public IEnumerable<EWAVDatasourceDto> GetDatasourcesAsIEnumerable()
        //{
        //    DataTable dt = GetAllDatasourceRecords();
        //    List<EWAVDatasourceDto> edsList = Mapper.DatasourceList(dt);

        //    return edsList.AsEnumerable<EWAVDatasourceDto>();
        //}

        /// <summary>
        /// Gets the datasources as I enumerable2.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EWAVDatasourceDto> GetDatasourcesAsIEnumerable2(string userName)
        {
            try
            {
                DataTable dt = GetAllDatasourceRecords(userName);
                List<EWAVDatasourceDto> edsList = CreateDatasoureDtoList(dt, userName);

                return edsList.AsEnumerable<EWAVDatasourceDto>();
            }
            catch (Exception ex)
            {

                throw new Exception("Error with GetDatasourcesAsIEnumerable2 ==== " + ex.Message + ex.StackTrace);
            }
        }

        // CODE CLEAN     
        //public List<EWAVDatasourceDto> GetDatasourcesAsList()
        //{
        //    DataTable dt = GetAllDatasourceRecords();
        //    List<EWAVDatasourceDto> edsList = Mapper.DatasourceList(dt);

        //    return edsList;
        //}

        //public List<EWAVDatasourceDto> GetDatasourcesAsList2()
        //{
        //    DataTable dt = GetAllDatasourceRecords();
        //    List<EWAVDatasourceDto> edsList = CreateDatasoureDtoList(dt);    //  CreateDatasoureDtoList     

        //    return edsList;
        //}

        //     DatasourceDao datasources = new DatasourceDao();
        //  DAL.Interfaces.IMetaDataDao daoFactory = DAL.DataManager.DAOFactory.MetaDataDao;

        /// <summary>
        /// Gets all datasource records.
        /// </summary>
        /// <returns></returns>
        private DataTable GetAllDatasourceRecords(string userName)
        {
            //DataManager dm = new DataManager(metaDataConnectionString, metaDataViewName,
            //    metaDatabaseTypeEnum);
            //return dm.DAOFactory.MetaDataDao.GetAllDataSources();
            EntityManager em = new EntityManager();

            return em.GetAllDatasources(userName);
        }

        /// <summary>
        /// Columnses as list.
        /// </summary>
        /// <returns></returns>
        public List<EWAVColumn> GetColumnsForDatasource(string dataSourceName, string userName, DataTable dt)
        {
            // select the right one    
            DataRow[] dr = dt.Select(string.Format("DatasourceName = '{0}' ", dataSourceName));
            // convert type to enum      
            DataBaseTypeEnum externalDataBaseType =
                (DataBaseTypeEnum)Enum.Parse(typeof(DataBaseTypeEnum), dr[0]["DataBaseType"].ToString());

            string externalDataConnectionString = CDC.ISB.EIDEV.DAL.Utilities.CreateConnectionString(externalDataBaseType, dr);

            // Get the right factory    
            string externalDataViewName = dr[0]["DatabaseObject"].ToString();
            DAL.Interfaces.IDaoFactory externalDaoFactory =
                DaoFatories.GetFactory(externalDataBaseType, externalDataConnectionString, externalDataViewName);

            // Get the columns       
            DataTable dtColumns = externalDaoFactory.RawDataDao.GetColumnsForDatasource(dr);

            // create list of EWAVColumn     
            List<EWAVColumn> ewavColumns = new List<EWAVColumn>();

            try
            {
                foreach (DataColumn col in dtColumns.Columns)
                {
                    EWAVColumn ec = new EWAVColumn
                    {
                        Index = ewavColumns.Count,
                        Name = col.ColumnName,
                        SqlDataTypeAsString = CDC.ISB.EIDEV.BAL.Common.GetDBType(col.DataType)
                    };

                    ewavColumns.Add(ec);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error with data columns == " + ex.Message + ex.StackTrace);
            }

            return ewavColumns;
        }

        /// <summary>
        /// Gets the total records.
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <returns></returns>
        private string getTotalRecords(string datasourceName, DataRow rows)
        {
            //  return (new CommonSQLDAO()).GetTotalRecords(rows);
            //     DataManager dm = new DataManager(metaDataConnectionString, metaDataViewName, metaDatabaseTypeEnum);
            EntityManager em = new EntityManager();
            return em.GetTotalRecords(datasourceName, rows);
            //               return dm.DAOFactory.RawDataDao.GetTotalRecords(datasourceName, rows);
        }
    }
}