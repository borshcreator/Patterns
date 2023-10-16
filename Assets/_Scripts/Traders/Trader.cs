using UnityEngine;

public abstract class Trader:MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.TryGetComponent(out Player player))
        {
            Trade();
        }
    }

    protected abstract void Trade();
}
