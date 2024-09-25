using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Token : Fighter, IOnStart, IOnDamaged, IOnDead
{
    public int Position;
    public int CurrentDamage;
    public CharacterSO Character;

    public void OnStart()
    {

    }

    public void OnDamaged()
    {

    }

    public void OnDead()
    {

    }
    public void passInfo()
    {
        if (!Character)
            Debug.LogWarning("No token");
        else
        {
            Debug.LogWarning("Invoke Token");
            GameManager.gameManager.tokenImg.sprite = Character.Design;
            GameManager.gameManager.tokenDMG.text = Character.Damage.ToString();
            GameManager.gameManager.tokenHP.text = Character.Hp.ToString();

        }
    }
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
