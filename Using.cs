Using
Example "Using" as a Directive

"Using" to import namespace       "Using" to access static members             "Using" to create an alias for a namespace or type
using System.Math;                 without having to qualify the                using M = System.Math;
                                   access type                                  double pi = M.PI;
                                   using static System.Math;
                                   double pi = PI;

Examples "Using" as a Statement
IDisposable
       IDisposable is an interface that provides a mechanism to release unmanaged resources
                                                                            Dispose resources with using
  Quick IDisposible Example
  public class BooksLibrary : IDisposable                                   
  {                                                                       using (BooksLibrary currentLibrary = new                                                                                  
  public List<Book> Library { get; set;}                                  BooksLibrary())
  public void Dispose()                                                   {
  {                                                                        foreach (var book in currentLibrary.Library)
  if (Library != null)                                                     {
  {                                                                           if (book.Title == title)
  Library.Clear();                                                            {
  Library = null;                                                               return book;  
  }                                                                           }
  }                                                                         }
  }                                                                         return null;
Dispose resources without using                                           }
  BooksLibrary currentLibrary = null;                                     
try
{
  currentLibrary = new BooksLibrary();
  foreach (var book in currentLibrary.Library)
  {
    if (book.Title == title) return book;
  }
  return null;
}
catch (Exception)
{
  return null; //Handle Exception
} 
finally
{
if (currentLibrary != null)
  currentLibrary.Dispose(); 
}

