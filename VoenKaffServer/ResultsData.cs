using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoenKaffServer.Wrappers;

namespace VoenKaffServer
{
    class ResultsData
    {
        private static List<Result> _instance;
        private ResultsData()
        {
        }

        public static List<Result> Get()
        {
            if (_instance == null)
            {
                _instance = new List<Result> { };
            }

            return _instance;
        }

        public static void Set(List<Result> list)
        {
            _instance = list;
        }
    }
}
