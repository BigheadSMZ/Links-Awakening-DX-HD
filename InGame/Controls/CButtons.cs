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
        LB = 256,
        RB = 512,
        LT = 1024,
        RT = 2048,
        Select = 4096,
        Start = 8192
    }
}