using System;
using System.Data;

namespace TechJobsOOAutoGraded6
{
	public class Job
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string name = (string.IsNullOrWhiteSpace(Name) ? "Data not available" : Name);
            string employerName = (EmployerName is Employer emp && !string.IsNullOrWhiteSpace(emp.Value) ? emp.Value : "Data not available");
            string employerLocation = (EmployerLocation is Location loc && !string.IsNullOrWhiteSpace(loc.Value) ? loc.Value : "Data not available");
            string jobType = (JobType is PositionType pos && !string.IsNullOrWhiteSpace(pos.Value) ? pos.Value : "Data not available");
            string jobCoreCompetency = (JobCoreCompetency is CoreCompetency cmp && !string.IsNullOrWhiteSpace(cmp.Value) ? cmp.Value : "Data not available");

            return $"\nID: {Id}\nName: {name}\nEmployer: {employerName}\nLocation: {employerLocation}\nPosition Type: {jobType}\nCore Competency: {jobCoreCompetency}\n";
        }

    }
}

