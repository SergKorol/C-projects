using System;
namespace MyJournal
{
    public class JournalEntry
    {
        private string text;

        public string Text
        {
        get
            {
                return text; 
            }
            set
            {
                text = value;
                LastEditTime = DateTime.Now; 
            }
        }

        public DateTime LastEditTime { get; set; }
    }
}
