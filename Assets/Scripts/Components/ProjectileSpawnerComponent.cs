using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProjectileSpawnerComponent : MonoBehaviour
{
    [SerializeField] float bulletVelocityMagnitude;

    public void SpawnProjectile(PoolableTypes type)
    {
        // The object returned from the pool.
        GameObject obj;
        obj = PoolManager.Instance.GetFromPool(type);
    }
}
