namespace RESTMusic.Models
{
    public interface IRecordsRepository
    {

        Record AddRecord(Record record);
        List<Record> GetAll(string Title = null, string SortBy = null);

        Record? GetRecordById(int id);
        Record DeleteById(int id);
        Record UpdateById(int id, Record value);
    }
}
