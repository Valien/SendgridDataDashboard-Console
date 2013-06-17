using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendgridStatsConsole
{
    class Sendgrid
    {
        public int days { get; set; }
        public int start_date { get; set; }
        public int end_date { get; set; }
        public int aggregate { get; set; }
        public string category { get; set; }
    }

    class Profile
    {
        public string username { get; set; }
        public string email { get; set; }
        public bool active { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public bool website_access { get; set; }
    }
}
