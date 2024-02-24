using MathA.MathAnalysis.Core.src;

namespace MathA.MathAnalysis.Core.contracts
{
    internal interface ISolver
    {
        Result Result { get; }
        void Solve();
    }
}
