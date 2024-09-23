using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }
    public static HashSet<NormalItem.eNormalType> GetSurroundingItemTypes(Cell cell)
    {
        HashSet<NormalItem.eNormalType> surroundingTypes = new HashSet<NormalItem.eNormalType>();
        if (cell.NeighbourUp?.Item is NormalItem upItem) surroundingTypes.Add(upItem.ItemType);
        if (cell.NeighbourBottom?.Item is NormalItem bottomItem) surroundingTypes.Add(bottomItem.ItemType);
        if (cell.NeighbourLeft?.Item is NormalItem leftItem) surroundingTypes.Add(leftItem.ItemType);
        if (cell.NeighbourRight?.Item is NormalItem rightItem) surroundingTypes.Add(rightItem.ItemType);
        return surroundingTypes;
    }

    public static NormalItem.eNormalType GetLeastFrequentType(Dictionary<NormalItem.eNormalType, int> typeCounts, HashSet<NormalItem.eNormalType> surroundingTypes)
    {
        return typeCounts
            .OrderBy(typeCount => typeCount.Value)
            .Select(typeCount => typeCount.Key)
            .FirstOrDefault(type => !surroundingTypes.Contains(type));
    }
}
