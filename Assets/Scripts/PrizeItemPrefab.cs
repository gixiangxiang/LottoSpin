using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrizeItemPrefab : MonoBehaviour
{
  public enum PrizePrefabType
  {
    settingPrefab,
    ratioPrefab
  }

  public PrizePrefabType prefabType;
  public Text prizeName;
  public InputField prizeNameIpt, ratio;
  public void RefreshList()
  {
    PrizeManager.prizeMana.RefreshPrizeList();
  }

}
