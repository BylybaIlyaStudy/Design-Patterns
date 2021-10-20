using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton Instance { get; set; } = null;
        private static string Text { get; set; } = string.Empty;
        private Singleton(){}

        public static Singleton GetInstance()
        {
            Instance ??= new Singleton();

            return Instance;
        }

        public void ChangeText(string newText)
        {
            Text = newText;
        }

        public string GetText()
        {
            return Text;
        }
    }
}
