using System;
using System.Collections;
using System.Collections.Generic;

namespace DmitryAnufriev.Palindrome
{
    public abstract class CharSequence : IEnumerable<char>, IEquatable<CharSequence>
    {
        public abstract IEnumerator<char> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Equals(CharSequence other)
        {
            if (other == null)
                return false;
            bool x, y;
            using (var otherEnumerator = other.GetEnumerator())
            using (var selfEnumerator = GetEnumerator())
                while ((x = selfEnumerator.MoveNext()) & (y = otherEnumerator.MoveNext()))
                    if (selfEnumerator.Current != otherEnumerator.Current)
                        return false;
            return !x && !y;
        }
    }
}