using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventContoller : MonoBehaviour
{
  [Header("設定獎品面板")]
  public GameObject settingPanel;
  [Header("設定比例面板")]
  public GameObject ratioPanel;

  [Header("----遊戲控制面板----")]
  [Header("開始遊戲面板")]
  public GameObject gamePanel;
  [Header("開始按鈕")]
  public Button startBtn;
  [Header("停止按鈕")]
  public Button stopBtn;
  [Header("返回按鈕")]
  public Button backBtn;
  [Header("轉盤腳本")]
  public SpinDish dish;
  [SerializeField] int showStop = 5;


  public void SetPrize_Event()
  {    
    stopBtn.gameObject.SetActive(false);
  }

  public void SetRatio_Event()
  {
    stopBtn.gameObject.SetActive(false);
  }

  public void StartGame_Event()
  {
    startBtn.gameObject.SetActive(true);
    stopBtn.gameObject.SetActive(false);
  }

  public void Rolling_Event()
  {
    startBtn.gameObject.SetActive(false);
    stopBtn.gameObject.SetActive(true);
    stopBtn.interactable = false;
    backBtn.interactable = false;
    StartCoroutine(dish.RotateObject());
    StartCoroutine(WaitSecond());
  }

  public void StopRoll_Event()
  {
    stopBtn.interactable = false;
    dish.stop = true;
  }

  public void Result_Event()
  {
    startBtn.gameObject.SetActive(true);
    stopBtn.gameObject.SetActive(false);
    backBtn.interactable = true;
  }

  public IEnumerator WaitSecond()
  {
    int showStopTime = showStop;
    while (showStopTime > 0)
    {
      showStopTime--;
      yield return new WaitForSeconds(1);
    }
    stopBtn.interactable = true;
  }



}
