using BookStore.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var books = new List<BookDto>
{
    new(
        1,
        "Clean Code",
        "Robert C. Martin",
        45.99m,
        new DateOnly(2008, 8, 1),
        "Software Engineering"
    ),
    new(
        2,
        "The Pragmatic Programmer",
        "David Thomas & Andrew Hunt",
        39.99m,
        new DateOnly(2019, 9, 13),
        "Software Engineering"
    ),
    new(
        3,
        "Design Patterns",
        "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
        54.50m,
        new DateOnly(1994, 10, 31),
        "Software Engineering"
    ),
    new(
        4,
        "The Hobbit",
        "J.R.R. Tolkien",
        24.99m,
        new DateOnly(1937, 9, 21),
        "Fantasy"
    ),
    new(
        5,
        "Harry Potter and the Philosopher's Stone",
        "J.K. Rowling",
        29.99m,
        new DateOnly(1997, 6, 26),
        "Fantasy"
    ),
    new(
        6,
        "1984",
        "George Orwell",
        19.99m,
        new DateOnly(1949, 6, 8),
        "Dystopian"
    ),
    new(
        7,
        "The Great Gatsby",
        "F. Scott Fitzgerald",
        18.50m,
        new DateOnly(1925, 4, 10),
        "Classic Fiction"
    ),
    new(
        8,
        "The Alchemist",
        "Paulo Coelho",
        21.99m,
        new DateOnly(1988, 1, 1),
        "Philosophical Fiction"
    ),
    new(
        9,
        "Atomic Habits",
        "James Clear",
        27.99m,
        new DateOnly(2018, 10, 16),
        "Self-Help"
    ),
    new(
        10,
        "The Psychology of Money",
        "Morgan Housel",
        22.99m,
        new DateOnly(2020, 9, 8),
        "Personal Finance"
    )
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/Books",() => books);



app.Run();
