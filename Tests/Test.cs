using NUnit.Framework;
using WebApplication1;

[TestFixture]
public class Test
{
    [Test]
    public void NewStarsCanShine()
    {
        double shineFactor = 1d;
        Star star = new Star(shineFactor);
        //Assert.AreEqual(shineFactor, star.Shine());
        Assert.That(star.Shine(), Is.EqualTo(shineFactor));
    }

    [Test]
    public void FadedOutStarsCannotShine()
    {
        double shineFactor = 1.5d;
        Star star = new Star(shineFactor);
        star.FadeOut();
        Assert.Throws(typeof(InvalidOperationException), () => star.Shine());
    }

    [Test]
    public void StarsCanBeNAmes()
    {
        double shineFactor = 0.8d;
        Star star = new Star(shineFactor);
        star.Name = "Sun";

        //Assert.AreEqual("Sun", star.Name);
        Assert.That(star.Name, Is.EqualTo("Sun"));
    }
}