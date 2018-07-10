using System.Collections.Generic;

namespace DmitryAnufriev.Palindrome
{
    public sealed class ChSqLowered : CharSequence
    {
        private readonly CharSequence _origin;

        public ChSqLowered(CharSequence origin)
        {
            _origin = origin;
        }

        public override IEnumerator<char> GetEnumerator()
        {
            foreach (var ch in _origin)
                yield return char.ToLowerInvariant(ch);
        }
    }
}