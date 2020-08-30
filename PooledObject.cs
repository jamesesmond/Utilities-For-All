using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public GameObjectPool pool;
    
    private void OnDestroy()
    {
        pool.RemoveObject(this);
    }
    private void OnDisable()
    {
        pool.ReturnToPool(this);
    }
}
