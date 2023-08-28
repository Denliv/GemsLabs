using Task5.Exceptions;

namespace Task5.Models;

public class Rifle
{
    public bool FuseUp { get; set; }
    public Magazine RifleMag { get; set; }
    public Bullet? Chamber { get; private set; }

    public Rifle(Magazine magazine, bool fuseUp)
    {
        Chamber = null;
        FuseUp = fuseUp;
        RifleMag = magazine;
    }

    public bool IsLoaded()
    {
        return Chamber != null;
    }

    public void Reload()
    {
        if (FuseUp) throw new RifleException();
        Chamber = !RifleMag.IsEmpty() ? RifleMag.GetBullet() : null;
    }

    public bool Shot(out Bullet? bullet)
    {
        bullet = null;
        if (FuseUp || !IsLoaded()) return false;
        bullet = Chamber!;
        bullet.Use();
        Reload();
        return true;
    }
}