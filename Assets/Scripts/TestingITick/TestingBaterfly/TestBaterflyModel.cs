using UnityEngine;


    public sealed class TestBaterflyModel
    {


    #region Property

    public SphereCollider BaterflyCollider { get; }
    public Transform BaterflyTransform { get; }
    public TestBaterflyData BaterflyData;
    public TestBaterflyStruct BaterflyStruct;

    #endregion


    #region ClassLifeCycle

    public TestBaterflyModel(GameObject prefab, TestBaterflyData baterflydata)
    {
        BaterflyData = baterflydata;
        BaterflyStruct = baterflydata.TestBaterflyStruct;
        BaterflyTransform = prefab.transform;
        BaterflyCollider = prefab.gameObject.GetComponent<SphereCollider>();
    }

    #endregion



    #region Metods

    public void Initilize()
    {
        BaterflyData.ChangeTestBaterflyCollider(BaterflyCollider, BaterflyStruct.SphereRadius);
        BaterflyData.Move(BaterflyTransform, BaterflyStruct.Target, BaterflyStruct.MoveSpeed);
    }

    #endregion
}

