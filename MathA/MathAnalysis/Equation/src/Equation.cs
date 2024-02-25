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
        public Member RightSide { get; private set; }
        public string Variable { get; private set; } = "";

        public Result? Result => throw new NotImplementedException();

        public Equation(string equation) : this()
        {
            try
            {
                equation = FormatEqt(equation);
                LeftSide = new(MemberKind.Side, equation.Split('=')[0]);
                RightSide = new(MemberKind.Side, equation.Split('=')[1]);
                SplitEqtMember();
            }
            catch
            {

            }
        }

        void ISolver.Solve()
        {
            throw new NotImplementedException();
        }

        private static string FormatEqt(string eqt)
        {
            return Regex.Replace(eqt, "\\s+", " ");
        }

        readonly void SplitEqtMember()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            for (int i = 0; i < LeftSide.Result.ToString().Split(' ').Length; i++)
            {
                LeftSideMembers.Add(new Member(MemberKind.Term, LeftSide.Result.ToString().Split(' ')[i]));
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        void VarEx()
        {
            foreach (var member in LeftSideMembers)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                foreach (var v in member.Variable)
                {
                    if (Variable == v.ToString())
                    {
                        Variable = v.ToString();
                    }
                    else if(Variable != v.ToString() && Variable != "")
                    {
                         
                    }
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }
    }
}
