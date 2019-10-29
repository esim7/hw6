using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace homeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-RM1NBDJ;Database=MyLibrary;Trusted_Connection=True;";

            //Book firstBook = new Book
            //{
            //    Name = "Война и мир",
            //    Author = "Л.Н. Толстой"
            //};
            //Book secondBook = new Book
            //{
            //    Name = "Неви­дим­ка",
            //    Author = "Р. Элли­сон"
            //};
            //Book thirdBook = new Book
            //{
            //    Name = "Путе­ше­ст­вия Гул­ли­ве­ра",
            //    Author = "Д. Свифт"
            //};
            //Book fourthBook = new Book
            //{
            //    Name = "Вин­ни-Пух",
            //    Author = "А. Милн"
            //};
            //Book fifthBook = new Book
            //{
            //    Name = "Гам­лет",
            //    Author = "У. Шекспир"
            //};
            //Book sixthBook = new Book
            //{
            //    Name = "Вто­рая миро­вая война",
            //    Author = "У. Черчилль"
            //};

            //Visitor firstVisitor = new Visitor
            //{
            //    FullName = "Иванов Т. И.",
            //    Address = "г. Астана ул. Ташенова 6/1"
            //};
            //Visitor secondVisitor = new Visitor
            //{
            //    FullName = "Сидоров А. В.",
            //    Address = "г. Астана ул. Ауэзова 16/4"
            //};
            //Visitor thirdVisitor = new Visitor
            //{
            //    FullName = "Федоров А. Г.",
            //    Address = "г. Астана ул. Петрова 8/17"
            //};
            //Visitor fourthVisitor = new Visitor
            //{
            //    FullName = "г. Астана м-он Коктал 17",
            //    Address = "А. Милн"
            //};
            //Visitor fifthVisitor = new Visitor
            //{
            //    FullName = "Путин В. В.",
            //    Address = "г. Астана ул. Бараева 18/9"
            //};
            //Visitor sixthVisitor = new Visitor
            //{
            //    FullName = "Назарбаев Н. А.",
            //    Address = "г. Астана м-он Самал 3/2"
            //};
            //Debtor firstDebtor = new Debtor
            //{
            //    VisitorId = firstVisitor.Id,
            //    BookId = firstBook.Id,
            //    VisitorName = firstVisitor.FullName,
            //    BookName = firstBook.Name,
            //    Description = "Состояние книги новое"
            //};
            //Debtor secondDebtor = new Debtor
            //{
            //    VisitorId = secondVisitor.Id,
            //    BookId = secondBook.Id,
            //    VisitorName = secondVisitor.FullName,
            //    BookName = secondBook.Name,
            //    Description = "Состояние книги удовлетворительное"
            //};
            //Debtor thirdDebtor = new Debtor
            //{
            //    VisitorId = thirdVisitor.Id,
            //    BookId = thirdBook.Id,
            //    VisitorName = thirdVisitor.FullName,
            //    BookName = thirdBook.Name,
            //    Description = "Состояние книги хорошее"
            //};
            //Debtor fourthDebtor = new Debtor
            //{
            //    VisitorId = fourthVisitor.Id,
            //    BookId = fourthBook.Id,
            //    VisitorName = fourthVisitor.FullName,
            //    BookName = fourthBook.Name,
            //    Description = "Состояние книги удовлетворительное"
            //};
            //Debtor fifthDebtor = new Debtor
            //{
            //    VisitorId = fifthVisitor.Id,
            //    BookId = fifthBook.Id,
            //    VisitorName = fifthVisitor.FullName,
            //    BookName = fifthBook.Name,
            //    Description = "Состояние книги новое"
            //};
            //Debtor sixthDebtor = new Debtor
            //{
            //    VisitorId = sixthVisitor.Id,
            //    BookId = sixthBook.Id,
            //    VisitorName = sixthVisitor.FullName,
            //    BookName = sixthBook.Name,
            //    Description = "Книга очеь старая"
            //};
            //using (var context = new LibraryContext(connectionString))
            //{
            //    context.books.Add(firstBook);
            //    context.books.Add(secondBook);
            //    context.books.Add(thirdBook);
            //    context.books.Add(fourthBook);
            //    context.books.Add(fifthBook);
            //    context.books.Add(sixthBook);
            //    context.visitors.Add(firstVisitor);
            //    context.visitors.Add(secondVisitor);
            //    context.visitors.Add(thirdVisitor);
            //    context.visitors.Add(fourthVisitor);
            //    context.visitors.Add(fifthVisitor);
            //    context.visitors.Add(sixthVisitor);
            //    context.debtors.Add(firstDebtor);
            //    context.debtors.Add(secondDebtor);
            //    context.debtors.Add(thirdDebtor);
            //    context.debtors.Add(fourthDebtor);
            //    context.debtors.Add(fifthDebtor);
            //    context.debtors.Add(sixthDebtor);
            //    context.SaveChanges();

            //}
            bool isActive = true;
            string key;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Вывести список должников \n2. Вывести список авторов книги № 3 \n3.  Выведите список книг, которые доступны в данный момент" +
                    "\n4. Вывести список книг, которые на руках у пользователя № 2\n5. Обнулить задолженности всех должников \n6. Выйти");
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        {
                            using (var context = new LibraryContext(connectionString))
                            {
                                var debtorResult = context.debtors;
                                Console.WriteLine("Список должников");
                                foreach (var debtor in debtorResult)
                                {
                                    Console.WriteLine("Id должника: " + debtor.VisitorName);
                                    Console.WriteLine("Id книги: " + debtor.BookName);
                                    Console.WriteLine("-----------------------------------------");
                                }
                            }
                        }
                        break;
                    case "2":
                        {
                            using (var context = new LibraryContext(connectionString))
                            {
                                var books = context.books.ToList();
                                var book = books.ElementAt(2);
                                Console.WriteLine("Cписок авторов книги № 3: " + book.Author);
                            }
                        }
                        break;
                    case "3":
                        {
                            using (var context = new LibraryContext(connectionString))
                            {
                                var books = context.books;
                                var debts = context.debtors;
                                    var result = from a in books
                                                 join b in debts on a.Id equals b.BookId
                                                 select new
                                                 {
                                                     a.Name,
                                                     b.Description
                                                 };
                                foreach(var res in result)
                                {
                                    Console.WriteLine(res.Name + res.Description);
                                }
                            }
                        }
                        break;
                    case "4":
                        {
                            using (var context = new LibraryContext(connectionString))
                            {
                                var visitors = context.visitors.ToList();
                                var visitor = visitors.ElementAt(1);
                                var debts = context.debtors;

                                foreach (var debt in debts)
                                {
                                    if (debt.VisitorId.ToString().Contains(visitor.Id.ToString()))
                                    {
                                        Console.WriteLine("У пользователя №2 на руках книги: " + debt.BookName);
                                    }
                                    else
                                    {
                                        continue;
                                    } 
                                }
                            }
                        }
                        break;
                    case "5":
                        {
                            using (var context = new LibraryContext(connectionString))
                            {
                                var debtors = context.debtors.ToList();
                                for (int i = 0; i < context.debtors.Count(); i++)
                                    context.debtors.Remove(debtors[i]);
                                context.SaveChanges();
                            }
                        }
                        break;
                    case "6":
                        {
                            isActive = false;
                        }
                        break;
                }
                Console.ReadLine();
            } while (isActive != false);
        }
    }
}
