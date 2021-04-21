using System.Collections.Generic;

namespace TaskManager.Models
{
    public class DateComparer : IComparer<Task>
    {
        public int Compare(Task x, Task y)
        {
            if (x.CreationTime > y.CreationTime)
            {
                return 1;
            }
            else if (x.CreationTime < y.CreationTime)
            {
                return -1;
            }

            return 0;
        }
    }
}