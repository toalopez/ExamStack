using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamStack
{
    public class ExamCollection : CollectionBase
    {
        public void Add(Object name)
        {
            InnerList.Add(name);
        }

        public void Remove(Object name)
        {
            InnerList.Remove(name);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }

        public void Insert(int IndexNum, Object name)
        {
            InnerList.Insert(IndexNum, name);
        }

        public bool Contains(Object name)
        {
            return InnerList.Contains(name);
        }
        public int IndexOf(Object name)
        {
            return InnerList.IndexOf(name);
        }

        public void RemoveAt(int Indice)
        {
            InnerList.RemoveAt(Indice);
        }
    }
}
