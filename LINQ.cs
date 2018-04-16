[Table("Books")]
class Book
{
[Column(IsPrimaryKey = true)]
public string Asin {get; set;}

public string Title {get; set;}

public string Author { get; set; }

}

var results = new List<string>();
foreach (var book in Books)
     if(book.PublishDate > DateTime.Now.AddYears(-1))
     results.Add(book.Title);

var results = Books.Where(book => book.PublishDate > DateTime.Now.AddYears(-1))
                   .Select(book => book.Title);
                   
var results = from book in Books
              where book.PublishDate > DateTime.Now.AddYears(-1)
              select book.Title
