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

            #endregion
        }
    }
}
