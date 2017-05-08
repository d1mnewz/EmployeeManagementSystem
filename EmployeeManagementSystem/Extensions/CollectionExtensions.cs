using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Extensions
{
    public static class CollectionExtensions
    {
        public static T RandomElement<T>(this IList<T> data)
        {
            if(data == null)
                throw new ArgumentNullException();
            return data[new Random().Next(0, data.Count)];
        }
    }
}
