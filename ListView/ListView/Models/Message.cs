using System;
using System.Collections.Generic;
using System.Text;

namespace ListView.Models
{
    public class Message
    {
        private string topic;
        private string content;

        public string Topic { get => topic; set => topic = value; }
        public string Content { get => content; set => content = value; }
    }
}
