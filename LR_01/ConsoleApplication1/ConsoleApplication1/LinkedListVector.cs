using System;

namespace ConsoleApplication1
{
    public class LinkedListVector
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
                return "";
            Node p = head;
            string st = p.value.ToString();
            while (p.next != null)
            {
                p = p.next;
                st = st + ' ' + p.value.ToString();
            }
            return st;
        }
    }
}