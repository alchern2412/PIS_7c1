using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DictionaryInterface;
using JsonRepo;
using Models;

namespace lab7_wcf_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DictionaryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DictionaryService.svc or DictionaryService.svc.cs at the Solution Explorer and start debugging.
    public class DictionaryService : IDictionaryService
    {
        IPhoneDictionary dictRepository = new JsonRepository();
        private static Random random = new Random();

        public void AddRecord(string name, string number)
        {
            Record record = new Record(random.Next(), name, number);
            dictRepository.AddRecord(record);
        }

        public void DelRecord(int id)
        {
            dictRepository.Delete(id);
        }

        public List<Record> GetRecords()
        {
            return dictRepository.GetRecords();
        }

        public void UpdRecord(int id, string name, string number)
        {
            Record record = new Record(id, name, number);
            dictRepository.Update(record);
        }
    }
}
