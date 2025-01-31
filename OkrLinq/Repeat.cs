﻿namespace OkrLinq
{
    using System;
    using System.Collections.Generic;

    public static partial class MoreEnumerable
    {
        public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("count");
            }
            return RepeatImpl(element, count);
        }
        private static IEnumerable<TResult> RepeatImpl<TResult>(TResult element, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return element;
            }
        }
    }
}
