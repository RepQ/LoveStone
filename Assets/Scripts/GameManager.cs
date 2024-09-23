using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Frostbolt frostbolt;
    public Cookiethecook cookieTheCook;
    private Text mana;
    private Text description;
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
        if (frostbolt)
        {
            mana = frostbolt.transform.Find("Mana").GetComponent<Text>();
            mana.text = frostbolt.Mana.ToString();

            description = frostbolt.transform.Find("Description").GetComponent<Text>();
            description.text = frostbolt.Entity.Description;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
