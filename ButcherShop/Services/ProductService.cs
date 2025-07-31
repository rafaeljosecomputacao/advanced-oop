using System;
using System.Collections.Generic;

namespace ButcherShop.Services
{
    internal class ProductService
    {
        public T MostExpensive<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can't be empty");
            }

            T mostExpensive = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(mostExpensive) > 0)
                {
                    mostExpensive = list[i];
                }
            }
            return mostExpensive;
        }
    }
}
