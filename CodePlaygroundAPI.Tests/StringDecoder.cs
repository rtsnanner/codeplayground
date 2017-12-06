using CodePlayGround;
using System;
using Xunit;

namespace CodePlaygroundAPI.Tests
{
    public class StringDecoder
    {
        [Theory]
        [InlineData("banana" , "ba2[na]")]
        [InlineData("abcabcabc", "3[abc]")]
        [InlineData("abcdbdbsaaabcdbdbsaaabcdbdbsaaabab", "3[abc2[db]s2[a]]2[ab]")]
        public void DecodeStrings(string expectedDecode, string encodedString)
        {            
            Assert.Equal(expectedDecode, encodedString.DecodeString());
        }
    }
}
