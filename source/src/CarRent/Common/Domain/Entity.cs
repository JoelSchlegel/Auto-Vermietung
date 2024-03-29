﻿namespace CarRent.Common.Domain
{
    public abstract class Entity
    {
        protected Entity()
            : this(Guid.NewGuid())
        {
        }
        internal Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Entity))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            if (GetType() != obj.GetType())
            {
                return false;
            }
            Entity item = (Entity)obj;
            return item.Id == Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
            {
                return (Object.Equals(right, null)) ? true : false;
            }
            else
            {
                return left.Equals(right);
            }
        }
        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}