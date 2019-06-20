using System;
using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

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
            var crossResults = context.Authors.SelectMany(a => context.Courses,
                (author, course) => new
                {
                    Author = author,
                    Course = course
                });

            Console.WriteLine(crossResults.Count());
            foreach (var cross in crossResults)
                Console.WriteLine("{0} {1}", cross.Author.Name, cross.Course.Name);

        }
    }
}
