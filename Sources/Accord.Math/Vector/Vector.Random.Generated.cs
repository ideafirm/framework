﻿// Accord Math Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

// ======================================================================
// This code has been generated by a tool; do not edit manually. Instead,
// edit the T4 template Vector.Random.tt so this file can be regenerated. 
// ======================================================================


namespace Accord.Math
{
    using System;
    using Accord.Math;

    public static partial class Vector
    {
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static double[] Random(int size)
        {
            return Random(size, 0.0, 1.0);
        }

        /// <summary>
        ///   Draws a random sample from a group of observations, without repetitions.
        /// </summary>
        /// 
        /// <typeparam name="T">The type of the observations.</typeparam>
        /// 
        /// <param name="values">The observation vector.</param>
        /// <param name="size">The size of the sample to be drawn (how many samples to get).</param>
        /// 
        /// <returns>A vector containing the samples drawn from <paramref name="values"/>.</returns>
        /// 
        public static T[] Sample<T>(T[] values, int size)
        {
            int[] idx = Vector.Sample(size);
            return values.Submatrix(idx);
        }


        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static int[] Sample(int size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static int[] Sample(int size, int max)
        {
            if ((int)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            int[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static float[] Sample(float size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static float[] Sample(int size, float max)
        {
            if ((float)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            float[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static double[] Sample(double size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static double[] Sample(int size, double max)
        {
            if ((double)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            double[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static short[] Sample(short size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static short[] Sample(int size, short max)
        {
            if ((short)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            short[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static byte[] Sample(byte size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static byte[] Sample(int size, byte max)
        {
            if ((byte)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            byte[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static sbyte[] Sample(sbyte size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static sbyte[] Sample(int size, sbyte max)
        {
            if ((sbyte)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            sbyte[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static long[] Sample(long size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static long[] Sample(int size, long max)
        {
            if ((long)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            long[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static decimal[] Sample(decimal size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static decimal[] Sample(int size, decimal max)
        {
            if ((decimal)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            decimal[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static ulong[] Sample(ulong size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static ulong[] Sample(int size, ulong max)
        {
            if ((ulong)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            ulong[] idx = Sample(max);
            return idx.Submatrix(size);
        }

        /// <summary>
        ///   Returns a vector containing indices (0, 1, 2, ..., n - 1) in random 
        ///   order. The vector grows up to to <paramref name="size"/>, but does not
        ///   include <c>size</c> among its values.
        /// </summary>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3);  // a possible output is { 2, 1, 0 };
        ///   var b = Vector.Sample(10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static ushort[] Sample(ushort size)
        {
            var random = Accord.Math.Random.Generator.Random;

            var idx = Vector.Range(size);
            var x = new double[idx.Length];
            for (int i = 0; i < x.Length; i++)
                x[i] = random.NextDouble();

            Array.Sort(x, idx);

            return idx;
        }
        
        /// <summary>
        ///   Returns a vector of the specified <paramref name="size"/> containing 
        ///   indices (0, 1, 2, ... max) up to a given maximum number and in random 
        ///   order. The vector can grow up to to <paramref name="max"/>, but does 
        ///   not include <c>max</c> among its values.
        /// </summary>
        /// 
        /// <remarks>
        ///   In other words, this return a sample of size <c>k</c> from a population
        ///   of size <c>n</c>, where <c>k</c> is the parameter <paramref name="size"/>
        ///   and <c>n</c> is the parameter <paramref name="max"/>.
        /// </remarks>
        /// 
        /// <example>
        /// <code>
        ///   var a = Vector.Sample(3, 10);  // a possible output is { 1, 7, 4 };
        ///   var b = Vector.Sample(10, 10); // a possible output is { 5, 4, 2, 0, 1, 3, 7, 9, 8, 6 };
        ///   
        ///   foreach (var i in Vector.Sample(5, 6))
        ///   {
        ///      // ...
        ///   }
        /// </code>
        /// </example>
        /// 
        public static ushort[] Sample(int size, ushort max)
        {
            if ((ushort)size > max)
            {
                throw new ArgumentOutOfRangeException("size",
                    "The sample size must be less than the size of the population.");
            }

            ushort[] idx = Sample(max);
            return idx.Submatrix(size);
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static int[] Random(int size, int min, int max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new int[size];
            for (int i = 0; i < size; i++)
                vector[i] = (int)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static short[] Random(int size, short min, short max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new short[size];
            for (int i = 0; i < size; i++)
                vector[i] = (short)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static byte[] Random(int size, byte min, byte max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new byte[size];
            for (int i = 0; i < size; i++)
                vector[i] = (byte)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static sbyte[] Random(int size, sbyte min, sbyte max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new sbyte[size];
            for (int i = 0; i < size; i++)
                vector[i] = (sbyte)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static long[] Random(int size, long min, long max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new long[size];
            for (int i = 0; i < size; i++)
                vector[i] = (long)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static ulong[] Random(int size, ulong min, ulong max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new ulong[size];
            for (int i = 0; i < size; i++)
                vector[i] = (ulong)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static ushort[] Random(int size, ushort min, ushort max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new ushort[size];
            for (int i = 0; i < size; i++)
                vector[i] = (ushort)random.Next((int)max, (int)min);
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static float[] Random(int size, float min, float max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new float[size];
            for (int i = 0; i < size; i++)
                vector[i] = (float)random.NextDouble() * (max - min) + min;
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static double[] Random(int size, double min, double max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new double[size];
            for (int i = 0; i < size; i++)
                vector[i] = (double)random.NextDouble() * (max - min) + min;
            return vector;
        }
        /// <summary>
        ///   Creates a vector with uniformly distributed random data.
        /// </summary>
        /// 
        public static decimal[] Random(int size, decimal min, decimal max)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("size", size, "Size must be a positive integer.");

            var random = Accord.Math.Random.Generator.Random;

            var vector = new decimal[size];
            for (int i = 0; i < size; i++)
                vector[i] = (decimal)random.NextDouble() * (max - min) + min;
            return vector;
        }
    }
}