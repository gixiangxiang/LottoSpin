using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PrizeItemPrefab : MonoBehaviour
{
  public enum PrizePrefabType
  {
    設定面板預置物,
    比例面板預置物
  }

  public PrizePrefabType prefabType;
  public Text prizeName;
  public InputField prizeNameIpt, ratio;
  public void RefreshList()
  {
    PrizeManager.prizeMana.RefreshPrizeList();
  }

}
