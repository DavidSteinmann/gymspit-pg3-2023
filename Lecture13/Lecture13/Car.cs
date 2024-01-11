
class Car
{
    public string Model;
    public string Color;

    public float Speed;
    public bool Started;

    public void Start()
    {
        Started = true;
    }

    public void ShutDown()
    {
        Started = false;
    }

    public void GetGoing()
    {
        if (!Started)
        {
            return;
        }

        Speed = 30;
    }

    public void StopGoing()
    {
        Speed = 0;
    }

    public void Accelerate()
    {
        if (!Started)
        {
            return;
        }

        Speed += 10;
    }

    public void Accelerate(float speed)
    {
        if (!Started)
        {
            return;
        }

        if (speed < 0)
        {
            return;
        }    

        Speed += speed;
    }

    public void SlowDown()
    {
        if (!Started)
        {
            return;
        }

        if (Speed <= 0)
        {
            return;
        }

        Speed -= 10;
    }

    public void PrintState()
    {
        Thread.Sleep(500);
        Console.WriteLine("Car state:");
        Console.WriteLine(Started);
        Console.WriteLine(Speed);
    }
}