using Task5.Exceptions;

namespace Task5.Models;

public class Rifle
{
    public bool FuseUp { get; set; }
    private Magazine _rifleMag;
    private Bullet? _chamber;

    public Rifle(Magazine magazine, bool fuseUp)
    {
        _chamber = null;
        FuseUp = fuseUp;
        _rifleMag = magazine;
    }

    public bool IsLoaded()
    {
        return _chamber != null;
    }

    public void Reload()
    {
        if (FuseUp) throw new RifleException();
        _chamber = !_rifleMag.IsEmpty() ? _rifleMag.GetBullet() : null;
    }

    public bool Shot(out Bullet? bullet)
    {
        bullet = null;
        if (FuseUp || !IsLoaded()) return false;
        bullet = _chamber!;
        bullet.Use();
        Reload();
        return true;
    }
}