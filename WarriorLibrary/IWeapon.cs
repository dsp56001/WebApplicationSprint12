namespace DIDemo
{
    public interface IWeapon
    {
        string Name { get; }
        string Hit(string target);
    }
}