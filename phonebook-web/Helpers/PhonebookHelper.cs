using phonebook_web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using phonebook_web.Data;
using phonebook_data.phonebook_data;

namespace phonebook_web.Helpers
{
    public class PhonebookHelper
    {

        public static string addNewEntry(PhonebookEntry entry, phonebookEntities _db)
        {
			try
			{

				//Check if number exists in the database. Under the assumption that a number is always unique.
				bool numberExists = _db.Phonebooks.Where(rec => rec.PhoneNumber == entry.PhoneNumber).Any();

				if(!numberExists)
				{
					//Create new entry if the number doesn't exist.
					Phonebook newEntry = new Phonebook();

					newEntry.Name = entry.Name;
					newEntry.PhoneNumber = entry.PhoneNumber;

					_db.Phonebooks.Add(newEntry);
					_db.SaveChanges();


				} else
				{
					throw new Exception("Number already exists in the database");
				}
				
				

				return "Phonebook entry saved sucessfully";
			}
			catch (Exception e)
			{

				throw e;
			}
        }

		public static List<PhonebookEntry> getAllPhonebookRecords(phonebookEntities _db)
		{
			try
			{
				List<PhonebookEntry> phonebookEntries = _db.Phonebooks.Select(rec => new PhonebookEntry
				{
					Name = rec.Name,
					PhoneNumber = rec.PhoneNumber

				}).OrderBy(r => r.Name).ToList();

				return phonebookEntries;
			}
			catch (Exception e)
			{

				throw e;
			}
		}


	}
}
