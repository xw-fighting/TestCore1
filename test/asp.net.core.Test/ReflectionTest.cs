using System;
using System.Diagnostics;
using System.Reflection;
using Xunit;

namespace asp.net.core.Test
{
    public class ReflectionTest
    {
        [Fact]
        public void Test1()
        {
            int i = 0;
            //չʾ���򼯵���Ϣ
            Assembly a = typeof(ReflectionTest).GetTypeInfo().Assembly;
            Display(i, "Assembly identity={0}", a.FullName);
            //
            Display(i + 1, "Codebase={0}", a.CodeBase);
            //չʾ�ó������õ��ⲿ����


        }

        private void Display(int i, string format, params object [] param)
        {
            Trace.WriteLine(string.Format("{0}:{1}{2}",i, format, param));
        }
    }
}
