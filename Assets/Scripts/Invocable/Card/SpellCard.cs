using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class SpellCard : Card
{
    public EntitySO Entity;

    public void passInfo()
    {
        GameManager.gameManager.spellImg.sprite = this.Entity.Design;
        GameManager.gameManager.spellDSC.text = this.Entity.Design.ToString();
        GameManager.gameManager.spellMANA.text = this.Mana.ToString();
        GameManager.gameManager.spellNAME.text = this.Entity.Name.ToString();
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
