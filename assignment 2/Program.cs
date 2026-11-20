using System.Diagnostics;
using System.Text;
using System.Xml.Schema;
string title="clean code";
int pages = 464;
string UpperTitle=title.ToUpper();
Console.WriteLine(title);
Console.WriteLine(UpperTitle);
string title2 = "Clean Code";
string title1 = title2;
Console.WriteLine(object.ReferenceEquals(title1, title2));
StringBuilder sb=new StringBuilder();
sb.Append("Book List");
sb.Append("- Updated");
sb.Replace("- Updated", "Library");
Console.WriteLine(sb);
Console.WriteLine("Book:"+title2+pages);
Console.WriteLine($"Book:{title2}{pages}");
String result=String.Format("Book:{0}{1}",title2,pages);
Console.WriteLine(result);
if (pages > 300) {
    Console.WriteLine("Long Book");
}
else {
    Console.WriteLine("Short Book");}
bool isavailable=true;
if (pages > 300 && isavailable== true)
{

    Console.WriteLine("you can Borrow This Book ");
}
switch(title2)
{
    case "Clean Code":
        Console.WriteLine("Great Choice");
        break;
    case "Refactoring":
        Console.WriteLine("Nice Pick");
        break;
       
    default: Console.WriteLine("Never Heard Of It");
        break;
    }
String sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
String[]books= { " \n Clean Code", "The Pragamatic Progammer", "Refactoring" };
for (int i = 0; i <=2; i++)
{
    Console.WriteLine(books[i]);
}
int x=0;
while (x<books.Length)
{
    Console.WriteLine(books[x]);
        x++; }
int y = 0;
do
{
    Console.WriteLine(books[y]);
    y++;
}
while (y < books.Length)
;
foreach (var book in books)
{
    Console.WriteLine(book);
}
foreach (string book in books)
{
    if (book == "Refactoring")
    {
        break;
    }

    Console.WriteLine(book);
}
foreach (string book in books)
{
    if (book == "The Pragamatic Progammer")
    {
        continue;
    }

    Console.WriteLine(book);
}

void PrintFirstBook(string[]books)
{
    if (books.Length != 0)
    {
        Console.WriteLine(books[0]);
    }
}
PrintFirstBook(books);