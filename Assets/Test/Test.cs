using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Test : MonoBehaviour
{
    private void Start()
    {
        var stopwatch =  System.Diagnostics.Stopwatch.StartNew();
        var path =  Application.streamingAssetsPath + "/EnemyDataEntities.xlsx";//python���ɵı��
        var path2 = Application.streamingAssetsPath + "/EnemyData.xlsx";
        var data = ExcelRuntimeTools.ExcelLoader.LoadExcel<EnemyData>(path);
        Debug.Log($"���غ�ʱ:{stopwatch.ElapsedMilliseconds}ms");
        

        stopwatch = System.Diagnostics.Stopwatch.StartNew();
        data = ExcelRuntimeTools.ExcelLoader.LoadExcel<EnemyData>(path);
        Debug.Log($"���μ��غ�ʱ:{stopwatch.ElapsedMilliseconds}ms");

        stopwatch = System.Diagnostics.Stopwatch.StartNew();
        //���Է���ֻ�ܼ���5ms����
        using (var fs = File.OpenRead(path))
        {
            var data2 = ExcelRuntimeTools.ExcelLoader.LoadExcel<EnemyData, EnemyDataEntity>(fs);
            Debug.Log($"���ٷ������ʱ��:{stopwatch.ElapsedMilliseconds}ms");
        }

        //��ӡ����
        //foreach (var item in data.EnemyDataEntities)
        //{
        //    Debug.Log($"Id:{item.Id} Name:{item.Name} Health:{item.Health} Exp:{item.Exp} Attack:{item.Attack} ���Ĳ���:{item.���Ĳ���} ");
        //}


        var dic = new Dictionary<int, EnemyDataEntity>();
        ExcelRuntimeTools.ExcelLoader.LoadToDictionary(dic, path2);
        Debug.Log($"�ֵ�����:{dic.Count}");

        foreach (var item in dic)
        {
            Debug.Log($"Key:{item.Key} Id:{item.Value.Id} Name:{item.Value.Name} Health:{item.Value.Health} Exp:{item.Value.Exp} Attack:{item.Value.Attack} ���Ĳ���:{item.Value.���Ĳ���} ");
        }

        var list = new List<EnemyDataEntity>();
        ExcelRuntimeTools.ExcelLoader.LoadToList(list, path2);
        Debug.Log($"�б�����:{list.Count}");

        foreach (var item in list)
        {
            Debug.Log($"Id:{item.Id} Name:{item.Name} Health:{item.Health} Exp:{item.Exp} Attack:{item.Attack} ���Ĳ���:{item.���Ĳ���} ");
        }
    }
}
