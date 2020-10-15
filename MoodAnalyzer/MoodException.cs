﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalysisException : Exception
    {
        string _message;
        public MoodAnalysisException(string message) : base(message)
        {
            this._message = message;
        }

        public override string Message { get => _message; }
    }
}

