namespace ConsoleApplication1
{
    public interface IVector
    {
        double this[int i] { get; set; }
        int Length { get; }
        double GetNorm();
    }
}