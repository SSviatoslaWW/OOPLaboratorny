using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna__11
{
    internal class ComplexCollection
    {
        public Stack CollectionsStack {  get; private set; }
        public Stack<ComplexNumber> CollectionsGenericStack { get; private set; }

        public ComplexCollection()
        {
            CollectionsStack = new Stack();
            CollectionsGenericStack = new Stack<ComplexNumber>();
        }

        public void addObjectInCollectionsStack(object addObject)
        {
            CollectionsStack.Push(addObject);
        }

        public void addObjectCollectionsGenericStack(ComplexNumber addObject)
        {
            CollectionsGenericStack.Push(addObject);
        }

        public object popObjectCollectionsStack()
        {
            return CollectionsStack.Count > 0 ? CollectionsStack.Pop() : null;
        }

        public ComplexNumber popObjectCollectionsGenericStack()
        {
            return CollectionsGenericStack.Count > 0 ? CollectionsGenericStack.Pop() : null;
        }

        //Повернення вершини стеку
        public object peekObjectCollectionsStack()
        {
            return CollectionsStack.Count > 0 ? CollectionsStack.Peek() : null;
        }

        public ComplexNumber peekObjectCollectionsGenericStack()
        {
            return CollectionsGenericStack.Count > 0 ? CollectionsGenericStack.Peek() : null;
        }

        public bool containsObjectInCollectionsStack(object containsObject)
        {
            return CollectionsStack.Contains(containsObject);
        }

        public bool containsObjectInCollectionsGenericStack(ComplexNumber containsObject)
        {
            return CollectionsGenericStack.Contains(containsObject);
        }

        public int countsObjectInCollectionsStack()
        {
            return CollectionsStack.Count;
        }

        public int countsObjectInCollectionsGenericStack()
        {
            return CollectionsGenericStack.Count;
        }

        public void clearCollectionsStack()
        {
            CollectionsStack.Clear();
        }

        public void clearCollectionsGenericStack()
        {
            CollectionsGenericStack.Clear();
        }

        public string printCollectionsStack()
        {
            string result = "CollectionsStack: \n";
            foreach(object item in CollectionsStack)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }

        public string printCollectionsGenericStack()
        {
            string result = "CollectionsGenericStack: \n";
            foreach (ComplexNumber item in CollectionsGenericStack)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }

        public void reverseSatck()
        {
            Stack reversSstack = new Stack();

            while(CollectionsStack.Count > 0)
            {
                reversSstack.Push(CollectionsStack.Pop());
            }
        }
    }
}
