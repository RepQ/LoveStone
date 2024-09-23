using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Image charImg, spellImg, tokenIgm, avatarImg;
    public Text charDMG, charHP, charMANA, charDSC, charNAME, spellMANA, spellDSC, spellNAME, tokenDMG, tokenHP;
    void Awake()
    {
        if (gameManager == null)
        { 
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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
