using MathA.MathAnalysis.Core.src;

namespace MathA.MathAnalysis.Core.contracts
{
    internal interface Resolver
    {
        Result Result { get; }
        void Resolve();
    }
}
