using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using phonebook_web.Helpers;
using phonebook_web.Data;
using phonebook_data.phonebook_data;

namespace phonebook_web.Controllers
{
    public class PhonebookController : Controller
    {
        [Route("api/Phonebook/addNewEntry")]
        [HttpPost]
        public APIResponseObject<string, Exception> addNewEntry([FromBody]PhonebookEntry entry)
        {
            APIResponseObject<string, Exception> response = new APIResponseObject<string, Exception>();
            try
            {
                phonebookEntities _db = new phonebookEntities();
                string result = PhonebookHelper.addNewEntry(entry, _db);
                response.SuccessResponse = result;
            }
            catch (Exception e)
            {
                response.ErrorResponse = e.InnerException;
                response.ErrorMessage = e.Message;
            }

            return response;
        }

        [Route("api/Phonebook/getAllPhonebookRecords")]
        [HttpPost]
        public APIResponseObject<List<PhonebookEntry>, Exception> getAllPhonebookRecords()
        {
            APIResponseObject<List<PhonebookEntry>, Exception> response = new APIResponseObject<List<PhonebookEntry>, Exception>();
            try
            {
                phonebookEntities _db = new phonebookEntities();
                List<PhonebookEntry> results = PhonebookHelper.getAllPhonebookRecords(_db);
                response.SuccessResponse = results;
            }
            catch (Exception e)
            {

                response.ErrorResponse = e;
                response.ErrorMessage = "Error in retrieving the phonebook records.";
            }

            return response;
        }
    }

    public class PhonebookEntry
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class APIResponseObject<T, T2>
    {
        public T SuccessResponse { get; set; }
        public T2 ErrorResponse { get; set; }
        public string ErrorMessage { get; set; }
    }
}
