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
  
  Quick IDisposible Example
  public class BooksLibrary : IDisposable
  {
  public List<Book> Library { get; set;}
  public void Dispose()
  {
  if (Library != null)
  {
  Library.Clear();
  Library = null;
  }
  }
  }
