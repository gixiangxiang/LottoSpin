using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrizeItemPrefab : MonoBehaviour
{
  public InputField prizeName;
  public void RefreshList()
  {
    PrizeManager.prizeMana.RefreshPrizeList();
  }

}
