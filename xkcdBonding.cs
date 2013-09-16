using Throwable = System.Exception;

class Ball : Throwable { }
class Person
{
    public Person() { }
    public Person AimAt { get; set; }
    public void Throw(Ball ball)
    {
        try
        {
            throw ball;
        }
        catch (Ball)
        {
            AimAt.Throw(ball);
        }
    }
}
class Bonding
{
    static void Main(string[] args)
    {
        var ball = new Ball();
        var parent = new Person();
        var child = new Person();
        child.AimAt = parent;
        parent.AimAt = child;

        parent.Throw(ball);
    }
}
