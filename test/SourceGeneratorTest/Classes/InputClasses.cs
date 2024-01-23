﻿using PlantUmlClassDiagramGenerator.SourceGenerator.Attributes;

namespace SourceGeneratorTest.Classes
{
    [PlantUmlDiagram]
    record Paramters(string ParamA, string ParamB, int ParamC, int ParamD);

    [PlantUmlDiagram]
    enum LogLevel
    {
        Trace,
        Debug,
        Info,
        Warning,
        Error
    }

    [PlantUmlDiagram]
    interface ILogger
    {
        string WriteLog(LogLevel level, string message);
    }

    [PlantUmlDiagram]
    class Logger : ILogger
    {
        public string WriteLog(LogLevel level, string message)
        {
            throw new NotImplementedException();
        }

    }

    [PlantUmlDiagram]
    interface IInterface
    {
        void MethodA(Paramters parameters);
        int MethodB(int value);
    }

    [PlantUmlDiagram]
    abstract class BaseClass
    {
        public abstract string Name { get; }
        public abstract int Value { get; }
        public abstract string GetNameValue();
    }

    [PlantUmlDiagram]
    class DerivedClass : BaseClass, IInterface
    {
        private ILogger Logger { get; }
        public override string Name => throw new NotImplementedException();

        public override int Value => throw new NotImplementedException();

        public DerivedClass(ILogger logger)
        {
            Logger = logger;
        }

        public override string GetNameValue()
        {
            throw new NotImplementedException();
        }

        public void MethodA(Paramters parameters)
        {
            throw new NotImplementedException();
        }

        public int MethodB(int value)
        {
            throw new NotImplementedException();
        }

        public void Process(Paramters parameters)
        {
            throw new NotImplementedException();
        }
    }




}
