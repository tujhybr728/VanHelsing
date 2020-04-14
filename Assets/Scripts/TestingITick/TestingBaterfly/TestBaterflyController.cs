﻿using UnityEngine;

namespace BeastHunter
{ 
    public sealed class TestBaterflyController : IAwake, IUpdate
    {
    #region Fields

    private  readonly GameContext _context;

    #endregion


    #region ClassLifeCycle

    public TestBaterflyController(GameContext context, Services services)
    {
        _context = context;
    }

    #endregion


    #region Updating

    public void Updating()
    {
        _context._testBaterflyModel.Initilize();
    }

    #endregion


    #region OnAwake

    public void OnAwake()
    {

    }

    #endregion
    }
}

