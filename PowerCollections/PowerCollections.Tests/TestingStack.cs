using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PowerCollections.Tests
{
    [TestClass]
    public class TestingStack
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0)]
        [DataRow(-5)]
        public void Constructor_ArgumentOutOfRangeException(int size)
        {
            Stack<int> stack = new Stack<int>(size);
        }

        [TestMethod]
        public void Constructor_CapacityAndCountOfStack()
        {
            Stack<int> stack = new Stack<int>(10);

            Assert.AreEqual(10, stack.Capacity);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Pop()
        {
            Stack<string> stack = new Stack<string>(3);

            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            Assert.AreEqual("c", stack.Pop());
            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_InvalidOperationException()
        {
            Stack<string> stack = new Stack<string>(1);

            stack.Pop();
        }

        [TestMethod]
        public void Push()
        {
            Stack<int> stack = new Stack<int>(4);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Assert.AreEqual(1000, stack.Count);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Push_InvalidOperationException()
        {
            Stack<int> stack = new Stack<int>(4);
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
        }

        [TestMethod]
        public void StackEnumerable() //порядок заполнения стека
        {
            int[] values = { 5, 4, 3, 2, 1 };
            Stack<int> stack = new Stack<int>(5);

            for (int i = 1; i <= 5; i++)
            {
                stack.Push(i);
            }
            CollectionAssert.AreEqual(values, stack.ToArray());
        }

        [TestMethod]
        public void EmptyStackBeginning()
        {
            Stack<int> stack = new Stack<int>(6);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Top()
        {
            Stack<int> stack = new Stack<int>(4);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);


            Assert.AreEqual(3, stack.Top());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Top_ExceptionWhenStackIsNull()
        {
            Stack<string> stack = new Stack<string>(1);

            stack.Top();
        }
    }
}
