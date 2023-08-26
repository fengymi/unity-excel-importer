using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    private void Start()
    {
        var stopwatch =  System.Diagnostics.Stopwatch.StartNew();
        var path =  Application.streamingAssetsPath + "/EnemyDataEntities.xlsx";
        var data = ExcelRuntimeImporter.ExcelImporter.LoadExcel<EnemyData>(path);
        Debug.Log($"加载耗时:{stopwatch.ElapsedMilliseconds}ms");
        //打印数据
        foreach (var item in data.EnemyDataEntities)
        {
            Debug.Log($"Id:{item.Id} Name:{item.Name} Health:{item.Health} Exp:{item.Exp} Attack:{item.Attack} 中文测试:{item.中文测试} ");
        }

        stopwatch = System.Diagnostics.Stopwatch.StartNew();
        data = ExcelRuntimeImporter.ExcelImporter.LoadExcel<EnemyData>(path);
        Debug.Log($"二次加载耗时:{stopwatch.ElapsedMilliseconds}ms");
    }
}
