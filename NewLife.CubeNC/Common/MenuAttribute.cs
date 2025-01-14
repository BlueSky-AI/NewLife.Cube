﻿namespace NewLife.Cube;

/// <summary>菜单模式</summary>
[Flags]
public enum MenuModes
{
    /// <summary>管理后台可见</summary>
    Admin = 1,

    /// <summary>租户可见</summary>
    Tenant = 2,
}

/// <summary>菜单特性</summary>
public class MenuAttribute : Attribute
{
    #region 属性
    /// <summary>
    /// 顺序。较大者在前面
    /// </summary>
    public Int32 Order { get; set; }

    /// <summary>
    /// 可见
    /// </summary>
    public Boolean Visible { get; set; } = true;

    /// <summary>菜单模式。控制在管理后台和租户模式下是否可见</summary>
    public MenuModes Mode { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public String Icon { get; set; }
    #endregion

    /// <summary>
    /// 设置菜单特性
    /// </summary>
    /// <param name="order"></param>
    /// <param name="visible"></param>
    public MenuAttribute(Int32 order, Boolean visible = true)
    {
        Order = order;
        Visible = visible;
    }
}