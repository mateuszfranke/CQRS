namespace Test.Application.Queries.DTO
{
    public class BookDto
    {
        public string name { get; set; }
        public string author { get; set; }

        public BookDto(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }
}