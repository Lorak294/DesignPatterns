using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Database
    {
        private static Database instance;

        private Database() 
        {
            Debug.WriteLine("Conecting to the database server");
        }

        public static Database GetInstance()
        {
            if(instance == null)
                instance = new Database();
            return instance;
        }
    }
}
