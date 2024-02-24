using System.Data;

namespace MathA.MathAnalysis.Core.src.Statics
{
    internal static class MathB
    {
        public static double Evaluate(string expression)
        {
            DataTable table = new();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
    }
}
