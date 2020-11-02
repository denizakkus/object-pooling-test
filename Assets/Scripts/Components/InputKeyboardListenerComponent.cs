using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputKeyboardListenerComponent : MonoBehaviour
{

    // when you want to saw UnityEvent which sends a value as parameter on the inspector
    // create a Serializable class which takes UnityEvent in desired type
    // then use SerializeField to create action
    // if there is an option like Dynamic/Static selection
    // Dynamic means I will use my dynamic value from the invoke
    // Static means I will use my value that I manually set from the invoe.
    [System.Serializable]
    public class ProjectileSpawnerEvent : UnityEvent<PoolableTypes> { }
    
    [SerializeField]
    private ProjectileSpawnerEvent spawnProjectileListener;

    // Which button would you like to create a Heavy Bullet?
    [SerializeField]
    private KeyCode heavyBulletSpawnKey;

    // Which button would you like to create a Low Bullet?
    [SerializeField]
    private KeyCode lowBulletSpawnKey;

    private void Update()
    {
        // When the desired buttons pressed.
        if (Input.GetKeyDown(heavyBulletSpawnKey)) spawnProjectileListener?.Invoke(PoolableTypes.HeavyBullet);
        else if (Input.GetKeyDown(lowBulletSpawnKey)) spawnProjectileListener?.Invoke(PoolableTypes.LowBullet);
    }
}
