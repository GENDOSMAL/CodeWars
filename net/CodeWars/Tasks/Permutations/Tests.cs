using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace Tasks.Permutations
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Example1()
        {
            Assert.AreEqual(new List<string> { "a" }, Impl.SinglePermutations("a").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example2()
        {
            Assert.AreEqual(new List<string> { "ab", "ba" }, Impl.SinglePermutations("ab").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example3()
        {
            Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, Impl.SinglePermutations("aabb").OrderBy(x => x).ToList());
        }
    }
}