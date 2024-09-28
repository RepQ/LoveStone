using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElvenArcher : CharacterCard
{

    public override void Effect()
    {
        Debug.LogWarning("Deal 1 damage.");
    }

    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        passInfo();
        Invoke(this.tokenToCreate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
