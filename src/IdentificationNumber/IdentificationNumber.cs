using IdentificationNumber.Interfaces;
using IdentificationNumber.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificationNumber
{
    public abstract class IdentificationNumber<T> : IIdentificationNumber, IEqualityComparer<T>, IEquatable<T> where T : IdentificationNumber<T>
    {
        internal string _value;

        public abstract bool IsValid { get; }

        public abstract string ToFormalString();

        public override string ToString()
        {
            return _value;
        }

        protected abstract T ParseFromString(string value);

        public bool Equals(T x, T y)
        {
            try
            {
                return x.ToString() == y.ToString();
            }
            catch 
            { 
                return false; 
            }
        }

        public int GetHashCode(T obj)
        {
            return (obj.ToString() ?? string.Empty).GetHashCode();
        }

        public bool Equals(T other)
        {
            return _value == other.ToString();
        }
    }
}
