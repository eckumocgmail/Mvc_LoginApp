using System;
using System.Collections.Generic;

/// <summary>
/// Модуль тестирования наследует данный класс.
/// </summary>
 
public abstract class TestUnit: TestElement
{
    protected TestUnit(TestUnit parent=null)
    {

    }

    public override List<string> OnTest()
    {
        return Messages;
    }
}

