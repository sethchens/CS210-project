using System;

namespace Develop03 {
    public class Reference {
        private static string _reference;
        private int _referenceNumber;

        public Reference (string reference) {
            _referenceNumber = 1;
            _reference = reference;
        }

        public Reference (string reference, int verseNumber) {
            _reference = reference;
            _referenceNumber = verseNumber;
        }

        public static string ReturnReference() {
            return _reference;
        }
    }
}