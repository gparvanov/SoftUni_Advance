﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(params string[] data)
        {
            foreach (var item in data)
            {
                this.Push(item);
            }
        }
    }
}