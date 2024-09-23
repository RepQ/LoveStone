using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character")]

public class CharacterSO : EntitySO
{
    public int Damage;
    public int Hp;
}
