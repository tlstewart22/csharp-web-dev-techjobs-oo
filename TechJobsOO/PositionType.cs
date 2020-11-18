using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id &&
                   Value == type.Value;

            // I think that I need to add more here. 
            // 3. Assume that two PostionType objects are equal when their id fields match.
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Value);
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
