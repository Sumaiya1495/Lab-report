using System;

public class Book
{
    public string Title;
    public string AuthorName;
    public double ISBN;
    public double Price;
    public Book()
    {
        Title="Unknown";
        AuthorName="N/A";
        ISBN=0;
        Price=0.0;
    }
    public Book(string _title,string _name)
    {
        Title=_title;
        AuthorName=_name; 
    }
    public Book( string _title,string _name,double _isbn)
    {
        Title=_title;
        AuthorName=_name; 
        ISBN=_isbn;
    }
     public Book( string _title,string _name,double _isbn, double _price)
     {
        Title=_title;
        AuthorName=_name; 
        ISBN=_isbn;
        Price=_price;
     }
     public void Print()
     {
         Console.WriteLine("Title:"+ Title);
         Console.WriteLine("Name:"+ AuthorName);
         Console.WriteLine("ISBN:" +ISBN);
          Console.WriteLine("Price:"+ Price);
     }
     static void Main()
     {
         Book b1=new Book();
         Book b2=new Book("Harry Potter","J.K Rwwling");
         Book b3=new Book("Harry Potter","J.K Rwwling", 074754624);
         Book b4=new Book("Harry Potter","J.K Rwwling", 074754624 , 2000);
         b1.Print();
         b2.Print();
         b3.Print();
         b4.Print();
     }
}
