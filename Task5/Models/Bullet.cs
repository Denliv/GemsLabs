using Task5.Exceptions;

namespace Task5.Models;

public class Bullet
{
    public bool Usable { get; private set; }

    public Bullet()
    {
        Usable = true;
    }

    public void Use()
    {
        if (Usable) Usable = false;
        else throw new BulletUsingException();
    }
}