namespace excaption;

public class CostumExcaption : Exception
{
    public CostumExcaption()
    {
    }
    public CostumExcaption(string message)
        : base(message)
    {
        
    }

}
