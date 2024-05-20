using Checkers;
using System;
using System.Threading.Tasks;

public interface IObserver
{
    public Task Serialize(string input);

    public event Action<Coordinate> NextStepReady;
}
