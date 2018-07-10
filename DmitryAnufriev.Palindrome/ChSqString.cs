using System.Collections.Generic;

namespace DmitryAnufriev.Palindrome
{
    public sealed class ChSqString : CharSequence
    {
        private readonly string _origin;

        public ChSqString(string origin)
        {
            _origin = origin;
        }

        public override IEnumerator<char> GetEnumerator()
        {
            foreach (var ch in _origin)
                yield return ch;
        }
    }
}