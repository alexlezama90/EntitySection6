using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            #region LINQ Extension Methods
            ////Restriction
            //var courses = context.Courses.Where(c => c.Level == 1);

            //foreach (var course in courses)
            //    System.Console.WriteLine(course.Name);

            ////Ordering
            //var courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderBy(c=>c.Name);

            //foreach (var course in courses)
            //    System.Console.WriteLine(course.Name);

            //System.Console.WriteLine("\nORDERED BY DESCENDING NAME AND THEN BY LEVEL\n");
            ////Ordering WITH ThenBy and Descending options
            //var courses = context.Courses
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c=>c.Level);

            //foreach (var course in courses)
            //    System.Console.WriteLine(course.Name);

            //Projection
            //var courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .Select(c => new { CourseName = c.Name, AuthorName = c.Author.Name});

            //foreach (var course in courses)
            //    System.Console.WriteLine("{0} by {1}", course.CourseName, course.AuthorName);

            ////Projection with Select
            //var courses = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .Select(c => c.Tags);

            //foreach (var c in courses)
            //{
            //    foreach (var tag in c)
            //        Console.WriteLine(tag.Name);
            //}

            //Projection with SelectMany
            //var tags = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .SelectMany(c => c.Tags);

            //foreach(var tag in tags)
            //    Console.WriteLine(tag.Name);

            //Set Operators
            //var tags = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .SelectMany(c => c.Tags)
            //    .Distinct();

            //foreach (var tag in tags)
            //    Console.WriteLine(tag.Name);

            ////Grouping
            //var groupsByLevel = context.Courses.GroupBy(c => c.Level);

            //foreach(var group in groupsByLevel)
            //{
            //    Console.WriteLine("Key: " + group.Key);

            //    foreach(var course in group)
            //        Console.WriteLine("\t" + course.Name);
            //}

            ////InnerJoin
            //var courseJoinAuthors = context.Courses.Join(context.Authors, 
            //    c => c.AuthorId, 
            //    a => a.Id, 
            //    (course, author) => new
            //{
            //    CoursName = course.Name,
            //    AuthorName = author.Name
            //});

            //foreach(var courseAuthor in courseJoinAuthors)
            //    Console.WriteLine("{0} by {1}", courseAuthor.CoursName, courseAuthor.AuthorName);

            ////GroupJoin
            //var results = context.Authors.GroupJoin(context.Courses,
            //    a => a.Id,
            //    c => c.AuthorId,
            //    (author, courses) => new
            //    {
            //        Author = author,
            //        //CoursesCount = courses.Count()
            //        Courses = courses
            //    });

            //foreach (var result in results)
            //{
            //    Console.WriteLine("{0} \t ({1})", result.Author.Name, result.Courses.Count());
            //}

            //CrossJoin
            //var crossResults = context.Authors.SelectMany(a => context.Courses,
            //    (author, course) => new
            //    {
            //        Author = author,
            //        Course = course
            //    });

            //Console.WriteLine(crossResults.Count());
            //foreach (var cross in crossResults)
            //    Console.WriteLine("{0} {1}", cross.Author.Name, cross.Course.Name);
            #endregion

            #region Additional Methods
            ////Partitioning
            //var coursesPage2= context.Courses.OrderBy(c=>c.Name).Skip(3).Take(10);
            //Console.WriteLine(coursesPage2.Count());

            ////Element Operators
            //var course = context.Courses.OrderBy(c => c.Level).First(); //If the table is empty we're going to get an exception
            //context.Courses.OrderBy(c => c.Level).FirstOrDefault(); //If the table is empty we're going to get null
            //context.Courses.OrderBy(c => c.Level).FirstOrDefault(c => c.FullPrice > 100); //We can give it conditions

            //context.Courses.Last();
            //context.Courses.LastOrDefault();

            //var course = context.Courses.Single(c => c.Id == 1);              //If the condition we supply in the Single or the SingleOrDefault 
            //var course = context.Courses.SingleOrDefault(c => c.Id == 1);     //Methods it will give an Exception

            ////Quantifying
            //var areALLAbove10Dollars = context.Courses.All(c => c.FullPrice > 10);
            //var isThereANYCourseOfLevel1= context.Courses.Any(c => c.Level == 1);

            //Aggregating
            //var count = context.Courses.Count();
            ////var count = context.Courses.Where(c=>c.Level==1).Count();   //context.Courses.Count(c=>c.Level ==1);
            //var max = context.Courses.Max(c => c.FullPrice); //context.Courses.Where(c=>c.Level==2).Max(c=>c.FullPrice);
            //Console.WriteLine(max);
            //var min = context.Courses.Min(c => c.FullPrice);
            //Console.WriteLine(min);
            //var avg =context.Courses.Average(c => c.FullPrice);
            //Console.WriteLine(avg);
            #endregion

            #region Deferred Execution & IQueryable Explained
            //IQueryable recibes expresions that are not executed untill the IQueryable collection will be iterated
            //IEnumerable collections expect a func or delegate, and will be executed inmediately

            //var courses = context.Courses;
            //IQueryable<Course> courses = context.Courses; //IQueryable is more efficient cause it allows to extend queries (It wont execute the query until iterated)
            //IEnumerable<Course> courses = context.Courses;  //IEnumerable will load ALL the courses and then we will filter the collection
            //var filtered = courses.Where(c => c.Level == 1);
            //foreach(var course in filtered)
            //{
            //    Console.WriteLine(course.Name);
            //}
            #endregion


        }
    }
}
