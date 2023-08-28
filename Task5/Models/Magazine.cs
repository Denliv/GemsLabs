using Task5.Exceptions;

namespace Task5.Models;

public class Magazine
{
    public int Capacity { get; private set; }

    public Stack<Bullet> Ammo { get; private set; }

    public Magazine() : this(0)
    {
    }

    public Magazine(int ammoCount)
    {
        Capacity = 30;
        if (ammoCount < 0 || ammoCount > Capacity) throw new MagazineException();
        Ammo = new Stack<Bullet>(Capacity);
        for (int i = 0; i < ammoCount; ++i)
        {
            AddBullet(new Bullet());
        }
    }

    public Bullet? GetBullet()
    {
        if (!Ammo.Any()) return null;
        return Ammo.Pop();
    }

    public void AddBullet(Bullet bullet)
    {
        if (Ammo.Count == Capacity) throw new MagazineException();
        Ammo.Push(bullet);
    }

    public bool IsEmpty()
    {
        return !Ammo.Any();
    }
}