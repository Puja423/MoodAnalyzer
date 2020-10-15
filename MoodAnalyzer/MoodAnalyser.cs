using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        string mood;
        string message;
        enum Errors
        {
            NULL,
            EMPTY,
            OTHERS
        }

        public MoodAnalyser()
        {
            mood = "";
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            string regexStr = "^(.*[ ])*[sSaAdD]{3}([ ].*)*";
            Regex regexExp = new Regex(regexStr);

            if (message == null)
                throw new MoodAnalysisException(Errors.NULL.ToString());
            else if (message.Length == 0)
                throw new MoodAnalysisException(Errors.EMPTY.ToString());

            try
            {
                mood = regexExp.IsMatch(this.message) ? "SAD" : "HAPPY";
            }
            catch (MoodAnalysisException e)
            {
                throw new MoodAnalysisException(Errors.OTHERS.ToString() + " " + e.Message);
            }

            return mood;
        }
    }
}

