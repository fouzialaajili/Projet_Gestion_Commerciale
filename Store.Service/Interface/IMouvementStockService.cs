﻿using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IMouvementStockService
    {
        IEnumerable<MouvementStockPivot> GetALL();
        MouvementStockPivot GetMouvementStocks(long id);
        IEnumerable<MouvementStockPivot> MouvementStocks(string identifged);
        void DeleteMouvementStock(MouvementStockPivot mouvementStock);
        void UpdateMouvementStock(MouvementStockPivot mouvementStock);
        void CreateMouvementStock(MouvementStockPivot mouvementStock);
        void SaveMotif();
    }
}
