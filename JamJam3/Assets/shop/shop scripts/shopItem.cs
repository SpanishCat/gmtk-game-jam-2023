using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "shop Menu", menuName = "scriptable Objects/New Shop Item", order = 1)]
public class shopItem : ScriptableObject
{
    public string title;
    public string description;
    public int cost;
   
}
