using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathComponent : MonoBehaviour
{
    [SerializeField] private UnityEngine.Events.UnityEvent onDie;

    public void Die()
    {
        // if the object has poolableComponent it should go to the pool otherwise destroy it.
        PoolableComponent poolableComponent = this.gameObject.GetComponent<PoolableComponent>();

        if (poolableComponent) poolableComponent.AddToPool();
        else Destroy(this.gameObject);

        // would you like to do anything when the object disappeard? (Animation, UI change, ...)
        onDie?.Invoke();
    }
}
