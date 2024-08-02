// File: Publisher.cs
using System.Collections.Generic;

public class Publisher
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }

    protected void Notify()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update();
        }
    }
}