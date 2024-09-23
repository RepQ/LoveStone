using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Invocable : MonoBehaviour
{
    public int Mana;
    public int CurrentMana;

  

    public virtual void Play()
    {
        Debug.LogWarning("Play");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
