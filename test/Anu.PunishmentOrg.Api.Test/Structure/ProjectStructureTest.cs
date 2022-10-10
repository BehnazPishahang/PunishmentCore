//using Mono.Cecil;
using NetArchTest.Rules;
using NetArchTest.Rules.Policies;
using Xunit;

namespace Anu.PunishmentOrg.Api.Test.Structure
{
    /// <summary>
    /// برای مطالعه بیشتر در مورد تست نویسی برای ساختار های پروژه به لینک های زیر مراجعه شود
    /// https://www.ben-morris.com/writing-archunit-style-tests-for-net-and-c-for-self-testing-architectures/
    /// https://github.com/BenMorris/NetArchTest
    /// https://github.com/BenMorris/NetArchTest/blob/master/samples/NetArchTest.SampleRules/ExamplePolicies.cs
    /// </summary>
    public class ProjectStructureTest
    {
        [Fact]
        public void DataAccessClassName_ShouldendwithRepository()
        {
            var result = Types.InCurrentDomain()
                         .That().ResideInNamespace("Anu.PunishmentOrg.DataAccess")
                         .And().AreClasses()
                         .Should().HaveNameEndingWith("Repository")
                         .GetResult();

            Assert.True(result.IsSuccessful);
        }

        [Fact]
        public void DataAccessClassName_ShouldImplementIRepository()
        {
            var result = Types.InCurrentDomain()
                         .That().ResideInNamespace("Anu.PunishmentOrg.DataAccess")
                         .And().AreClasses()
                         .Should().ImplementInterface(typeof(Anu.Domain.IGenericRepository))
                         .GetResult();

            Assert.True(result.IsSuccessful);
        }

        [Fact]
        public void DataAccessClass_ShouldHaveRequiredDependencies()
        {
            var result = Types.InCurrentDomain()
                         .That().ResideInNamespace("Anu.PunishmentOrg.DataAccess")
                         .And().AreClasses()
                         .ShouldNot().HaveDependencyOnAll("Anu.DataAccess" , "Anu.DataAccess.Repositories", "Microsoft.EntityFrameworkCore")
                         .GetResult();

            Assert.True(result.IsSuccessful);
        }

        [Fact]
        public void DataAccessProject_ShouldHaveReference()
        {
            var result = Types.InCurrentDomain()
                              .Should()
                              .MeetCustomRule(new DataAccessRule())
                              .GetResult();

            Assert.True(result.IsSuccessful);
        }
    }

    public class DataAccessRule : ICustomRule
    {
        public bool MeetsRule(Mono.Cecil.TypeDefinition type)
        {

            var result = Types.InCurrentDomain()
                         .That().ResideInNamespace("Anu.PunishmentOrg.DataAccess")
                         .And().AreClasses()
                         .ShouldNot().HaveDependencyOnAll("Anu.DataAccess", "Anu.DataAccess.Repositories", "Microsoft.EntityFrameworkCore")
                         .GetResult();

            var dataAccessPolicy = Policy
                .Define("DataAccess", "DataAceess Sould Have Correct References")
                .For(Types.InCurrentDomain())
                .Add(t => t.That()
                           .ResideInNamespace("Anu.PunishmentOrg.DataAccess")
                           .ShouldNot()
                           .HaveDependencyOnAll("Anu.DataAccess", "Anu.DataAccess.Repositories", "Microsoft.EntityFrameworkCore"),
                            "DataAccess", 
                            "DataAceess Sould Have Correct References"
                );

            // var actualResult = dataAccessPolicy.Evaluate().HasViolations;
            var actualResult = result.IsSuccessful;
            return actualResult;
        }
    }
}