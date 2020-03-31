using UnityEngine;


    class TestBaterflyModel
    {

    #region Property

    public GameObject BaterflyTarget;

    public BoxCollider BaterflyBox;

    public Transform BaterflyTransform;

    public float BaterflySpeed;

    #endregion


    #region ClassLifeCycle

    public TestBaterflyModel(GameObject prefab, CubeScriptableObj baterflydata)
    {
        BaterflySpeed = baterflydata.speed;
        BaterflyTransform = prefab.transform;
        BaterflyTarget = baterflydata.Target;
        BaterflyBox = prefab.gameObject.GetComponent<BoxCollider>();
    }

    #endregion
}

