using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frostbolt : SpellCard, IEffect
{ 
    public void Effect()
    {
        Debug.LogWarning("Deal 3 damage to a character an Freeze it");
    }

    public override void Play()
    {
        Effect();
    }

    void Awake()
    {
        Mana = 2;
        Rarity = 1;
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
