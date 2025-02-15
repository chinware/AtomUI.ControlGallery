﻿///
/// This code is auto generated. Do not modify.
///
using Avalonia;
using System;
using AtomUI.IconPkg;
namespace AtomUIGallery.Icon.Application;
public partial class ApplicationIconPackage
{
    public static AtomUI.IconPkg.Icon AlertFilled()
    {
        return ApplicationIconPackage.Current.BuildIcon(ApplicationIconKind.AlertFilled);
    }

    public static AtomUI.IconPkg.Icon AlertFilled(ColorInfo colorInfo)
    {
        return ApplicationIconPackage.Current.BuildIcon(ApplicationIconKind.AlertFilled, colorInfo);
    }

    public static AtomUI.IconPkg.Icon AlertFilled(TwoToneColorInfo twoToneColorInfo)
    {
        return ApplicationIconPackage.Current.BuildIcon(ApplicationIconKind.AlertFilled, twoToneColorInfo);
    }

    private partial void SetupIconPool()
    {
        _iconInfoPool.Add((int)ApplicationIconKind.AlertFilled, () => new IconInfo("AlertFilled", IconThemeType.Filled, new Rect(0, 0, 1024, 1024), new List<GeometryData>{new GeometryData("M512 244c176.18 0 319 142.82 319 319v233a32 32 0 0 1-32 32H225a32 32 0 0 1-32-32V563c0-176.18 142.82-319 319-319zM484 68h56a8 8 0 0 1 8 8v96a8 8 0 0 1-8 8h-56a8 8 0 0 1-8-8V76a8 8 0 0 1 8-8zM177.25 191.66a8 8 0 0 1 11.32 0l67.88 67.88a8 8 0 0 1 0 11.31l-39.6 39.6a8 8 0 0 1-11.31 0l-67.88-67.88a8 8 0 0 1 0-11.31l39.6-39.6zm669.6 0l39.6 39.6a8 8 0 0 1 0 11.3l-67.88 67.9a8 8 0 0 1-11.32 0l-39.6-39.6a8 8 0 0 1 0-11.32l67.89-67.88a8 8 0 0 1 11.31 0zM192 892h640a32 32 0 0 1 32 32v24a8 8 0 0 1-8 8H168a8 8 0 0 1-8-8v-24a32 32 0 0 1 32-32zm148-317v253h64V575h-64z", true)}));
        IconThemeRanges.Add(IconThemeType.Filled, (1, 1));
    }
}
