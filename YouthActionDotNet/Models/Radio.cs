using System;
using Newtonsoft.Json;

namespace YouthActionDotNet.Models{

    public class Radio : Question {
        
        public string questionContent  { get; set; }
        
        public override void setAnswer()
        {
            Console.WriteLine("Radio answer set");
        }
    }
}
