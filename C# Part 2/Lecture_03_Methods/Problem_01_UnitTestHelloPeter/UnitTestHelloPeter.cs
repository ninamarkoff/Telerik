using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program_01_HelloPeter;

[TestClass]
public class UnitTestHelloPeter
{
    [TestMethod]
    public void TestHelloAni()
    {
        HelloPeter.Hello("Ani");
    }
    [TestMethod]
    public void TestHello123()
    {
        HelloPeter.Hello("123");
    }
    [TestMethod]
    public void TestHelloEmtyString()
    {
        HelloPeter.Hello("");
    }
    [TestMethod]
    public void TestHelloVeryLongString()
    {
        HelloPeter.Hello("zhjdsgfjdhjdksfhjhsdkjbfdhjvbsdjcdfjvbdsjcbsjkvbdjkcjfvdfbvjdnvcjdfbvdfbvvbhfdvbdfvbfdbv");
    }
    [TestMethod]
    public void TestHelloSomeString()
    {
        HelloPeter.Hello("Some string");
    }
   
}

