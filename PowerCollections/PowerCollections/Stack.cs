using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PowerCollections
{
    public class Stack<T> : IEnumerable<T>
    {

        T[] stack;

        /// <summary>
        /// число элементов стека
        /// </summary>
        
        public int Count = 0;

        /// <summary>
        /// максимальный размер стека
        /// </summary>

        public int Capacity { get; } 

        public Stack(int size
        
            
            if (size <= 0)
                throw new ArgumentOutOfRangeException();

            Capacity = size;
            stack = new T[size];
        }

        /// <summary>
        /// Push() - добавить элемент на вершину стека
        /// </summary>

        public void Push(T item)
        {
            try
            {
                stack[Count++] = item;
            }
            catch
            {
                if (Count > Capacity)
                    throw new InvalidOperationException("Стек полон");
            }
        }

        /// <summary>
        /// Pop() - снять элемент с вершины и вернуть его значение
        /// </summary>

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("Стек пуст");
            Count--; 
            return stack[Count];
        }

        /// <summary>
        /// Top() - вернуть значение элемента на вершине стека, но не извлекать
        /// </summary>

        public T Top()
        {
            if (Count == 0)
                throw new InvalidOperationException("Стек пуст");
            return stack[Count - 1];
        }

        /// <summary>
        /// Считывание стека от вершины к низу
        /// </summary>

        public IEnumerator<T> GetEnumerator()
        {
            if (Count == 0) yield break;

            for (int i = Count; i > 0; i--)
                yield return stack[i - 1];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
