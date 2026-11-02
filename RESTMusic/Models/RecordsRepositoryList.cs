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

        private int nextId = 1;
       

     


    }
}

