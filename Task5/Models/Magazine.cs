using Task5.Exceptions;

namespace Task5.Models;

public class Magazine
{
    public int Capacity { get; private set; }
    private readonly Stack<Bullet> _ammo;
    public int AmmoCount => _ammo.Count;

    public Magazine() : this(0)
    {
    }

    public Magazine(int ammoCount)
    {
        Capacity = 30;
        if (ammoCount < 0 || ammoCount > Capacity) throw new MagazineException();
        _ammo = new Stack<Bullet>(Capacity);
        for (int i = 0; i < ammoCount; ++i)
        {
            AddBullet(new Bullet());
        }
    }

    public Bullet? GetBullet()
    {
        return !_ammo.Any() ? null : _ammo.Pop();
    }

    public void AddBullet(Bullet bullet)
    {
        if (_ammo.Count == Capacity) throw new MagazineException();
        _ammo.Push(bullet);
    }
    
    public Bullet? Peek()
    {
        return !_ammo.Any() ? null : _ammo.Peek();
    }

    public bool IsEmpty()
    {
        return !_ammo.Any();
    }
}