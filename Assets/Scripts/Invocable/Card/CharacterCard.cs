using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public abstract class CharacterCard : Card
{
    public CharacterSO Character;
    public Token tokenToCreate;

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
        token.Character = Character;
        token.passInfo();
        token.HP = Character.Hp;
        token.CurrentDamage = Character.Damage;
        token.Team = 1;
        token.Position = 0;
    }

    private void Awake()
    {
        tokenToCreate = GetComponent<Token>();
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
