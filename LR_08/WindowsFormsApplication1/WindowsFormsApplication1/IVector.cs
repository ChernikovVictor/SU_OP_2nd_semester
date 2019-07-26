using System;

namespace WindowsFormsApplication1
{
    public interface IVector : IComparable, ICloneable
    {
        double this[int i] { get; set; }
        int Length { get; }
        double GetNorm();
    }
}