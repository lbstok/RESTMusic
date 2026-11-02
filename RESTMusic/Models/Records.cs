namespace RESTMusic.Models
{

        public class Record
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public string? Artist { get; set; }
            public double Duration { get; set; }
            public int PublicationYear { get; set; }

        }
    
}
