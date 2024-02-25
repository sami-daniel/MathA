using MathA.MathAnalysis.Core.contracts;
using MathA.MathAnalysis.Core.src;
using MathA.MathAnalysis.Core.src.Enums;

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
            
        }

        public void Solve()
        {
            throw new NotImplementedException();
        }

    }
}
