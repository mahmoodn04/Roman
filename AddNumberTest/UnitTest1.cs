using AddNumber;
namespace AddNumberTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Tests_should_be_empty_for_0()
    {
        Assert.AreEqual("", RomanConvertor.arabic(0));
    }
    [TestMethod]
    public void Tests_should_be_1_I()
    {
        Assert.AreEqual("I", RomanConvertor.arabic(1));
    }
    [TestMethod]
    public void Tests_should_be_2_II()
    {
        Assert.AreEqual("II", RomanConvertor.arabic(2));
    }
    [TestMethod]
    public void Tests_should_be_3_III()
    {
        Assert.AreEqual("III", RomanConvertor.arabic(3));
    }
    [TestMethod]
    public void Tests_should_be_4_IV()
    {
        Assert.AreEqual("IV", RomanConvertor.arabic(4));
    }
    [TestMethod]
    public void Tests_should_be_5_V()
    {
        Assert.AreEqual("V", RomanConvertor.arabic(5));
    }
    [TestMethod]
    public void Tests_should_be_6_VI()
    {
        Assert.AreEqual("VI", RomanConvertor.arabic(6));
    }
    [TestMethod]
    public void Tests_should_be_7_VII()
    {
        Assert.AreEqual("VII", RomanConvertor.arabic(7));
    }
    [TestMethod]
    public void Tests_should_be_8_VIII()
    {
        Assert.AreEqual("VIII", RomanConvertor.arabic(8));
    }
    [TestMethod]
    public void Tests_should_be_9_IX()
    {
        Assert.AreEqual("IX", RomanConvertor.arabic(9));
    }
    [TestMethod]
    public void Tests_should_be_10_X()
    {
        Assert.AreEqual("X", RomanConvertor.arabic(10));
    }
    [TestMethod]
    public void Tests_should_be_11_XI()
    {
        Assert.AreEqual("XI", RomanConvertor.arabic(11));
    }

    [TestMethod]
    public void Tests_should_be_12_XII()
    {
        Assert.AreEqual("XII", RomanConvertor.arabic(12));
    }

    [TestMethod]
    public void Tests_should_be_13_XIII()
    {
        Assert.AreEqual("XIII", RomanConvertor.arabic(13));
    }

    [TestMethod]
    public void Tests_should_be_14_XIV()
    {
        Assert.AreEqual("XIV", RomanConvertor.arabic(14));
    }

    [TestMethod]
    public void Tests_should_be_15_XV()
    {
        Assert.AreEqual("XV", RomanConvertor.arabic(15));
    }
    [TestMethod]
    public void Tests_should_be_16_XVI()
    {
        Assert.AreEqual("XVI", RomanConvertor.arabic(16));
    }
    [TestMethod]
    public void Tests_should_be_40_XL()
    {
        Assert.AreEqual("XL", RomanConvertor.arabic(40));
    }
    [TestMethod]
    public void Tests_should_be_50_L()
    {
        Assert.AreEqual("L", RomanConvertor.arabic(50));
    }
    
}