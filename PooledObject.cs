using UnityEngine;

public class PooledObject : MonoBehaviour
{
    private GameObjectPool pool;

    public void Create(GameObjectPool newPool)
    {
        pool = newPool;
    }

    public void OnDespawn()
    {
        pool.ReturnToPool(this);
    }
    private void OnDestroy()
    {
        pool.RemoveObject(this);
    }
    private void OnDisable()
    {
        OnDespawn();
    }
}
