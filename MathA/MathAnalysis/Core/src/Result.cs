
namespace MathA.MathAnalysis.Core.src
{
    internal readonly struct Result(string val)
    {
        readonly string val = val ?? throw new ArgumentNullException(nameof(val));

        public override string ToString() => val;
    }
}
