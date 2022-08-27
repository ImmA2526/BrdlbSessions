using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPS__AllSession
{
    class S21__AsyncAwait
    {
        public int SyncMethod()
        {
            int result = 0;
            for (int i = 1; i < 20; i++)
            {
                Thread.Sleep(400);
                Console.WriteLine($"Sync Numbers are : {i}");
                result += 1;
            }
            return result;
        }
        public Task<int> AsyncMethod()
        {
            Task<int> asyncMethod = new Task<int>(() =>
          {
              int result = 0;
              for (int i = 1; i < 20; i++)
              {
                  Thread.Sleep(400);
                  Console.WriteLine($"ASync Numbers are : {i}");
                  result += 1;
              }
              return result;
          });
            asyncMethod.Start();
            return asyncMethod;
        }
    }
}
