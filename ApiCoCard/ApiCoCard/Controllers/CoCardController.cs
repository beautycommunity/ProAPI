using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiCoCard.DATA;
using ApiCoCard.Models;


namespace ApiCoCard.Controllers
{
    public class CoCardController : ApiController
    {
        
        
        [HttpPost]
        public string SaveRight(List<CoCard.CoCardList> item)
        {
            string sms;
            string whname;

            using (MasterITDataContext bx = new MasterITDataContext())
            {
                var dt = bx.MAS_WHs.Where(s => s.WHCODE == item[0].Whcode).FirstOrDefault();
                whname = dt.WHNAME;
            }

            using (CoCardDataContext bx = new CoCardDataContext())
            {
                try
                { 

                var cc = new TRN_FORM_CO_CARD();
                cc.CAMPAIGN_ID = item[0].Campaign_id;
                cc.WORKDATE = item[0].Workdate.AddHours(7);
                cc.ABBNO = item[0].Abbno;
                cc.ADDR_FULLNAME = item[0].Addr_Fullname;
                cc.ADDR_MOBILE = item[0].Addr_Mobile;
                cc.WHCODE = item[0].Whcode;
                cc.WHNAME = whname;
                cc.STCODE = item[0].Stcode;
                cc.STNAME = item[0].Stname;
                cc.FLAG = item[0].FLAG;
                cc.DISCOUNT = item[0].Discount;
                cc.SYSCRATE = item[0].SysCreate.AddHours(7);

                bx.TRN_FORM_CO_CARDs.InsertOnSubmit(cc);
                bx.SubmitChanges();

                sms = "บันทึกสำเร็จ";
                }
                catch (Exception ex)
                {

                    sms = "ไม่สำเร็จ\n" + ex.Message;
                }

            }

                return sms;
        }

        [HttpPost]
        public List<CoCard.Branch> getBranch(string _brand)
        {
            List<CoCard.Branch> branch = new List<CoCard.Branch>();

            using (MasterITDataContext bx = new MasterITDataContext())
            {
                
                    var data = bx.MAS_WHs.Where(s => s.BRAND == _brand && s.WHNAME != "").OrderBy(s=> s.WHNAME).Select(s => new {s.WH_ID, s.WHNAME, s.WHCODE }).ToList();

                foreach(var item in data)
                {
                    branch.Add(new CoCard.Branch { WH_ID = item.WH_ID, WHCODE = item.WHCODE ,WHNAME = item.WHNAME});
                }

                return branch;
            }
        }

        [HttpPost]
        public List<CoCard.Choice> getDiscount(int campaign_id)
        {
            List<CoCard.Choice> discount = new List<CoCard.Choice>();

            using (CoCardDataContext bx = new CoCardDataContext())
            {

                var data = bx.MAS_FORM_CO_CARD_CHOICEs.Where(s => s.CAMPAIGN__ID == campaign_id && s.CFLAG == 0).OrderBy(s => s.CHOICE_NO).Select(s => new { s.CHOICE_NO, s.CHOICE_CAPTION }).ToList();

                foreach (var item in data)
                {
                    discount.Add(new CoCard.Choice { CHOICE_NO = item.CHOICE_NO, CHOICE_CAPTION = item.CHOICE_CAPTION });
                }

                return discount;
            }
        }


       

    }
}
