using SQLite;

namespace XamarinSqLiteApp
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public bool Subscribed { get; set; }
    }
}