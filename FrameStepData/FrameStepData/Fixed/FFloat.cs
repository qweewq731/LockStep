using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameStepData
{
    public struct Fixint : IEquatable<Fixint>, IComparable<Fixint>
    {
        
        /// <summary>
        /// 位数越高越精确 同时整数位越少
        /// 这里分配31个可以作为小数位的 整数位就是63-31 =32位= =
        /// 
        /// </summary>
        private const long SHIFT = 1 << 31;//向左移动10位

        private long value;

        public int toInt
        { 
            get
            {
                return (int)(value/SHIFT);
            }
        }

        public long toLong
        {
            get
            {
                return (long)(value / SHIFT);
            }
        }

        public float toFloat
        {
            get
            {
                return (float)(value / SHIFT);
            }
        }

        public double toDouble
        {
            get
            {
                return (double)(value / SHIFT);
            }
        }

        /// <summary>
        /// 使用long  8 字节  64位
        /// </summary>
        /// <param name="value"></param>
    #region 各种传参不一样的构造函数
        public Fixint(long value)
        {
            this.value = value * SHIFT;
        }
        public Fixint(int value)
        {
            this.value = value * SHIFT;
        }
        /// <summary>
        /// 将原来的值
        /// </summary>
        /// <param name="value"></param>
        public Fixint(float value) 
        {
            this.value = (long)((value) * SHIFT);
        }

        public Fixint(double value)
        {
            this.value = (long)((value) * SHIFT);
        }
        #endregion

        #region 拓展功能
        public int CompareTo(Fixint other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Fixint other)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 重载运算符 implicit 为隐式运算符   explicit为显式运算符
        public static implicit operator Fixint(int value)
        {
            return new Fixint(value);
        }
        public static implicit operator Fixint(long value)
        {
            return new Fixint(value);
        }
        public static implicit operator Fixint(float value)
        {
            return new Fixint(value);
        }
        public static implicit operator Fixint(double value)
        {
            return new Fixint(value);
        }

        public static explicit operator int(Fixint value)
        { 
            return value.toInt;
        }
        public static explicit operator long(Fixint value)
        {
            return value.toLong;
        }
        public static explicit operator float(Fixint value)
        {
            return value.toFloat;
        }
        public static explicit operator double(Fixint value)
        {
            return value.toDouble;
        }

        #region 加法
        public static Fixint operator +(Fixint x, Fixint y)
        {
            return new Fixint(x.value + y.value);
        }
        public static Fixint operator +(Fixint x, int y)
        {
            return new Fixint(x.value + y);
        }

        public static Fixint operator +(int x, Fixint y)
        {
            return new Fixint(x + y.value);
        }

        public static Fixint operator +(long x, Fixint y)
        {
            return new Fixint(x + y.value);
        }
        public static Fixint operator +(Fixint x, long y)
        {
            return new Fixint(x.value + y);
        }
        public static Fixint operator +(float x, Fixint y)
        {
            return new Fixint(x + y.value);
        }
        public static Fixint operator +(Fixint x, float y)
        {
            return new Fixint(x.value + y);
        }
        public static Fixint operator +(double x, Fixint y)
        {
            return new Fixint(x + y.value);
        }
        public static Fixint operator +(Fixint x, double y)
        {
            return new Fixint(x.value + y);
        }

        #endregion

        #region 减法
        public static Fixint operator -(Fixint x, Fixint y)
        {
            return new Fixint(x.value - y.value);
        }
        public static Fixint operator -(Fixint x, int y)
        {
            return new Fixint(x.value - y);
        }

        public static Fixint operator -(int x, Fixint y)
        {
            return new Fixint(x - y.value);
        }

        public static Fixint operator -(long x, Fixint y)
        {
            return new Fixint(x - y.value);
        }
        public static Fixint operator -(Fixint x, long y)
        {
            return new Fixint(x.value - y);
        }
        public static Fixint operator -(float x, Fixint y)
        {
            return new Fixint(x - y.value);
        }
        public static Fixint operator -(Fixint x, float y)
        {
            return new Fixint(x.value - y);
        }
        public static Fixint operator -(double x, Fixint y)
        {
            return new Fixint(x - y.value);
        }
        public static Fixint operator -(Fixint x, double y)
        {
            return new Fixint(x.value - y);
        }

        #endregion

        #region 乘法
        public static Fixint operator *(Fixint x, Fixint y)
        {
            return new Fixint(x.value * y.value);
        }
        public static Fixint operator *(Fixint x, int y)
        {
            return new Fixint(x.value * y);
        }

        public static Fixint operator *(int x, Fixint y)
        {
            return new Fixint(x * y.value);
        }

        public static Fixint operator *(long x, Fixint y)
        {
            return new Fixint(x + y.value);
        }
        public static Fixint operator *(Fixint x, long y)
        {
            return new Fixint(x.value * y);
        }
        public static Fixint operator *(float x, Fixint y)
        {
            return new Fixint(x * y.value);
        }
        public static Fixint operator *(Fixint x, float y)
        {
            return new Fixint(x.value + y);
        }
        public static Fixint operator *(double x, Fixint y)
        {
            return new Fixint(x + y.value);
        }
        public static Fixint operator *(Fixint x, double y)
        {
            return new Fixint(x.value * y);
        }

        #endregion

        #region 除法
        public static Fixint operator /(Fixint x, Fixint y)
        {
            return new Fixint(x.value / y.value);
        }
        public static Fixint operator /(Fixint x, int y)
        {
            return new Fixint(x.value / y);
        }

        public static Fixint operator /(int x, Fixint y)
        {
            return new Fixint(x / y.value);
        }

        public static Fixint operator /(long x, Fixint y)
        {
            return new Fixint(x / y.value);
        }
        public static Fixint operator /(Fixint x, long y)
        {
            return new Fixint(x.value / y);
        }
        public static Fixint operator /(float x, Fixint y)
        {
            return new Fixint(x / y.value);
        }
        public static Fixint operator /(Fixint x, float y)
        {
            return new Fixint(x.value / y);
        }
        public static Fixint operator /(double x, Fixint y)
        {
            return new Fixint(x / y.value);
        }
        public static Fixint operator /(Fixint x, double y)
        {
            return new Fixint(x.value / y);
        }

        #endregion
    }
}
