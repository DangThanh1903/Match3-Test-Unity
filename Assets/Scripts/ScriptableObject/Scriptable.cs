using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemTextures")]
public class Scriptable : ScriptableObject
{
    public List<Sprite> itemSprites = new List<Sprite>(); // Change from strings to Sprites

    public List<Sprite> GetItemSprites()
    {
        return itemSprites;
    }
}
