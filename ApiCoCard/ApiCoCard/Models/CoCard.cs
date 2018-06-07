using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCoCard.Models
{
    public class CoCard
    {

        [JsonObject(IsReference = true)]
        public class CoCardList
        {
            public int Campaign_id { get; set; }
            public DateTime Workdate { get; set; }
            public string Abbno { get; set; }
            public string Addr_Fullname { get; set; }
            public string Addr_Mobile { get; set; }
            public string Whcode { get; set; }
            public string Whname { get; set; }
            public string Stcode { get; set; }
            public string Stname { get; set; }
            public int FLAG { get; set; }
            public string Discount { get; set; }
            public DateTime SysCreate { get; set; }
        }

        [JsonObject(IsReference = true)]
        public class Branch
        {
            public int WH_ID { get; set; }
            public string WHCODE { get; set; }
            public string WHNAME { get; set; }

        }

        [JsonObject(IsReference = true)]
        public class Choice
        {
            public int CHOICE_NO { get; set; }
            public string CHOICE_CAPTION { get; set; }

        }

        [JsonObject(IsReference = true)]
        public class Campaign
        {
            public string BRAND_NAME { get; set; }
            public string CAMPAIGN_NAME { get; set; }


        }
    }
}