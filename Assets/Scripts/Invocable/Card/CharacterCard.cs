using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public abstract class CharacterCard : Card
{
    public CharacterSO Character;

    public void passInfo()
    {
        GameManager.gameManager.charImg.sprite = Character.Design;
        GameManager.gameManager.charHP.text = Character.Hp.ToString();
        GameManager.gameManager.charMANA.text = Mana.ToString();
        GameManager.gameManager.charDMG.text = Character.Damage.ToString();
        GameManager.gameManager.charDSC.text = Character.Description.ToString();
        GameManager.gameManager.charNAME.text = Character.Name.ToString();
        Debug.LogWarning("Character created");
    }
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
