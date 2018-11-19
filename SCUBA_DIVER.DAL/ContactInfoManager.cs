using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCUBA_DIVER.Models;

namespace SCUBA_DIVER.DAL
{
    public class ContactInfoManager
    {
        public List<ContactInfo> getContactInfo()
        {
            List<ContactInfo> myoutputlist = new List<ContactInfo>();
            using (ScubaDiveEntities ctx = new ScubaDiveEntities())
            {
                var query = from x in ctx.dive_contact_us
                            select new ContactInfo
                            {
                                Name = x.name,
                                Email = x.email,
                                Subject = x.subject,
                                Message = x.message
                            };


                myoutputlist = query.ToList<ContactInfo>();

            }

            return myoutputlist;
        }
        
        public void AddContactInfo(ContactInfo myinfo)
        {
           using(ScubaDiveEntities ctx = new ScubaDiveEntities())
            {
                dive_contact_us output = new dive_contact_us();

                output = Mapper(myinfo);

                try
                {
                    ctx.dive_contact_us.Add(output);
                    ctx.SaveChanges();
                }
                catch(Exception err)
                {
                    string error = err.InnerException.Message;
                    throw;
                }

                
            }
        }


        public dive_contact_us Mapper(ContactInfo mapinfo)
        {
            dive_contact_us output = new dive_contact_us();

            output.name = mapinfo.Name;
            output.email = mapinfo.Email;
            output.subject = mapinfo.Subject;
            output.message = mapinfo.Message;

            return output;
        }
        
    }
}
