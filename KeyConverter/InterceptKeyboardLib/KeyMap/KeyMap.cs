﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptKeyboardLib.KeyMap
{
    public enum OriginalKey
    {
        Unknown = 0,

        Back = 8,
        Tab = 9,
        Enter = 13,
        ESC = 27,
        Henkan = 28,
        Muhenkan = 29,
        Space = 32,
        Home = 36,
        Insert = 45,

        D0 = 48,
        D1 = 49,
        D2 = 50,
        D3 = 51,
        D4 = 52,
        D5 = 53,
        D6 = 54,
        D7 = 55,
        D8 = 56,
        D9 = 57,

        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        
        LeftWindows = 91,
        RightWindows = 92,
        Menu = 93,

        F1 = 112,
        F2 = 113,
        F3 = 114,
        F4 = 115,
        F5 = 116,
        F6 = 117,
        F7 = 118,
        F8 = 119,
        F9 = 120,
        F10 = 121,
        F11 = 122,
        F12 = 123,

        LeftShift = 160,
        RightShift = 161,
        LeftCtrl = 162,
        RightCtrl = 163,
        RightAlt = 165,
        LeftAlt = 164,
        Multiply = 186,
        Plus = 187,
        Comma = 188,
        Equal = 189,
        Period = 190,
        Question = 191,
        AtMark = 192,
        LeftBrace = 219,
        VerticalBar = 220,
        RightBrace = 221,
        Tilde = 222,

        UnderBar = 226,

        Caps = 240,
        Kana = 242,
        Hankaku = 243,
        Zenkaku = 244,
        HankakuZenkaku = 9999,
    }
}