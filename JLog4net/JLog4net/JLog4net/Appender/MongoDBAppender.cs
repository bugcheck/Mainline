﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using log4net.Appender;
using log4net.Core;

namespace log4net.Appender
{
    public class MongoDBAppender : BufferingAppenderSkeleton
    {
        private readonly List<MongoAppenderFileld> _fields = new List<MongoAppenderFileld>();

        /// <summary>
        /// MongoDB database connection in the format:
        /// mongodb://[username:password@]host1[:port1][,host2[:port2],...[,hostN[:portN]]][/[database][?options]]
        /// See http://www.mongodb.org/display/DOCS/Connections
        /// If no database specified, default to "log4net"
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The connectionString name to use in the connectionStrings section of your *.config file
        /// If not specified or connectionString name does not exist will use ConnectionString value
        /// </summary>
        public string ConnectionStringName { get; set; }

        /// <summary>
        /// Name of the collection in database
        /// Defaults to "logs"
        /// </summary>
        public string CollectionName { get; set; }

        #region Deprecated

        /// <summary>
        /// Hostname of MongoDB server
        /// Defaults to localhost
        /// </summary>
        [Obsolete("Use ConnectionString")]
        public string Host { get; set; }

        /// <summary>
        /// Port of MongoDB server
        /// Defaults to 27017
        /// </summary>
        [Obsolete("Use ConnectionString")]
        public int Port { get; set; }

        /// <summary>
        /// Name of the database on MongoDB
        /// Defaults to log4net_mongodb
        /// </summary>
        [Obsolete("Use ConnectionString")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// MongoDB database user name
        /// </summary>
        [Obsolete("Use ConnectionString")]
        public string UserName { get; set; }

        /// <summary>
        /// MongoDB database password
        /// </summary>
        [Obsolete("Use ConnectionString")]
        public string Password { get; set; }

        #endregion

        public void AddField(MongoAppenderFileld fileld)
        {
            _fields.Add(fileld);
        }

        private void MongoAppend(LoggingEvent loggingEvent)
        {
            var collection = GetCollection();
            collection.Insert(BuildBsonDocument(loggingEvent));
        }
        private void MongoAppend(LoggingEvent[] loggingEvents)
        {
            var collection = GetCollection();
            
            collection.InsertBatch(loggingEvents.Select(BuildBsonDocument));
        }
        private MongoCollection GetCollection()
        {
            var db = GetDatabase();
            var appid = ConfigurationManager.AppSettings["appid"];
            MongoCollection collection = db.GetCollection(CollectionName ?? appid+"logs");
            return collection;
        }
        protected override void SendBuffer(LoggingEvent[] loggingEvents)
        {
            MongoAppend(loggingEvents);
        }
        private string GetConnectionString()
        {
            ConnectionStringSettings connectionStringSetting = ConfigurationManager.ConnectionStrings[ConnectionStringName];
            return connectionStringSetting != null ? connectionStringSetting.ConnectionString : ConnectionString;
        }
        /// <summary>
        /// 链接mongodb,2015-12-03
        /// </summary>
        public void GetConnMongoDB()
        {
            string connStr = ConfigurationManager.AppSettings["mongoDBConfig"];
            MongoUrl url = MongoUrl.Create(connStr);
            MongoServer conn = MongoServer.Create(url);
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 500);
            conn.Connect(ts);
           
        }
           
        private MongoDatabase GetDatabase()
        {
            string connStr = GetConnectionString();

            if (string.IsNullOrWhiteSpace(connStr))
            {
                return MongoBackwardCompatibility.GetDatabase(this);
            }

            MongoUrl url = MongoUrl.Create(connStr);

            // TODO Should be replaced with MongoClient, but this will change default for WriteConcern.
            // See http://blog.mongodb.org/post/36666163412/introducing-mongoclient
            // and http://docs.mongodb.org/manual/release-notes/drivers-write-concern
            MongoServer conn = MongoServer.Create(url);
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 500);


            conn.Connect(ts);

            MongoDatabase db = conn.GetDatabase(url.DatabaseName ?? "log4net");
            return db;
        }

        private BsonDocument BuildBsonDocument(LoggingEvent log)
        {
            if (_fields.Count == 0)
            {
                return MongoBackwardCompatibility.BuildBsonDocument(log);
            }
            var doc = new BsonDocument();
            foreach (MongoAppenderFileld field in _fields)
            {
                object value = field.Layout.Format(log);
                var bsonValue = value as BsonValue ?? BsonValue.Create(value);
                doc.Add(field.Name, bsonValue);
            }

            return doc;
        }
    }
}