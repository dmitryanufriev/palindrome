using System.Collections.Generic;

namespace DmitryAnufriev.Palindrome
{
    public sealed class ChSqReversedString : CharSequence
    {
        private readonly string _origin;

        public ChSqReversedString(string origin)
        {
            _origin = origin;
        }

        public override IEnumerator<char> GetEnumerator()
        {
            var lastIndex = _origin.Length - 1;
            for (int i = lastIndex; i >= 0; i--)
                yield return _origin[i];
        }
    }
}