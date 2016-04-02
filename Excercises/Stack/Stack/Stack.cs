using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Stack
{
    public class Stack
    {

        private readonly List<object> _stack; 
        private object _list;

        public Stack( )
        {
           _stack = new List<object>();
        }

        public void Push(params object[] list)
        {
            this._list = list;
            if (list == null)
            {
                throw new InvalidCastException("Pay attention! Null value passed!");
            }

            _stack.AddRange(list);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Lo Stack è vuoto, prima dovresti aggiungere qualcosa!");
                
            }

            var lastIndex = _stack.Count() - 1;
            var last =  _stack.Last();
            _stack.RemoveAt((lastIndex));
            return last;
        }

        public void Clear()

        {
            _stack.Clear();
        }

    }
}