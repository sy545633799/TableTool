//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.IO;



public class WarehouseTable : BaseTxtTable<WarehouseTable>
{
    
    public string XlsxMapping = "Bag.xlsx";
    
    /// <summary>
    /// 仓库格子ID
    /// </summary>
    public int ID;
    
    /// <summary>
    /// 开启等级
    /// </summary>
    public int OpenLevel;
    
    /// <summary>
    /// 开启消耗
    /// </summary>
    public int Consume;
    
    public override int GetID()
    {
return ID ;
    }
}
