using Checkers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISerializable
{
    public event Action<BaseClickComponent> ChipDestroyed;

    public event Action ObjectsMoved;

    public event Action<ColorType> GameEnded;

    public event Action StepOver;
}
