using System;

namespace OperatorOverLoading
{
    class Rational1
    {
        public int N { get; set; }
        public int D { get; set; }

        public Rational1(int N, int D)
        {
            this.N=N;
            this.D=D;
        }

        public static Rational1 operator -(Rational1 r1, Rational1 r2)
        {
            Rational1 r3=new Rational1(0,0);
            r3.N=r1.N*r2.D-r2.N+r1.D;
            r3.D=r1.D*r2.D;
            return r3;
        }

        public override string ToString()
        {
            return $"{N}/{D}";
        }
    }
}