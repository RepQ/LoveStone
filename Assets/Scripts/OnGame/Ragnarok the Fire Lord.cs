using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagnaroktheFireLord : CharacterCard , IEffect
{
    public void Effect()
    {
        Debug.LogWarning("Deal 1 damage.");
    }
    private void Awake()
    {
        Mana = 8;
        Rarity = 2;
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
