using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Test : MonoBehaviour
{
    public EnemyDataScriptableObject enemyDataScriptableObject;
    private void Start()
    {
        Debug.Log(enemyDataScriptableObject.EnemyDataEntityDic.Count);

        var stopwatch =  System.Diagnostics.Stopwatch.StartNew();
        var path =  Application.streamingAssetsPath + "/EnemyDataEntities.xlsx";//python���ɵı��
        var pathEnemyData = Application.streamingAssetsPath + "/EnemyData.xlsx";
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
        ExcelRuntimeTools.ExcelLoader.LoadToDictionary(dic, pathEnemyData);
        Debug.Log($"�ֵ�����:{dic.Count}");

        foreach (var item in dic)
        {
            Debug.Log($"Key:{item.Key} Id:{item.Value.Id} Name:{item.Value.Name} Health:{item.Value.Health} Exp:{item.Value.Exp} Attack:{item.Value.Attack} ���Ĳ���:{item.Value.���Ĳ���} ");
        }
        stopwatch = System.Diagnostics.Stopwatch.StartNew();
        var list = new List<EnemyDataEntity>();
        ExcelRuntimeTools.ExcelLoader.LoadToList(list, path);
        Debug.Log($"����ʱ��1:{stopwatch.ElapsedMilliseconds}ms");
        Debug.Log($"�б�����:{list.Count}");

        //foreach (var item in list)
        //{
        //    Debug.Log($"Id:{item.Id} Name:{item.Name} Health:{item.Health} Exp:{item.Exp} Attack:{item.Attack} ���Ĳ���:{item.���Ĳ���} ");
        //}
        stopwatch = System.Diagnostics.Stopwatch.StartNew();
        using (var fs = File.OpenRead(path))
        {
            
            var list2 = new List<EnemyDataEntity>();
            ExcelRuntimeTools.ExcelLoader.LoadToList(list2, fs);
            Debug.Log($"����ʱ��2:{stopwatch.ElapsedMilliseconds}ms");
            Debug.Log($"�б�����:{list2.Count}");
        }
    }
}
