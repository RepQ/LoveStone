using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "Entity", menuName = "ScriptableObjects/Entity")]
public class EntitySO : ScriptableObject
{
    public Sprite Design;
    public String Name;
    public String Description;

}
