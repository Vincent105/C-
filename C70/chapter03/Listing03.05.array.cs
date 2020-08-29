namespace chapter03
{
    internal class Class0305
    {
        private static void Main0305()
        {
            string[] languages1; // one - dimensional
            int[,] cells;        // two - dimensional

            //選告陣列時同時賦值
            string[] languages2 = { "C#", "COBAL", "Python", "C++", "J#", "Pascal" };

            //宣告陣列後 再進行賦值
            string[] languages3;
            languages3 = new string[] { "C#", "COBAL", "Python", "C++", "J#", "Pascal" };

            //宣告陣列時 進行賦值
            string[] languages4 = new string[6] { "C#", "COBAL", "Python", "C++", "J#", "Pascal" };

            //分配陣列 但不提供初始值
            string[] languages5 = new string[6];

            //運行時 確定陣列大小
            string[] grocerylist;
            System.Console.Write("how many items?");
            int size = int.Parse(System.Console.ReadLine());
            grocerylist = new string[size];

            //宣告二緯陣列
            int[,] cells2 = new int[3, 3];

            //初始化二緯陣列
            int[,] cells3 = { { 1, 0, 2 }, { 1, 2, 0 }, { 1, 2, 1 } };

            //初始化三緯陣列
            bool[,,] cells4;
            cells4 = new bool[2,3,3] 
            {
                {{true, true, true}, 
                 {true, true, true}, 
                 {true, true, true}},
                {{true, true, true},
                 {true, true, true}, 
                 {true, true, true}}
            };

            //不規則陣列
            int[][] cells5 = {
                new int[] {1, 0, 2, 0},
                new int[] {1, 2, 0}
            };
        }
    }
}