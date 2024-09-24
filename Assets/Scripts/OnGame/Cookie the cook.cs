using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cookiethecook : CharacterCard
{
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
