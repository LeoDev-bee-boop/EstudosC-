﻿using OpenQA.Selenium;
using System;

namespace Concilig.Automacao.Selenium.Model
{
    public class ErrorMessage
    {
        public ErrorMessage(By by, string value, string action, Type type, string erro)
        {
            Date = DateTime.Now;
            By = by;
            Value = value;
            Action = action;
            Type = type;
            Erro = erro;
        }

        public By By { get; private set; }
        public string Value { get; private set; }
        public string Erro { get; private set; }
        public Type Type { get; private set; }
        public string Action { get; private set; }
        public DateTime Date { get; private set; }
    }
}
