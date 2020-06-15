using NStandard;
using System;
using Xunit;

namespace Chinese.Test
{
    public class PinyinTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("qu4 ba1��pi2 ka3 qiu1��", Pinyin.Get("ȥ�ɣ�Ƥ����", PinyinFormat.Default));
            Assert.Equal("qu ba��pi ka qiu��", Pinyin.Get("ȥ�ɣ�Ƥ����", PinyinFormat.WithoutTone));
            Assert.Equal("q�� b����p�� k�� qi����", Pinyin.Get("ȥ�ɣ�Ƥ����", PinyinFormat.PhoneticSymbol));
        }
    }
}
