using Xunit;

namespace Chinese.Test
{
    public class PinyinTest
    {
        [Fact]
        public void Test1()
        {
            var str = "��ѣ���ƽ̨����Դ��";
            Assert.Equal("mian3 fei4��kua4 ping2 tai1��kai1 yuan2��", Pinyin.GetString(str, PinyinFormat.Default));
            Assert.Equal("mian fei��kua ping tai��kai yuan��", Pinyin.GetString(str, PinyinFormat.WithoutTone));
            Assert.Equal("mi��n f��i��ku�� p��ng t��i��k��i yu��n��", Pinyin.GetString(str, PinyinFormat.Phonetic));
            Assert.Equal("mf��kpt��ky��", Pinyin.GetString(str, PinyinFormat.Code));
        }

        [Fact]
        public void ChineseLexiconTest()
        {
            var str = "����������ѡ�֡�";
            Assert.Equal("ta1 shi4 chong2 liang2 ji2 shua1 shou3��", Pinyin.GetString(str, PinyinFormat.Default));

            var words = new ChineseWord[]
            {
                new ChineseWord { Pinyins = new[] { "zhong4 liang4" }, Simplified = "����", Traditional = "����" },
            };

            using (new ChineseLexicon(BuiltinWords.Basic, words))
            {
                Assert.Equal("ta1 shi4 zhong4 liang4 ji2 shua1 shou3��", Pinyin.GetString(str, PinyinFormat.Default));
            }
        }

    }
}
