using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Checkers
{
    public enum MoveType : byte
    {
        Highlight,
        Move,
        End
    }

    public enum RecordType : byte
    {
        Move,
        Remove,
        Click
    }

    public enum ColorType
    {
        White,
        Black
    }
}
