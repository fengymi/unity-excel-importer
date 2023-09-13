using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class EnemyDataScriptableObject : ScriptableObject
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

    private void OnEnable()
    {
        Init();
    }

}