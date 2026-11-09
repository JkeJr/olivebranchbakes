using System;
using System.Collections.Generic;
using System.Text;

namespace OliveBranchBakes.Objects.Order_Assets
{
    public interface IDisplayableList<T>
    {
        public int IndexOf(T obj);
        public string ToString(string separator);
    }
}
