using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public enum Status
  {
    setPrize,
    setPrizeRatio,
    game,
    rolling,
    stop,
    result
  }
  public static GameManager gm;
  public EventContoller eventCtrl;
  [Header("當前遊戲狀態")]
  public Status nowGameStatus;

  void Awake()
  {
    gm = this;
  }
  void Start()
  {
    Call_ChangeGameState(Status.setPrize);    
  }

  public void Call_ChangeGameState(Status currentGameState) //外部呼叫-----改變流程
  {
    switch (currentGameState)
    {
      case Status.setPrize:
        nowGameStatus = Status.setPrize;
        eventCtrl.SetPrize_Event();
        break;
      case Status.setPrizeRatio:
        nowGameStatus = Status.setPrizeRatio;
        eventCtrl.SetRatio_Event();
        break;
      case Status.game:
        nowGameStatus = Status.setPrize;
        break;
      case Status.rolling:
        nowGameStatus = Status.game;
        break;
      case Status.stop:
        nowGameStatus = Status.stop;
        break;
      case Status.result:
        nowGameStatus = Status.result;
        break;
    }
  }

}
