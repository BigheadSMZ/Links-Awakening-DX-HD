using System;

namespace ProjectZ.InGame.Controls
{
    [Flags]
    public enum CButtons
    {
        None = 0,
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8,
        A = 16,
        B = 32,
        X = 64,
        Y = 128,
        Select = 256,
        Start = 512,
        LB = 1024,
        RB = 2048,
        LT = 4096,
        RT = 8192
    }
}