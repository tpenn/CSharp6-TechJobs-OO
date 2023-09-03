﻿using System;
namespace TechJobsOOAutoGraded6
{
	public abstract class JobField
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}

