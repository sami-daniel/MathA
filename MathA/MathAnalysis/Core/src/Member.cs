using MathA.MathAnalysis.Core.src.Enums;

namespace MathA.MathAnalysis.Core.src
{
    internal readonly struct Member
    {
        public MemberKind Kind { get; }
        public double Coefficient { get; }
        public string CompValue { get; }
        public string? Variable { get; }

        public Member(MemberKind _kind, double coefficient, string compValue, string? variable) : this()
        {
            Kind = _kind;
            Coefficient = coefficient;
            CompValue = compValue ?? throw new ArgumentNullException(nameof(compValue));
            Variable = variable;
        }
    }
}
