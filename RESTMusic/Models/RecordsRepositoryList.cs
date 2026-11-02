using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Reflection;

namespace RESTMusic.Models
{
    public class RecordsRepositoryList 
    {
        private List<Record> _recordsList = new List<Record>();
        public RecordsRepositoryList()
        {
            _recordsList = new List<Record>();
            {
                new Record { Id = nextId++, Title = "Er Her", Artist = "Artigeardit", Duration = 2.5, PublicationYear = 2022 };
                new Record { Id = nextId++, Title = "Sut Min Klit", Artist = "Nicoline", Duration = 3.5, PublicationYear = 2021 };
                new Record { Id = nextId++, Title = "Kinky Fætter", Artist = "Suspekt", Duration = 3.5, PublicationYear = 2015 };
                new Record { Id = nextId++, Title = "Kysset", Artist = "Drew Sycamore", Duration = 3.5, PublicationYear = 2020 };
                new Record { Id = nextId++, Title = "Ben", Artist = "Tessa", Duration = 3.5, PublicationYear = 2020 };
            }

        }

        public List<Record> GetAll(string Title = null, string SortBy = null)
        {
            List<Record> records = new(_recordsList);
            if (Title != null)
            {
                records = records.FindAll(r => r.Title.StartsWith(Title));
            }
            if (SortBy != null)
            {
                switch (SortBy.ToLower())
                {
                    case "Title":
                        records = records.OrderBy(r => r.Title).ToList();
                        break;
                    case "Artist":
                        records = records.OrderBy(r => r.Artist).ToList();
                        break;
                    case "Duration":
                        records = records.OrderBy(r => r.Duration).ToList();
                        break;
                    case "PublicationYear":
                        records = records.OrderBy(r => r.PublicationYear).ToList();
                        break;
                }

                
            }
            return _recordsList;
        }
        private int nextId = 1;
       
        



     


    }
}

