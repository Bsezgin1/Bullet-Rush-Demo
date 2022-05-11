using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoSingleton<ObjectPool>
{
    private Queue<GameObject> pooledObjects;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int poolSize;

    private void Awake() 
    {
        pooledObjects = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bulletGameObject = Instantiate(bulletPrefab);
            bulletGameObject.SetActive(false);

            pooledObjects.Enqueue(bulletGameObject);
        }
    }

    public GameObject GetBulletObject()
    {
        GameObject obj = pooledObjects.Dequeue();
        obj.SetActive(true);
        pooledObjects.Enqueue(obj);
        return obj;
    }
}
