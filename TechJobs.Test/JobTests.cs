
namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing objects
        Job job1 = new Job();
        Job job2 = new Job();
        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));        //Testing Objects

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.AreEqual(1, job2.Id - job1.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job3, job4);
        }
    }
}

