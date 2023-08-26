using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyDataEntity
{
    public int Id;
    public string Name;
    public int Health;
    public int Exp;
    public int Attack;
    public int ÷–Œƒ≤‚ ‘;
}


[ExcelAsset]
public class EnemyData : ScriptableObject
{
    public List<EnemyDataEntity> EnemyDataEntities;

    public Dictionary<int, EnemyDataEntity> EnemyDataEntityDic => enemyDataEntityDic;
    private Dictionary<int, EnemyDataEntity> enemyDataEntityDic;

    public void Init()
    {
        enemyDataEntityDic = new Dictionary<int, EnemyDataEntity>();
        foreach (var item in EnemyDataEntities)
        {
            enemyDataEntityDic.Add(item.Id, item);
        }
    }

}