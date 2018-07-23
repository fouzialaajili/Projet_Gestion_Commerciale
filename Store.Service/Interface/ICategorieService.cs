﻿using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    public interface ICategorieService
    {
        IEnumerable<CategoriePivot> GetALL();
        CategoriePivot GetCategoriePivot(long id);
        IEnumerable<CategoriePivot> GetCategoriePivotByDescription(string Description);
 
        void DeleteCategoriePivot(CategoriePivot categorie);
        void UpdateCategoriePivot(CategoriePivot categorie);
        void CreateCategoriePivot(CategoriePivot categorie);
        void SaveCategoriePivot();
    }
}
