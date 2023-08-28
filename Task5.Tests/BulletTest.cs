using MyUnit;
using MyUnit.Attributes;
using Task5.Exceptions;
using Task5.Models;

namespace Task5.Tests;

public class BulletTest
{
    [MyFact]
    public void BulletUsedTwice_ExceptionThrown()
    {
        Bullet bullet = new Bullet();
        bullet.Use();
        MyAssert.False(bullet.Usable);
        MyAssert.Throws<BulletUsingException>(() => bullet.Use());
    }
}