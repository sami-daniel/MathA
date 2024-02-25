using MathA.MathAnalysis.Core.contracts;
using MathA.MathAnalysis.Core.src;

namespace MathA.MathAnalysis.Equation.src
{
    internal struct Equation
    {
        List<Member> LeftSideMembers = new List<Member>();
        List<Member> RightSideMember = new List<Member>();
        public Member LeftSide { get; private set; }
        public Member RightSide { get; private set;}
        public readonly string Variable { get; }
        
    }
}
