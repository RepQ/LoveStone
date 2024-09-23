using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public abstract class CharacterCard : Card
{
    public CharacterSO Character;

    public void Invoke(Token token)
    {
        Debug.LogWarning("Invoke Token");
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
