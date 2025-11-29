using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_colas_y_colas_dobles.Stack
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Next { get; set; }
        public Node(T value) { this.Value = value; }
    }
}
