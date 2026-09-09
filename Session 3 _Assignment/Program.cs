using System.Text;

namespace Session_3__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ANSWER 1
            #region String 
            string Title = "clean code";
            string upperTitle = Title.ToUpper();

            Console.WriteLine(upperTitle); //  هنا هيطلع الكود كله حلاوف كبيره       
            Console.WriteLine(Title); //  هيطلع الكود زي م هو 
            Console.WriteLine(Title.GetHashCode());
            Console.WriteLine(upperTitle.GetHashCode()); //  هنا عاوز اشوف هل العنوان قيمته اتغيرت ولا لا 
            Console.WriteLine(ReferenceEquals(Title, upperTitle)); //  هنا هيطلع false لانهم مش نفس العنوان

            #endregion
            // ANSWER 2
            #region referenceEquals
            string name1 = "clean code";
            string name2 = "clean code";
            Console.WriteLine(ReferenceEquals(name1, name2)); //  هنا هيطلع true لانهم نفس العنوان
            #endregion
            // ANSWER 3
            #region StringBuilder
            

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb);
            #endregion
        }

    }
}
