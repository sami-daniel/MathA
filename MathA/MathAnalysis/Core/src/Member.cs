using MathA.MathAnalysis.Core.contracts;
using MathA.MathAnalysis.Core.src.Enums;
using MathA.MathAnalysis.Core.src.Statics;

namespace MathA.MathAnalysis.Core.src
{
    internal struct Member : ISolver
    {
        public readonly MemberKind Kind { get; }
        public double Coefficient { get; private set; }
        public readonly string CompValue { get; }
        public string? Variable { get; private set; }
        public Result? Result { get; private set; }

        public Member(MemberKind _kind, string compValue) : this()
        {
            Kind = _kind;
            CompValue = compValue ?? throw new ArgumentNullException(nameof(compValue));
            try
            {
                this.SolveR();
            }
            catch
            {
                ConfigV();
            }
        }

        void ConfigV()
        {
            var coe = "";
            foreach (var c in CompValue)
            {
                if (char.IsDigit(c))
                {
                    coe += c;
                }
                else if (char.IsLetter(c))
                {
                    if (Variable != c.ToString())
                    {

                    }
                    else
                    {
                        Variable = c.ToString();
                    }
                }
                else
                {

                }
            }
        }

        void ISolver.Solve()
        {
            SolveR();
        }
        void SolveR()
        {
            try
            {
                Result = new(MathB.Evaluate(CompValue).ToString());
                Coefficient = MathB.Evaluate(CompValue);
            }
            catch
            {
                Result = new(CompValue);
            }
        }

        public override string ToString()
        {
            return CompValue + ", kind of" + Kind.ToString();
        }
    }
}
