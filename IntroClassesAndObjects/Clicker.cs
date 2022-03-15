using System;

namespace IntroClassesAndObjects
{
    class Clicker
    {
        public int Count { get; private set; }

        private char _keyChar;

        public Clicker(char keyChar)
        {
            _keyChar = keyChar;
        }

        //public int GetCount()
        //{
        //    return _count;
        //}

        //protected void SetCount(int newValue)
        //{
        //    _count = newValue;
        //}

        public void Click(char keyChar)
        {
            if (keyChar == _keyChar)
            {
                Count++;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Clicker {_keyChar} = {Count}");
        }
    }
}
