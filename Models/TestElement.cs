using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
 




/// <summary>
/// Модуль тестирования наследует данный класс.
/// </summary>
 
public abstract class TestElement 
{
    protected Dictionary<string, TestElement> Children = new Dictionary<string, TestElement>();

    public List<string> Messages { get; set; }
    public abstract List<string> OnTest();



}
