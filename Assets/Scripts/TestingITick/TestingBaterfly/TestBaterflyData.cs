using UnityEngine;

[CreateAssetMenu(fileName = "NewModel", menuName = "CreateModel/TestBaterfly", order = 0)]

public sealed class TestBaterflyData : ScriptableObject
{

    #region Fields

    public TestBaterflyStruct TestBaterflyStruct;

    #endregion


    #region Metods

    public void Move(Transform transform, Transform target, float speed)
    {
        transform.position = Vector3.MoveTowards
            (transform.position,
            target.transform.position,
            speed);
    }

    public void ChangeTestBaterflyCollider(SphereCollider TestBaterflyCollider, float SphereRadius)
    {
        if (TestBaterflyCollider != null)
        {
            TestBaterflyCollider.radius = SphereRadius;
        }
    }

    #endregion
}

