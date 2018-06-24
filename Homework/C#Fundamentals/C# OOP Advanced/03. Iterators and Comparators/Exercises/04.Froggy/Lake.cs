using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Lake : IEnumerable<int>
{
    private IList<int> positions;

    public Lake(params int[] inputPosiotions) 
    {
        this.positions = inputPosiotions;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.positions.Count; i++)
        {
            if (i % 2 == 0)
            {
                yield return this.positions[i];
            }
        }

        for (int i = this.positions.Count - 1; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                yield return this.positions[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

