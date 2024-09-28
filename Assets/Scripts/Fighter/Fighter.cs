using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour, IOnStart, IOnDamaged, IOnDead
{
    public int Team;
    public int HP;

    public virtual void OnStart()
    {

    }

    public virtual void OnDamaged()
    {

    }

    public virtual void OnDead()
    {

    }
    public void Attack(Fighter fighter)
    {
        Debug.LogWarning("Attack");
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
