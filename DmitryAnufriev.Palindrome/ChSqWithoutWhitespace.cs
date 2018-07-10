using System.Collections.Generic;

namespace DmitryAnufriev.Palindrome
{
    public sealed class ChSqWithoutWhitespace : CharSequence
    {
        private readonly CharSequence _origin;

        public ChSqWithoutWhitespace(CharSequence origin)
        {
            _origin = origin;
        }

        public override IEnumerator<char> GetEnumerator()
        {
            foreach (var ch in _origin)
                if (!char.IsWhiteSpace(ch))
                    yield return ch;
        }
    }
}