using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvenArcher : CharacterCard, IEffect
{

    public void Effect()
    {
        Debug.LogWarning("Deal 1 damage.");
    }

    void Awake()
    {
        Mana = 1;
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
