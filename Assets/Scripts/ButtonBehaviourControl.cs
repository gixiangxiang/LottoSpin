using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviourControl : MonoBehaviour
{
  

  #region 設定獎品面板
  //增加獎品按鈕
  public void AddPrize()
  {
    PrizeManager.prizeMana.AddPrize();
  }

  //移除獎品按鈕
  public void RemovePrize()
  {
    PrizeManager.prizeMana.RemovePrize();
    // PrizeManager.prizeMana.RefreshPrizeList();
  }
  //確認按鈕
  public void SettingConfirm()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.setPrizeRatio);
    PrizeManager.prizeMana.RefreshPrizeList();
    PrizeManager.prizeMana.SetRatioItem();
  }
  #endregion


  #region 設定比例面板
  public void RatioConfirm()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.game);
    PrizeManager.prizeMana.UpdateRatio();
  }
  public void RatioCancel()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.setPrize);
    PrizeManager.prizeMana.DestroyRatioChild();
  }

  public void AverageRatio()
  {
    PrizeManager.prizeMana.DestroyRatioChild();
    PrizeManager.prizeMana.SetRatioItem();
  }
  #endregion


  #region 遊戲面板
  public void StartSpin()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.rolling);
  }
  public void StopSpin()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.stop);
  }

  public void Back()
  {
    GameManager.gm.Call_ChangeGameState(GameManager.Status.setPrizeRatio);
  }

  #endregion


}
