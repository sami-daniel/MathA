using MathA.MathAnalysis.Core.src;

namespace MathA.MathAnalysis.Core.contracts
{
    internal interface ISolver
    {
        ResultMember? Result { get; }
        void Solve();
    }
}
