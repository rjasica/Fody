﻿using System;
using System.Reflection;
using NUnit.Framework;
using WithNugetAndInSolutionWeavers;

[TestFixture]
public class WithNugetAndInSolutionWeaversTest
{
    [Test]
    public void EnsureTypeInjectedByModuleWeaver()
    {
        var types = Assembly.Load("WithNugetAndInSolutionWeavers").GetTypes();

        Assert.IsNotNull(Type.GetType("Weavers.TypeInjectedByModuleWeaver, WithNugetAndInSolutionWeavers"));
    }
    [Test]
    public void EnsureTypeInjectedByNamedWeaver()
    {
        Assert.IsNotNull(Type.GetType("Weavers.TypeInjectedByNamedWeaver, WithNugetAndInSolutionWeavers"));
    }
    [Test]
    public void EnsureTypeChangedByNugetWeaver()
    {
        Assert.IsTrue(typeof(Class1).GetMethod("Method").IsVirtual);
    }
}