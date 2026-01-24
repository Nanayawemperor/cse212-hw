using System;
using System.Collections.Generic;

public class TakingTurnsQueue
{
    private Queue<Person> _queue = new Queue<Person>();

    public int Length => _queue.Count;

    public void AddPerson(string name, int turns)
    {
        _queue.Enqueue(new Person(name, turns));
    }

    public Person GetNextPerson()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        var person = _queue.Dequeue();

        // Infinite turns (0 or negative): always re-enqueue unchanged
        if (person.Turns <= 0)
        {
            _queue.Enqueue(person);
        }
        else
        {
            // Finite turns: decrement first
            person.Turns--;

            // Re-enqueue only if turns remain
            if (person.Turns > 0)
            {
                _queue.Enqueue(person);
            }
        }

        return person;
    }
}
