using System.Collections;
using System.Collections.Generic;

namespace VisitorDemoFunctional
{
    /// <summary>
    ///     Represents a functional list that can be eihter
    ///     'empty list' or a 'cons cell'
    /// </summary>
    public class FuncList<T> : IEnumerable<T>
    {
        /// <summary>
        ///     Constructor that creates an empty list
        /// </summary>
        public FuncList()
        {
            IsEmpty = true;
        }

        /// <summary>
        ///     Constructor that creates a cons cell with an element
        ///     (head) and a reference to the rest of the list (tail)
        /// </summary>
        /// <param name="head">The elemnet stored by the cons cell</param>
        /// <param name="tail">Reference to the rest of the list</param>
        public FuncList(T head, FuncList<T> tail)
        {
            IsEmpty = false;
            Head = head;
            Tail = tail;
        }

        /// <summary>
        ///     Is the list empty list or a cons cell?
        /// </summary>
        public bool IsEmpty { get; }

        /// <summary>
        ///     Returns the element stored in the cons cell
        /// </summary>
        public T Head { get; }

        /// <summary>
        ///     Returns reference to the rest of the list when the list is a cons cell
        /// </summary>
        public FuncList<T> Tail { get; }

        public int Count => IsEmpty ? 0 : Tail.Count + 1;


        // Added

        public IEnumerator<T> GetEnumerator()
        {
            var el = this;
            while (!el.IsEmpty)
            {
                yield return el.Head;
                el = el.Tail;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}