﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE = 1,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE,
                NO_SUCH_CONSTRUCTOR
        }

        private readonly ExceptionType type;

        public MoodAnalyserException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}

