using MathA.MathAnalysis.Core.contracts;
using MathA.MathAnalysis.Core.src.Enums;
using MathA.MathAnalysis.Core.src.Exceptions;
using MathA.MathAnalysis.Core.src.Statics;

namespace MathA.MathAnalysis.Core.src
{
    internal struct Member : ISolver
    {
        public readonly static List<char> permitOperator = ['+', '-', '/', '*'];
        public readonly static List<char> permitSymbols = ['(',')'];
        public readonly MemberKind Kind { get; }
        public double Coefficient { get; private set; }
        public readonly string CompValue { get; }
        public string? Variable { get; private set; }
        public Result? Result { get; private set; }

        public Member(MemberKind _kind, string compValue) : this()
        {
            Kind = _kind;
            Variable = "";
            Coefficient = 0d;
            CompValue = compValue ?? throw new ArgumentNullException(nameof(compValue) + "is null");
            try
            {
                ConfigV();
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
                    if (Variable != c.ToString() && Variable != "")
                    {
                        throw new InvalidCharactersInExpressionException(Variable + c + " is invalid. " +
                        "Check github.com https://github.com/sami-daniel/MathA to use correctly");
                    }
                    else
                    {
                        Variable = c.ToString();
                    }
                }
                else if(permitOperator.Any(ch => ch == c))
                {
                    coe += c;
                }
                else if(!permitOperator.Any(ch => ch == c) && !permitSymbols.Any(ch => ch == c))
                {
                    throw new InvalidCharactersInExpressionException(Variable + c + " is invalid. " +
                       "Check github.com https://github.com/sami-daniel/MathA to use correctly");
                }
            }
            Coefficient = Convert.ToDouble(coe);
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
                Result = new(Coefficient.ToString());
            }
        }

        public override string ToString()
        {
            return Result + ", kind of " + Kind.ToString() + "-type";
        }
    }
}
