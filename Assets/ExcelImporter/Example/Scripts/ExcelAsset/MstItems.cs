using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class MstItems : ScriptableObject
{
	// 使用ExcelSheetAttribute指定Sheet名称，允许字段名与Sheet名不一致
	[ExcelSheet("MstItems")]
	public List<MstItemEntity> Entities; 
}