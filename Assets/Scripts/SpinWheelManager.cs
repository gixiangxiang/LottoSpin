using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinWheelManager : MonoBehaviour
{

  public Image[] pieImages;
  public PrizeItemPrefab[] prizeListItem;

  //分配比例至轉盤
  public void SetValue()
  {
    float totalValues = 0;
    for (int i = 0; i < PrizeManager.prizeMana.prizeItems.Count; i++)
    {
      totalValues += PrizeManager.prizeMana.prizeItems[i].ratio;
      pieImages[i].fillAmount = totalValues;
    }
    for (int i = PrizeManager.prizeMana.prizeItems.Count; i < pieImages.Length; i++)
    {
      pieImages[i].gameObject.SetActive(false);
    }
  }
  //獲取獎品清單顯示在列表中
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
