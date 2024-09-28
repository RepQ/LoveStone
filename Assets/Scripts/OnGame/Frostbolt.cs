using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Frostbolt : SpellCard
{ 
    public override void Effect()
    {
        Debug.LogWarning("Deal 3 damage to a character an Freeze it");
    }

    public override void Play()
    {
        Effect();
    }

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        passInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
