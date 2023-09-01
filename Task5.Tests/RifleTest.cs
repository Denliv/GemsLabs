using MyUnit;
using MyUnit.Attributes;
using Task5.Exceptions;
using Task5.Models;

namespace Task5.Tests;

public class RifleTest
{
    [MyFact]
    public void Rifle_1B_WithoutFuse_TryReload_ResultRifleLoaded()
    {
        Rifle rifle = new Rifle(new Magazine(1), false);
        rifle.Reload();
        MyAssert.True(rifle.IsLoaded());
    }

    [MyFact]
    public void Rifle_1B_WithoutFuse_TryReloadTwice_ResultRifleNotLoaded()
    {
        Rifle rifle = new Rifle(new Magazine(1), false);
        rifle.Reload();
        rifle.Reload();
        MyAssert.False(rifle.IsLoaded());
    }

    [MyFact]
    public void Rifle_WithFuse_TryShot_ResultNothingHappened()
    {
        Rifle rifle = new Rifle(new Magazine(1), true);
        MyAssert.False(rifle.Shot(out var bullet));
    }

    [MyFact]
    public void Rifle_WithFuse_TryReload_ResultError()
    {
        Rifle rifle = new Rifle(new Magazine(1), true);
        MyAssert.Throws<RifleException>(() => rifle.Reload());
    }
    
    [MyFact]
    public void Rifle_WithoutFuse_TryShot_ResultNothingHappened()
    {
        Rifle rifle = new Rifle(new Magazine(1), false);
        MyAssert.False(rifle.Shot(out var bullet));
    }
    
    [MyFact]
    public void Rifle_WithoutFuse_Reload_TryShot_ResultUsedTheSameShellAsInChamber()
    {
        Magazine magazine = new Magazine(1);
        Rifle rifle = new Rifle(magazine, false);
        var bulletInChamber = magazine.Peek();
        rifle.Reload();
        rifle.Shot(out var bulletUsed);
        Assert.Same(bulletInChamber, bulletUsed);
    }
}