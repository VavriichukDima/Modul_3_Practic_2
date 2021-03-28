using System;

namespace Modul_3_Practic_2
{
    public class Deleg
    {
        private int _result = 0;
        public event Func<int, int, int> FuncSum;
        public void TryCatch(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
                Console.WriteLine("Block_Catch");
            }
            finally
            {
                Console.WriteLine("try...catch ended");
            }
        }

        public void Starter()
        {
            TryCatch(() =>
                        {
                            FuncSum += Sum;
                            FuncSum += Sum;
                            var listOfDelegate = FuncSum.GetInvocationList();
                            foreach (var item in listOfDelegate)
                            {
                                var resultInFuncSum = (int)item.DynamicInvoke(1, 2);
                                _result += resultInFuncSum;
                            }
                        });
            Console.WriteLine(_result);
            FuncSum -= Sum;
            FuncSum -= Sum;
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
