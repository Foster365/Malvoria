using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sound
{
    [SerializeField] string name;
    [SerializeField] AudioClip audioClip;

    public string Name { get => name; set => name = value; }
    public AudioClip AudioClip { get => audioClip; set => audioClip = value; }


}
