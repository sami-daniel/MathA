using MathA.MathAnalysis.Core.contracts;
using MathA.MathAnalysis.Core.src;
using MathA.MathAnalysis.Core.src.Enums;
using System.Text.RegularExpressions;

namespace MathA.MathAnalysis.Equation.src
{
    internal struct Equation : ISolver
    {
        List<Member> LeftSideMembers = [];
        List<Member> RightSideMember = [];
        public Member LeftSide { get; private set; }
        public Member RightSide { get; private set;}
        public readonly string Variable { get; }

        public Result? Result => throw new NotImplementedException();

        public Equation(string equation) : this()
        {
            equation = FormatEqt(equation);
            LeftSide = new(MemberKind.Side, equation.Split('=')[0]);
            RightSide = new(MemberKind.Side, equation.Split('=')[1]);
        }

        public void Solve()
        {
            throw new NotImplementedException();
        }

        string FormatEqt(string eqt) => Regex.Replace(eqt, "\\s+", " ");

    }
}
