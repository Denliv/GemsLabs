using MyUnit;
using MyUnit.Attributes;
using Task5.Exceptions;
using Task5.Models;

namespace Task5.Tests;

public class MagazineTest
{
    [MyFact]
    public void TakeBulletFromEmptyMagazine_ReturnsNull()
    {
        Magazine magazine = new Magazine();
        MyAssert.True(null == magazine.GetBullet());
    }
    
    [MyFact]
    public void AddBulletToEmptyMag_NumberPlusOne()
    {
        Magazine magazine = new Magazine();
        magazine.AddBullet(new Bullet());
        MyAssert.True(1 == magazine.AmmoCount);
    }
    
    [MyInlineData(1)]
    [MyInlineData(15)]
    [MyInlineData(29)]
    public void AddBulletToNonEmptyMag_NumberPlusOne(int n)
    {
        Magazine magazine = new Magazine(n);
        magazine.AddBullet(new Bullet());
        MyAssert.True(n + 1 == magazine.AmmoCount);
    }
    
    [MyFact]
    public void AddBulletToFullMag_Error()
    {
        Magazine magazine = new Magazine(30);
        MyAssert.Throws<MagazineException>(() => magazine.AddBullet(new Bullet()));
    }
}