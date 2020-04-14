using UnityEngine;


namespace BeastHunter
{
    public sealed class TestBaterflyInitilizeController : IAwake
    {
        #region Field

        GameContext _context;

        #endregion


        #region ClassLifeCycle

        public TestBaterflyInitilizeController (GameContext context, Services services)
        {
            _context = context;
        }

        #endregion


        #region IAwake

        public void OnAwake()
        {
            var TestBaterflyData = Data.TestBaterflyData;
            GameObject instance = GameObject.Instantiate(TestBaterflyData.TestBaterflyStruct.Prefab);
            TestBaterflyModel TestBaterfly = new TestBaterflyModel(instance,TestBaterflyData);
            _context._testBaterflyModel = TestBaterfly;
        }

        #endregion
    }
}