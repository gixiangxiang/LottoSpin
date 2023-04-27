using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviourControl : MonoBehaviour
{
  [Header("----設定獎品面板----")]
  [Header("Prize Manager")]
  public PrizeManager prizeMana;


  #region 設定獎品面板
  //增加獎品按鈕
  public void AddPrize()
  {
    prizeMana.AddPrize();
  }
  //確認按鈕
  public void SettingConfirm()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.setPrizeRatio);
    prizeMana.RefreshPrizeList();
  }


  #endregion

  #region 設定比例面板
  public void RatioConfirm()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.game);
  }
  public void RatioCancel()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.setPrize);

  }

  #endregion


}