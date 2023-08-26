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
    public int 中文测试;//兼容性差，不建议使用(Python生成的表格包含中文会加载失败，原因未知，可能是编码问题)
}


[ExcelAsset]
public class EnemyData
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

