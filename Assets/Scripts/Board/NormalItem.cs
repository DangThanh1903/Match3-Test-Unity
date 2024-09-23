using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    private Scriptable itemTextures;

    public void Initialize(Scriptable textures)
    {
        itemTextures = textures;
    }
    public enum eNormalType
    {
        TYPE_ONE,
        TYPE_TWO,
        TYPE_THREE,
        TYPE_FOUR,
        TYPE_FIVE,
        TYPE_SIX,
        TYPE_SEVEN
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override string GetPrefabName()
    {
        string prefabname = string.Empty;
        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_ONE;
                break;
            case eNormalType.TYPE_TWO:
                prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
                break;
            case eNormalType.TYPE_THREE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
                break;
            case eNormalType.TYPE_FOUR:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
                break;
            case eNormalType.TYPE_FIVE:
                prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
                break;
            case eNormalType.TYPE_SIX:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
                break;
            case eNormalType.TYPE_SEVEN:
                prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
                break;
        }

        return prefabname;
    }

    protected override Sprite GetSprite()
    {
        Sprite sprite = null;

        switch (ItemType)
        {
            case eNormalType.TYPE_ONE:
                sprite = itemTextures.itemSprites[0]; 
                break;
            case eNormalType.TYPE_TWO:
                sprite = itemTextures.itemSprites[1]; // Second sprite
                break;
            case eNormalType.TYPE_THREE:
                sprite = itemTextures.itemSprites[2]; // Third sprite
                break;
            case eNormalType.TYPE_FOUR:
                sprite = itemTextures.itemSprites[3]; // Fourth sprite
                break;
            case eNormalType.TYPE_FIVE:
                sprite = itemTextures.itemSprites[4]; // Fifth sprite
                break;
            case eNormalType.TYPE_SIX:
                sprite = itemTextures.itemSprites[5]; // Sixth sprite
                break;
            case eNormalType.TYPE_SEVEN:
                sprite = itemTextures.itemSprites[6]; // Seventh sprite
                break;
        }

        return sprite;
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
