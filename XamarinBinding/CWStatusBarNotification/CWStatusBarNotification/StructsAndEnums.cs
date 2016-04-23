using System;
using ObjCRuntime;

namespace CWNotification
{
  [Native]
  public enum CWNotificationStyle : ulong
	{
		StatusBarNotification,
		NavigationBarNotification
	}

  [Native]
	public enum CWNotificationAnimationStyle : ulong
	{
		Top,
		Bottom,
		Left,
		Right
	}

  [Native]
  public enum CWNotificationAnimationType : ulong
	{
		Replace,
		Overlay
	}
}
