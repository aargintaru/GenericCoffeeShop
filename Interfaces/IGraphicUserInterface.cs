using System;

namespace Interfaces
{
    public interface IGraphicUserInterface
    {
        void ClearScreen();
        void PrintMessage(string message);
        void PrintMessageOnLine(string message);
        String ReadInput();
        int ReadInputInteger();
    }
}