using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{

    public class Beer
    {

        private List<string> _beers; 

        public Beer()
        {
            _beers = new List<string>();
        }
        public void Add(string beer) 
            => _beers.Add(beer);

        public List<string> Get()
            => _beers;
            

        public List<string> GetReport()
        {
            var report = new List<string>();

            foreach (var beer in _beers)
            {
                report.Add("Cerveza: " + beer); 
            }
            return report;  
        }

        public void SaveReport(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var beer in _beers) {

                    writer.WriteLine(beer); 
                
                }
            }
        }
    }
}
