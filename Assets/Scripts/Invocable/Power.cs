using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Power : Invocable
{
    public EntitySO Entity;

    public void passInfo()
    {
        GameManager.gameManager.powerImg.sprite = Entity.Design;
        GameManager.gameManager.powerMANA.text = Mana.ToString();
    }
    public void HeroPower()
    {
        Debug.LogWarning("HeroPower");
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
