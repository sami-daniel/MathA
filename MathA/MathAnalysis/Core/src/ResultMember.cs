
using MathA.MathAnalysis.Core.contracts;

namespace MathA.MathAnalysis.Core.src
{
    internal readonly struct ResultMember(string val) : IResult
    {
        readonly string val = val ?? throw new ArgumentNullException(nameof(val));

        public string Result => val;

        public override string ToString() => val;
    }
}
