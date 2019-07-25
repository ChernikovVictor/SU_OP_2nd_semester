using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class LinkedListVector : IVector, IComparable, ICloneable
    {
        private class Node
        {
            public double value;
            public Node next;
        }

        private Node head;

        public LinkedListVector()
        {
            head = new Node();
            for (int i = 0; i < 4; i++)
            {
                Node p = new Node();
                p.next = head;
                head = p;
            }
        }
        
        public LinkedListVector(int n)
        {
            if (n != 0)
            {
                head = new Node();
                for (int i = 0; i < n - 1; i++)
                {
                    Node p = new Node();
                    p.next = head;
                    head = p;
                }
            }
        }

        public double this[int i]
        {
            get
            {
                try
                {
                    if (i < 0)
                        i = this.Length + 1;
                    Node ans = head;
                    int j = 0;
                    while (j < i)
                    {
                        ans = ans.next;
                        j++;
                    }
                    return ans.value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Выход за границы списка\nPress Enter...");
                    Console.ReadLine();
                    throw;
                }
            }
            set
            {
                try
                {
                    if (i < 0)
                        i = this.Length + 1;
                    Node ans = head;
                    int j = 0;
                    while (j < i)
                    {
                        ans = ans.next;
                        j++;
                    }
                    ans.value = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Выход за границы списка\nPress Enter...");
                    Console.ReadLine();
                    throw;
                }
            }
        }

        public double GetNorm()
        {
            if (head == null)
                return 0;
            Node p = head;
            double ans = p.value * p.value;
            while (p.next != null)
            {
                p = p.next;
                ans += p.value * p.value;
            }
            return Math.Sqrt(ans);
        }

        public int Length
        {
            get
            {
                if (head == null)
                    return 0;
                Node p = head;
                int ans = 1;
                while (p.next != null)
                {
                    p = p.next;
                    ans++;
                }
                return ans;
            }
        }

        public override string ToString()
        {
            if (head == null)
                return "0";
            Node p = head;
            string st = this.Length.ToString() + ' ' + p.value.ToString();
            while (p.next != null)
            {
                p = p.next;
                st = st + ' ' + p.value.ToString();
            }
            return st;
        }
        
        public override bool Equals(object obj)
        {
            IVector v = obj as IVector;
            if (v == null || v.Length != this.Length)
                return false;
            for (int i = 0; i < v.Length; i++)
            {
                if (Math.Abs(v[i] - this[i]) > 1e-5)
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        
        public int CompareTo(object obj)
        {
            IVector v = obj as IVector;
            if (v == null)
            {
                Console.Write("Невозможно сравнить\nPress Enter...");
                Console.ReadLine();
                throw new Exception();
            }
            if (this.Length > v.Length)
                return 1;
            if (this.Length < v.Length)
                return -1;
            return 0;
        }

        public class SortByNorm : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                IVector v1 = (IVector) obj1;
                IVector v2 = (IVector) obj2;
                if (v1.GetNorm() > v2.GetNorm())
                    return 1;
                if (v1.GetNorm() < v2.GetNorm())
                    return -1;
                return 0;
            }
        }
        
        public object Clone()
        {
            LinkedListVector clone = new LinkedListVector(this.Length);
            for (int i = 0; i < this.Length; i++)
            {
                clone[i] = this[i];
            }
            return clone;
        }
    }
}