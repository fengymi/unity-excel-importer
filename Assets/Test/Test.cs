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
        Debug.Log($"���غ�ʱ:{stopwatch.ElapsedMilliseconds}ms");
        //��ӡ����
        foreach (var item in data.EnemyDataEntities)
        {
            Debug.Log($"Id:{item.Id} Name:{item.Name} Health:{item.Health} Exp:{item.Exp} Attack:{item.Attack} ���Ĳ���:{item.���Ĳ���} ");
        }

        stopwatch = System.Diagnostics.Stopwatch.StartNew();
        data = ExcelRuntimeImporter.ExcelImporter.LoadExcel<EnemyData>(path);
        Debug.Log($"���μ��غ�ʱ:{stopwatch.ElapsedMilliseconds}ms");
    }
}
