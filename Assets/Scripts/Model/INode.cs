using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INode<T>
{
    void Execute(T val);
}
