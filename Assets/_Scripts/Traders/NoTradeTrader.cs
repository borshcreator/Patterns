using UnityEngine;

public class NoTradeTrader : Trader
{
    protected override void Trade()
    {
        Debug.Log("У меня для тебя ничего нет");
    }
}
