using Bogus;

namespace GraphQL.Schema
{
    public class Query
    {

        public IEnumerable<CourseType> GetCourses()
        {
            Faker<CourseType> courseFaker = new Faker<CourseType>()
                .RuleFor(c=>c.Id, f=> Guid.NewGuid())
                .RuleFor(c => c.Name, f=> f.Name.JobTitle());

            List<CourseType> courses = courseFaker.Generate(5);
            return courses;

            //return new List<CourseType>()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "Geometry",
            //    Subject = Subject.Mathematics,
            //    Instructor = new InstructorType()
            //    {
            //        Id = Guid.NewGuid(),
            //    }
            //}
        }

        [GraphQLDeprecated("this query is depraceted")]
        public string Instructions => "Hello GraphQl!";
    }
}
