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
  [Header("獎品清單父物件")]
  public Transform prizeItemsParant;
  [Header("獎品清單預置物")]
  public PrizeItemPrefab prizeItemPrefab;
  [Header("比例清單父物件")]
  public Transform ratioItemsParant;
  [Header("比例清單預置物")]
  public PrizeItemPrefab ratioItemPrefab;

  [Header("獎品清單資料")]
  public List<PrizeItem> prizeItems;

  void Start()
  {
    prizeMana = this;
  }

  public void RefreshPrizeList()
  {
    prizeItems = new List<PrizeItem>();
    float totalRatio = 0;
    for (int i = 0; i < prizeItemsParant.childCount; i++)
    {
      if (i == prizeItemsParant.childCount - 1)
      {
        prizeItems.Add(new PrizeItem
        {
          prizeName = prizeItemsParant.GetComponentsInChildren<PrizeItemPrefab>()[i].prizeNameIpt.text,
          ratio = 1f - totalRatio
        });
      }
      else
      {
        prizeItems.Add(new PrizeItem
        {
          prizeName = prizeItemsParant.GetComponentsInChildren<PrizeItemPrefab>()[i].prizeNameIpt.text,
          ratio = float.Parse((1f / (float)prizeItemsParant.childCount).ToString("F2"))
        });
        totalRatio += float.Parse((1f / (float)prizeItemsParant.childCount).ToString("F2"));
      }
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

  public void SetRatioItem()
  {
    foreach (PrizeItem prize in prizeItems)
    {
      ratioItemPrefab.prizeName.text = prize.prizeName;
      ratioItemPrefab.ratio.text = (prize.ratio * 100f).ToString();
      Instantiate(ratioItemPrefab, ratioItemsParant);
    }
  }
}
