using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinWheelManager : MonoBehaviour
{

  public Image[] pieImages;
  public float[] values;
  public PrizeItemPrefab[] prizeListItem;

  void Start()
  {
    SetValue(values);
  }


  public void SetValue(float[] valuesToSet)
  {
    float totalValues = 0;
    for (int i = 0; i < pieImages.Length; i++)
    {
      totalValues += FindPercentage(valuesToSet, i);
      pieImages[i].fillAmount = totalValues;
    }
  }

  float FindPercentage(float[] valuesToSet, int index)
  {
    float totalAmount = 0;
    for (int i = 0; i < valuesToSet.Length; i++)
    {
      totalAmount += valuesToSet[i];
    }
    return valuesToSet[index] / totalAmount;
    /*
    if (totalAmount == 100)
    {
      return valuesToSet[index] / totalAmount;
    }
    else
    {

    }
    */
  }

  public void GetPrizeList()
  {
    for (int i = 0; i < PrizeManager.prizeMana.prizeItems.Count; i++)
    {
      prizeListItem[i].prizeName.text = PrizeManager.prizeMana.prizeItems[i].prizeName;
    }
    for (int i = PrizeManager.prizeMana.prizeItems.Count; i < prizeListItem.Length; i++)
    {
      prizeListItem[i].gameObject.SetActive(false);
    }
  }
}
