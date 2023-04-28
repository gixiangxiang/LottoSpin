using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
  void Start()
  {
    if (ratio != null)
    {
      ratio.onEndEdit.AddListener(CheckFloat);
    }
  }
  public void RefreshList()
  {
    PrizeManager.prizeMana.RefreshPrizeList();
  }

  void CheckFloat(string value)
  {
    string pattern = "^\\d+(\\.\\d{0,2})?$"; // 正則表達式，表示小數點後兩位的格式
    if (!Regex.IsMatch(value, pattern)) // 如果輸入不符合格式
    {
      float floatValue = 0;
      float.TryParse(value, out floatValue); // 將輸入的值轉換為浮點數
      value = floatValue.ToString("0.00"); // 將值設置為符合格式的值
      ratio.text = value; // 更新InputField的值
    }
  }

}
