using MathA.MathAnalysis.Core.src.Enums;

namespace MathA.MathAnalysis.Core.src
{
    internal struct Member
    {
        private MemberKind kind;

        public readonly double Coefficient { get; }
        public readonly string CompValue { get; }
        public readonly string? Variable { get; }
        public MemberKind Kind { readonly get => kind; set => kind = value; }
    }
}
