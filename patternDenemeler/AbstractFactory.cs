using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDenemeler
{
    class AbstractFactory
    {
    }

    //Abstract Product
    abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool DisConnect();
        public abstract string State { get; }
    }

    //Abstract Product
    abstract class Command
    {
        public abstract void Execute(string query);
    }

    //Concrete Product
    class SqlConnection : Connection
    {
        public override string State => "Open";
        public override bool Connect()
        {
            Console.WriteLine("SqlConnection bağlantısı kuruluyor.");
            return true;
        }
        public override bool DisConnect()
        {
            Console.WriteLine("SqlConnection bağlantısı kesiliyor.");
            return false;
        }
    }

    //Concrete Product
    class SqlCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("SqlCommand sorgusu çalıştırıldı.");
    }

    class MySqlConnection : Connection
    {
        public override string State => "Open";
        public override bool Connect()
        {
            Console.WriteLine("MySqlConnection bağlantısı kuruluyor.");
            return true;
        }
        public override bool DisConnect()
        {
            Console.WriteLine("MySqlConnection bağlantısı kesiliyor.");
            return false;
        }
    }
    //Concrete Product
    class MySqlCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("MySqlCommand sorgusu çalıştırıldı.");
    }

    //Abstract Factory
    abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
    //Concreate Factory
    class SqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new SqlCommand();
        public override Connection CreateConnection() => new SqlConnection();
    }
    //Concreate Factory
    class MySqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new MySqlCommand();
        public override Connection CreateConnection() => new MySqlConnection();
    }

    //Creater
    class Olusturucu
    {
        DatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;
        public Olusturucu(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();

            Start();
        }

        void Start()
        {
            if (_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("Select * from...");
                _connection.DisConnect();
            }
        }
    }

}
