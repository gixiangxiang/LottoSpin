using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public struct PrizeItem
{
  public string prizeName;
  public float ratio;
}

public class PrizeManager : MonoBehaviour
{
  public static PrizeManager prizeMana;
  public Transform prizeItemsParant;
  public PrizeItemPrefab prizeItemPrefab;
  public List<PrizeItem> prizeItems;

  void Start()
  {
    prizeMana = this;
  }

  public void RefreshPrizeList()
  {
    prizeItems = new List<PrizeItem>();
    for (int i = 0; i < prizeItemsParant.childCount; i++)
    {
      prizeItems.Add(new PrizeItem
      {
        prizeName = prizeItemsParant.GetComponentsInChildren<PrizeItemPrefab>()[i].prizeName.text,
        ratio = 1f / (float)prizeItemsParant.childCount
      });
    }
  }

  public void AddPrize()
  {
    if (prizeItemsParant.childCount < 12)
    {
      Instantiate(prizeItemPrefab, prizeItemsParant);
      RefreshPrizeList();
    }
    else
    {
      Debug.Log("最多12項獎品");
    }

  }
}
