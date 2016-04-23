using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CWNotification
{
  
	// typedef void (^CWCompletionBlock)();
	delegate void CWCompletionBlock ();

	// @interface ScrollLabel : UILabel
	[BaseType (typeof(UILabel))]
	interface ScrollLabel
	{
		// -(CGFloat)scrollTime;
		[Export ("scrollTime")]
		nfloat ScrollTime { get; }
	}

	// @interface CWWindowContainer : UIWindow
	[BaseType (typeof(UIWindow))]
	interface CWWindowContainer
	{
		// @property (assign, nonatomic) CGFloat notificationHeight;
		[Export ("notificationHeight")]
		nfloat NotificationHeight { get; set; }
	}

	// @interface CWViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface CWViewController
	{
		// @property (nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle", ArgumentSemantic.Assign)]
		UIStatusBarStyle PreferredStatusBarStyle { get; set; }

		// @property (nonatomic, setter = setSupportedInterfaceOrientations:) UIInterfaceOrientationMask supportedInterfaceOrientations;
		[Export ("supportedInterfaceOrientations", ArgumentSemantic.Assign)]
		UIInterfaceOrientationMask SupportedInterfaceOrientations { get; [Bind ("setSupportedInterfaceOrientations:")] set; }
	}

	// @interface CWStatusBarNotification : NSObject
	[BaseType (typeof(NSObject))]
	interface CWStatusBarNotification
	{
		// @property (nonatomic, strong) ScrollLabel * notificationLabel;
		[Export ("notificationLabel", ArgumentSemantic.Strong)]
		ScrollLabel NotificationLabel { get; set; }

		// @property (nonatomic, strong) UIView * statusBarView;
		[Export ("statusBarView", ArgumentSemantic.Strong)]
		UIView StatusBarView { get; set; }

		// @property (copy, nonatomic) CWCompletionBlock notificationTappedBlock;
		[Export ("notificationTappedBlock", ArgumentSemantic.Copy)]
		CWCompletionBlock NotificationTappedBlock { get; set; }

		// @property (nonatomic) BOOL notificationIsShowing;
		[Export ("notificationIsShowing")]
		bool NotificationIsShowing { get; set; }

		// @property (nonatomic) BOOL notificationIsDismissing;
		[Export ("notificationIsDismissing")]
		bool NotificationIsDismissing { get; set; }

		// @property (nonatomic, strong) CWWindowContainer * notificationWindow;
		[Export ("notificationWindow", ArgumentSemantic.Strong)]
		CWWindowContainer NotificationWindow { get; set; }

		// @property (nonatomic, strong) UIColor * notificationLabelBackgroundColor;
		[Export ("notificationLabelBackgroundColor", ArgumentSemantic.Strong)]
		UIColor NotificationLabelBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * notificationLabelTextColor;
		[Export ("notificationLabelTextColor", ArgumentSemantic.Strong)]
		UIColor NotificationLabelTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * notificationLabelFont;
		[Export ("notificationLabelFont", ArgumentSemantic.Strong)]
		UIFont NotificationLabelFont { get; set; }

		// @property (assign, nonatomic) CGFloat notificationLabelHeight;
		[Export ("notificationLabelHeight")]
		nfloat NotificationLabelHeight { get; set; }

		// @property (nonatomic, strong) UIView * customView;
		[Export ("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; set; }

		// @property (assign, nonatomic) BOOL multiline;
		[Export ("multiline")]
		bool Multiline { get; set; }

		// @property (nonatomic) UIInterfaceOrientationMask supportedInterfaceOrientations;
		[Export ("supportedInterfaceOrientations", ArgumentSemantic.Assign)]
		UIInterfaceOrientationMask SupportedInterfaceOrientations { get; set; }

		// @property (nonatomic) NSTimeInterval notificationAnimationDuration;
		[Export ("notificationAnimationDuration")]
		double NotificationAnimationDuration { get; set; }

		// @property (nonatomic) CWNotificationStyle notificationStyle;
		[Export ("notificationStyle", ArgumentSemantic.Assign)]
		CWNotificationStyle NotificationStyle { get; set; }

		// @property (nonatomic) CWNotificationAnimationStyle notificationAnimationInStyle;
		[Export ("notificationAnimationInStyle", ArgumentSemantic.Assign)]
		CWNotificationAnimationStyle NotificationAnimationInStyle { get; set; }

		// @property (nonatomic) CWNotificationAnimationStyle notificationAnimationOutStyle;
		[Export ("notificationAnimationOutStyle", ArgumentSemantic.Assign)]
		CWNotificationAnimationStyle NotificationAnimationOutStyle { get; set; }

		// @property (nonatomic) CWNotificationAnimationType notificationAnimationType;
		[Export ("notificationAnimationType", ArgumentSemantic.Assign)]
		CWNotificationAnimationType NotificationAnimationType { get; set; }

		// @property (nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle", ArgumentSemantic.Assign)]
		UIStatusBarStyle PreferredStatusBarStyle { get; set; }

		// -(void)displayNotificationWithMessage:(NSString *)message completion:(void (^)(void))completion;
		[Export ("displayNotificationWithMessage:completion:")]
		void DisplayNotificationWithMessage (string message, Action completion);

		// -(void)displayNotificationWithMessage:(NSString *)message forDuration:(NSTimeInterval)duration;
		[Export ("displayNotificationWithMessage:forDuration:")]
		void DisplayNotificationWithMessage (string message, double duration);

		// -(void)displayNotificationWithAttributedString:(NSAttributedString *)attributedString completion:(void (^)(void))completion;
		[Export ("displayNotificationWithAttributedString:completion:")]
		void DisplayNotificationWithAttributedString (NSAttributedString attributedString, Action completion);

		// -(void)displayNotificationWithAttributedString:(NSAttributedString *)attributedString forDuration:(NSTimeInterval)duration;
		[Export ("displayNotificationWithAttributedString:forDuration:")]
		void DisplayNotificationWithAttributedString (NSAttributedString attributedString, double duration);

		// -(void)displayNotificationWithView:(UIView *)view completion:(void (^)(void))completion;
		[Export ("displayNotificationWithView:completion:")]
		void DisplayNotificationWithView (UIView view, Action completion);

		// -(void)displayNotificationWithView:(UIView *)view forDuration:(NSTimeInterval)duration;
		[Export ("displayNotificationWithView:forDuration:")]
		void DisplayNotificationWithView (UIView view, double duration);

		// -(void)dismissNotificationWithCompletion:(void (^)(void))completion;
		[Export ("dismissNotificationWithCompletion:")]
		void DismissNotificationWithCompletion (Action completion);

		// -(void)dismissNotification;
		[Export ("dismissNotification")]
		void DismissNotification ();
	}
}
