using Xunit;

namespace Chinese.Test
{
    public class PinyinTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("mian3 fei4��kua4 ping2 tai1��kai1 yuan2��", Pinyin.GetString("��ѣ���ƽ̨����Դ��", PinyinFormat.Default));
            Assert.Equal("mian fei��kua ping tai��kai yuan��", Pinyin.GetString("��ѣ���ƽ̨����Դ��", PinyinFormat.WithoutTone));
            Assert.Equal("mi��n f��i��ku�� p��ng t��i��k��i yu��n��", Pinyin.GetString("��ѣ���ƽ̨����Դ��", PinyinFormat.PhoneticSymbol));
        }
    }
}
