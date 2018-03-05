using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoMiner
{
    public class ControlWrapper
    {
        protected KeyboardState CurrentKeyboardState { get; set; }
        protected KeyboardState PreviousKeyboardState { get; set; }
        protected MouseState CurrentMouseState { get; set; }
        protected MouseState PreviousMouseState { get; set; }

        public ControlWrapper()
        {
            CurrentKeyboardState = new KeyboardState();
            CurrentMouseState = new MouseState();
            
        }

        public KeyboardState GetKeyboardState()
        {
            return CurrentKeyboardState;
        }
        
        public void GetNextStates()
        {
            PreviousKeyboardState = CurrentKeyboardState;
            PreviousMouseState = CurrentMouseState;

            CurrentKeyboardState = Keyboard.GetState();
            CurrentMouseState = Mouse.GetState();

        }
    }

}
