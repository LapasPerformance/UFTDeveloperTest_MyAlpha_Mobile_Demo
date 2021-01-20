//----------------------------------------------------------------------------------------------------
// <auto-generated>
//
//		This code was automatically generated by the UFT Developer Application Model code generator.
//
//		Changes to this file may cause incorrect behavior and will be lost 
//		when the code is regenerated.
//
// </auto-generated>
//----------------------------------------------------------------------------------------------------
using System;
using HP.LFT.SDK;  
using System.Collections.Generic;

namespace UFTDeveloperTest_MyAlpha_Mobile_Demo
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("This class is automatically generated by the UFT Developer Application Model code generator.", "15.01")]
	public class MobileLoginAppModel_1 : AppModelBase
	{
		#region Constructors

		public MobileLoginAppModel_1(ITestObject contextTestObject)
		{
			Name = @"MobileLoginAppModel_1";
			MyalphaMobileApplication = new MyalphaMobileApplicationNode(contextTestObject, this);
			HomeApplication = new HomeApplicationNode(contextTestObject, this);
			RebuildDescriptions();
			
		}

		#endregion

		#region Test Objects
	
		public MyalphaMobileApplicationNode MyalphaMobileApplication { get; private set; }
		public HomeApplicationNode HomeApplication { get; private set; }
	
		#endregion
	
		#region Inner Classes
	
		public sealed class MyalphaMobileApplicationNode : ApplicationNodeBase
		{
			#region Constructors
		
			public MyalphaMobileApplicationNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
			{
				WrongEntryCredentialsLabel = new WrongEntryCredentialsLabelNode(this, applicationModel);
				LoginWithCredentialsLabel = new LoginWithCredentialsLabelNode(this, applicationModel);
				PasswordEditField = new PasswordEditFieldNode(this, applicationModel);
				UsernameEditField = new UsernameEditFieldNode(this, applicationModel);
				OkButton = new OkButtonNode(this, applicationModel);
				LogIn2Button = new LogIn2ButtonNode(this, applicationModel);
				LogInButton = new LogInButtonNode(this, applicationModel);
				DisplayName = @"myAlpha Mobile";
			}
		
			#endregion
		
			#region Description
		
			protected override HP.LFT.SDK.Mobile.ApplicationDescription CreateDescription()
			{
				return new HP.LFT.SDK.Mobile.ApplicationDescription {
				IsPackaged = false,
				Identifier = @"com.mobileloft.alpha.droid"
			};
			}
		
			#endregion
		
			#region Test Objects
		
			public WrongEntryCredentialsLabelNode WrongEntryCredentialsLabel { get; private set; }
			public LoginWithCredentialsLabelNode LoginWithCredentialsLabel { get; private set; }
			public PasswordEditFieldNode PasswordEditField { get; private set; }
			public UsernameEditFieldNode UsernameEditField { get; private set; }
			public OkButtonNode OkButton { get; private set; }
			public LogIn2ButtonNode LogIn2Button { get; private set; }
			public LogInButtonNode LogInButton { get; private set; }
		
			#endregion
		
			#region Inner Classes
		
			public sealed class WrongEntryCredentialsLabelNode : LabelNodeBase
			{
				#region Constructors
			
				public WrongEntryCredentialsLabelNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"Wrong entry credentials.";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.LabelDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.LabelDescription {
					Text = @"Wrong entry credentials. Please try again.",
					MobileCenterIndex = 1,
					ClassName = @"Label"
				};
				}
			
				#endregion
			
			}

			public sealed class LoginWithCredentialsLabelNode : LabelNodeBase
			{
				#region Constructors
			
				public LoginWithCredentialsLabelNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"Login with credentials";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.LabelDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.LabelDescription {
					Text = @"Login with credentials",
					ResourceId = @"com.mobileloft.alpha.droid:id/2131363008",
					MobileCenterIndex = 1,
					ClassName = @"Label"
				};
				}
			
				#endregion
			
			}

			public sealed class PasswordEditFieldNode : EditFieldNodeBase
			{
				#region Constructors
			
				public PasswordEditFieldNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"PasswordEditField";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.EditFieldDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.EditFieldDescription {
					ResourceId = @"com.mobileloft.alpha.droid:id/2131362791",
					MobileCenterIndex = 1,
					ClassName = @"Input"
				};
				}
			
				#endregion
			
			}

			public sealed class UsernameEditFieldNode : EditFieldNodeBase
			{
				#region Constructors
			
				public UsernameEditFieldNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"UsernameEditField";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.EditFieldDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.EditFieldDescription {
					ResourceId = @"com.mobileloft.alpha.droid:id/2131362793",
					MobileCenterIndex = 0,
					ClassName = @"Input"
				};
				}
			
				#endregion
			
			}

			public sealed class OkButtonNode : ButtonNodeBase
			{
				#region Constructors
			
				public OkButtonNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"OK";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.ButtonDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.ButtonDescription {
					Text = @"OK",
					ResourceId = @"android:id/button1",
					MobileCenterIndex = 0,
					ClassName = @"Button"
				};
				}
			
				#endregion
			
			}

			public sealed class LogIn2ButtonNode : ButtonNodeBase
			{
				#region Constructors
			
				public LogIn2ButtonNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"Log in_2";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.ButtonDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.ButtonDescription {
					Text = @"Log in",
					ResourceId = @"com.mobileloft.alpha.droid:id/2131363002",
					MobileCenterIndex = 1,
					ClassName = @"Button"
				};
				}
			
				#endregion
			
			}

			public sealed class LogInButtonNode : ButtonNodeBase
			{
				#region Constructors
			
				public LogInButtonNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"Log in";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.ButtonDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.ButtonDescription {
					Text = @"Log in",
					ResourceId = @"com.mobileloft.alpha.droid:id/2131363000",
					MobileCenterIndex = 2,
					ClassName = @"Button"
				};
				}
			
				#endregion
			
			}

			#endregion
		}

		public sealed class HomeApplicationNode : ApplicationNodeBase
		{
			#region Constructors
		
			public HomeApplicationNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
			{
				ComMiuiHomeIdDragLaUiObject = new ComMiuiHomeIdDragLaUiObjectNode(this, applicationModel);
				MyalphaMobileLabel = new MyalphaMobileLabelNode(this, applicationModel);
				DisplayName = @"Home";
			}
		
			#endregion
		
			#region Description
		
			protected override HP.LFT.SDK.Mobile.ApplicationDescription CreateDescription()
			{
				return new HP.LFT.SDK.Mobile.ApplicationDescription {
				IsPackaged = false,
				Identifier = @"MC.Home"
			};
			}
		
			#endregion
		
			#region Test Objects
		
			public ComMiuiHomeIdDragLaUiObjectNode ComMiuiHomeIdDragLaUiObject { get; private set; }
			public MyalphaMobileLabelNode MyalphaMobileLabel { get; private set; }
		
			#endregion
		
			#region Inner Classes
		
			public sealed class ComMiuiHomeIdDragLaUiObjectNode : UiObjectNodeBase
			{
				#region Constructors
			
				public ComMiuiHomeIdDragLaUiObjectNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"com.miui.home:id/drag_la";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.UiObjectDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.UiObjectDescription {
					ResourceId = @"com.miui.home:id/drag_layer_background",
					MobileCenterIndex = 122,
					ClassName = @"View"
				};
				}
			
				#endregion
			
			}

			public sealed class MyalphaMobileLabelNode : LabelNodeBase
			{
				#region Constructors
			
				public MyalphaMobileLabelNode(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel)
				{
					DisplayName = @"myAlpha Mobile";
				}
			
				#endregion
			
				#region Description
			
				protected override HP.LFT.SDK.Mobile.LabelDescription CreateDescription()
				{
					return new HP.LFT.SDK.Mobile.LabelDescription {
					Text = @"myAlpha Mobile",
					ResourceId = @"com.miui.home:id/icon_title",
					MobileCenterIndex = 26,
					ClassName = @"Label"
				};
				}
			
				#endregion
			
			}

			#endregion
		}

		#endregion

		#region Base Classes

		public abstract class UiObjectNodeBase : AppModelNodeBase<HP.LFT.SDK.Mobile.IUiObject, HP.LFT.SDK.Mobile.UiObjectDescription>, HP.LFT.SDK.Mobile.IUiObject
		{
			public UiObjectNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void SetFocus()
			{
				 Concrete.SetFocus();
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			public void Tap()
			{
				 Concrete.Tap();
			}
	
			public void Tap(HP.LFT.SDK.Mobile.TapArgs args)
			{
				 Concrete.Tap(args);
			}
	
			public void LongPress()
			{
				 Concrete.LongPress();
			}
	
			public void LongPress(HP.LFT.SDK.Mobile.LongPressArgs args)
			{
				 Concrete.LongPress(args);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction)
			{
				 Concrete.Swipe(direction);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction, HP.LFT.SDK.Mobile.SwipeArgs args)
			{
				 Concrete.Swipe(direction, args);
			}
	
			public void Pan(HP.LFT.SDK.Location start, HP.LFT.SDK.Location end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end, HP.LFT.SDK.Mobile.PanArgs args)
			{
				 Concrete.Pan(start, end, args);
			}
	
			public void Pinch(double scale)
			{
				 Concrete.Pinch(scale);
			}
	
			public void Pinch(double scale, HP.LFT.SDK.Mobile.PinchArgs args)
			{
				 Concrete.Pinch(scale, args);
			}
	
			#endregion
	
			#region Public Properties
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public string AccessibilityId
			{
				get { return Concrete.AccessibilityId; }		
			}
	
			public string ClassName
			{
				get { return Concrete.ClassName; }		
			}
	
			public string Container
			{
				get { return Concrete.Container; }		
			}
	
			public bool IsClickable
			{
				get { return Concrete.IsClickable; }		
			}
	
			public bool IsFocused
			{
				get { return Concrete.IsFocused; }		
			}
	
			public bool IsFocusable
			{
				get { return Concrete.IsFocusable; }		
			}
	
			public string NativeClass
			{
				get { return Concrete.NativeClass; }		
			}
	
			public string ResourceId
			{
				get { return Concrete.ResourceId; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public bool IsCheckable
			{
				get { return Concrete.IsCheckable; }		
			}
	
			public bool IsChecked
			{
				get { return Concrete.IsChecked; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public string Hint
			{
				get { return Concrete.Hint; }		
			}
	
			public int MobileCenterIndex
			{
				get { return Concrete.MobileCenterIndex; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			#endregion
		}

		public abstract class ButtonNodeBase : AppModelNodeBase<HP.LFT.SDK.Mobile.IButton, HP.LFT.SDK.Mobile.ButtonDescription>, HP.LFT.SDK.Mobile.IButton
		{
			public ButtonNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			public void Tap()
			{
				 Concrete.Tap();
			}
	
			public void Tap(HP.LFT.SDK.Mobile.TapArgs args)
			{
				 Concrete.Tap(args);
			}
	
			public void LongPress()
			{
				 Concrete.LongPress();
			}
	
			public void LongPress(HP.LFT.SDK.Mobile.LongPressArgs args)
			{
				 Concrete.LongPress(args);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction)
			{
				 Concrete.Swipe(direction);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction, HP.LFT.SDK.Mobile.SwipeArgs args)
			{
				 Concrete.Swipe(direction, args);
			}
	
			public void Pan(HP.LFT.SDK.Location start, HP.LFT.SDK.Location end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end, HP.LFT.SDK.Mobile.PanArgs args)
			{
				 Concrete.Pan(start, end, args);
			}
	
			public void Pinch(double scale)
			{
				 Concrete.Pinch(scale);
			}
	
			public void Pinch(double scale, HP.LFT.SDK.Mobile.PinchArgs args)
			{
				 Concrete.Pinch(scale, args);
			}
	
			#endregion
	
			#region Public Properties
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public string AccessibilityId
			{
				get { return Concrete.AccessibilityId; }		
			}
	
			public string ClassName
			{
				get { return Concrete.ClassName; }		
			}
	
			public string Container
			{
				get { return Concrete.Container; }		
			}
	
			public bool IsClickable
			{
				get { return Concrete.IsClickable; }		
			}
	
			public bool IsFocused
			{
				get { return Concrete.IsFocused; }		
			}
	
			public bool IsFocusable
			{
				get { return Concrete.IsFocusable; }		
			}
	
			public string NativeClass
			{
				get { return Concrete.NativeClass; }		
			}
	
			public string ResourceId
			{
				get { return Concrete.ResourceId; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public bool IsCheckable
			{
				get { return Concrete.IsCheckable; }		
			}
	
			public bool IsChecked
			{
				get { return Concrete.IsChecked; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public string Hint
			{
				get { return Concrete.Hint; }		
			}
	
			public int MobileCenterIndex
			{
				get { return Concrete.MobileCenterIndex; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			#endregion
		}

		public abstract class EditFieldNodeBase : AppModelNodeBase<HP.LFT.SDK.Mobile.IEditField, HP.LFT.SDK.Mobile.EditFieldDescription>, HP.LFT.SDK.Mobile.IEditField
		{
			public EditFieldNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void SetText(string text)
			{
				 Concrete.SetText(text);
			}
	
			public void SetSecure(string encodedText)
			{
				 Concrete.SetSecure(encodedText);
			}
	
			public void SetFocus()
			{
				 Concrete.SetFocus();
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			public void Tap()
			{
				 Concrete.Tap();
			}
	
			public void Tap(HP.LFT.SDK.Mobile.TapArgs args)
			{
				 Concrete.Tap(args);
			}
	
			public void LongPress()
			{
				 Concrete.LongPress();
			}
	
			public void LongPress(HP.LFT.SDK.Mobile.LongPressArgs args)
			{
				 Concrete.LongPress(args);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction)
			{
				 Concrete.Swipe(direction);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction, HP.LFT.SDK.Mobile.SwipeArgs args)
			{
				 Concrete.Swipe(direction, args);
			}
	
			public void Pan(HP.LFT.SDK.Location start, HP.LFT.SDK.Location end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end, HP.LFT.SDK.Mobile.PanArgs args)
			{
				 Concrete.Pan(start, end, args);
			}
	
			public void Pinch(double scale)
			{
				 Concrete.Pinch(scale);
			}
	
			public void Pinch(double scale, HP.LFT.SDK.Mobile.PinchArgs args)
			{
				 Concrete.Pinch(scale, args);
			}
	
			#endregion
	
			#region Public Properties
	
			public bool IsPassword
			{
				get { return Concrete.IsPassword; }		
			}
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public string AccessibilityId
			{
				get { return Concrete.AccessibilityId; }		
			}
	
			public string ClassName
			{
				get { return Concrete.ClassName; }		
			}
	
			public string Container
			{
				get { return Concrete.Container; }		
			}
	
			public bool IsClickable
			{
				get { return Concrete.IsClickable; }		
			}
	
			public bool IsFocused
			{
				get { return Concrete.IsFocused; }		
			}
	
			public bool IsFocusable
			{
				get { return Concrete.IsFocusable; }		
			}
	
			public string NativeClass
			{
				get { return Concrete.NativeClass; }		
			}
	
			public string ResourceId
			{
				get { return Concrete.ResourceId; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public bool IsCheckable
			{
				get { return Concrete.IsCheckable; }		
			}
	
			public bool IsChecked
			{
				get { return Concrete.IsChecked; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public string Hint
			{
				get { return Concrete.Hint; }		
			}
	
			public int MobileCenterIndex
			{
				get { return Concrete.MobileCenterIndex; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			#endregion
		}

		public abstract class LabelNodeBase : AppModelNodeBase<HP.LFT.SDK.Mobile.ILabel, HP.LFT.SDK.Mobile.LabelDescription>, HP.LFT.SDK.Mobile.ILabel
		{
			public LabelNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			public void Tap()
			{
				 Concrete.Tap();
			}
	
			public void Tap(HP.LFT.SDK.Mobile.TapArgs args)
			{
				 Concrete.Tap(args);
			}
	
			public void LongPress()
			{
				 Concrete.LongPress();
			}
	
			public void LongPress(HP.LFT.SDK.Mobile.LongPressArgs args)
			{
				 Concrete.LongPress(args);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction)
			{
				 Concrete.Swipe(direction);
			}
	
			public void Swipe(HP.LFT.SDK.SwipeDirection direction, HP.LFT.SDK.Mobile.SwipeArgs args)
			{
				 Concrete.Swipe(direction, args);
			}
	
			public void Pan(HP.LFT.SDK.Location start, HP.LFT.SDK.Location end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end)
			{
				 Concrete.Pan(start, end);
			}
	
			public void Pan(System.Drawing.Point start, System.Drawing.Point end, HP.LFT.SDK.Mobile.PanArgs args)
			{
				 Concrete.Pan(start, end, args);
			}
	
			public void Pinch(double scale)
			{
				 Concrete.Pinch(scale);
			}
	
			public void Pinch(double scale, HP.LFT.SDK.Mobile.PinchArgs args)
			{
				 Concrete.Pinch(scale, args);
			}
	
			#endregion
	
			#region Public Properties
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			public System.Drawing.Point Location
			{
				get { return Concrete.Location; }		
			}
	
			public string AccessibilityId
			{
				get { return Concrete.AccessibilityId; }		
			}
	
			public string ClassName
			{
				get { return Concrete.ClassName; }		
			}
	
			public string Container
			{
				get { return Concrete.Container; }		
			}
	
			public bool IsClickable
			{
				get { return Concrete.IsClickable; }		
			}
	
			public bool IsFocused
			{
				get { return Concrete.IsFocused; }		
			}
	
			public bool IsFocusable
			{
				get { return Concrete.IsFocusable; }		
			}
	
			public string NativeClass
			{
				get { return Concrete.NativeClass; }		
			}
	
			public string ResourceId
			{
				get { return Concrete.ResourceId; }		
			}
	
			public System.Drawing.Size Size
			{
				get { return Concrete.Size; }		
			}
	
			public bool IsCheckable
			{
				get { return Concrete.IsCheckable; }		
			}
	
			public bool IsChecked
			{
				get { return Concrete.IsChecked; }		
			}
	
			public string Text
			{
				get { return Concrete.Text; }		
			}
	
			public string Hint
			{
				get { return Concrete.Hint; }		
			}
	
			public int MobileCenterIndex
			{
				get { return Concrete.MobileCenterIndex; }		
			}
	
			public bool IsEnabled
			{
				get { return Concrete.IsEnabled; }		
			}
	
			#endregion
		}

		public abstract class ApplicationNodeBase : AppModelNodeBase<HP.LFT.SDK.Mobile.IApplication, HP.LFT.SDK.Mobile.ApplicationDescription>, HP.LFT.SDK.Mobile.IApplication
		{
			public ApplicationNodeBase(ITestObject parent, AppModelBase applicationModel) : base(parent, applicationModel) { }

			#region Public Methods
	
			public void Launch()
			{
				 Concrete.Launch();
			}
	
			public void Restart()
			{
				 Concrete.Restart();
			}
	
			public void Install()
			{
				 Concrete.Install();
			}
	
			public void Kill()
			{
				 Concrete.Kill();
			}
	
			public void Uninstall()
			{
				 Concrete.Uninstall();
			}
	
			public void StartCameraSimulationMode(string mediaID)
			{
				 Concrete.StartCameraSimulationMode(mediaID);
			}
	
			public void StopCameraSimulationMode()
			{
				 Concrete.StopCameraSimulationMode();
			}
	
			public void SimulateBarcodeScan(string imageID)
			{
				 Concrete.SimulateBarcodeScan(imageID);
			}
	
			public HP.LFT.SDK.IDescription GetDescription()
			{
				return Concrete.GetDescription();
			}
	
			public TChild[] FindChildren<TChild>(HP.LFT.SDK.IDescription selector)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.FindChildren<TChild>(selector);
			}
	
			public bool Exists()
			{
				return Concrete.Exists();
			}
	
			public bool Exists(uint timeout)
			{
				return Concrete.Exists(timeout);
			}
	
			public System.Drawing.Image GetSnapshot()
			{
				return Concrete.GetSnapshot();
			}
	
			public void Highlight()
			{
				 Concrete.Highlight();
			}
	
			public uint HighlightMatches<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.HighlightMatches<TChild>(description);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind)
			{
				return Concrete.GetTextLocations(textToFind);
			}
	
			public System.Drawing.Rectangle[] GetTextLocations(string textToFind, System.Drawing.Rectangle textArea)
			{
				return Concrete.GetTextLocations(textToFind, textArea);
			}
	
			public string GetVisibleText()
			{
				return Concrete.GetVisibleText();
			}
	
			public string GetVisibleText(System.Drawing.Rectangle textArea)
			{
				return Concrete.GetVisibleText(textArea);
			}
	
			public System.Nullable<System.Drawing.Point> VerifyImageExists(System.Drawing.Image imageToFind, byte similarity = 100)
			{
				return Concrete.VerifyImageExists(imageToFind, similarity);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, pixelTolerance, rgbTolerance);
			}
	
			public bool VerifyImageMatch(System.Drawing.Image expectedImage, HP.LFT.SDK.Utils.ImageMaskArea maskArea, byte pixelTolerance = 0, byte rgbTolerance = 0)
			{
				return Concrete.VerifyImageMatch(expectedImage, maskArea, pixelTolerance, rgbTolerance);
			}
	
			public TChild Describe<TChild>(HP.LFT.SDK.IDescription description)  where TChild:class, HP.LFT.SDK.ITestObject
			{
				return Concrete.Describe<TChild>(description);
			}
	
			#endregion
	
			#region Public Properties
	
			public string Identifier
			{
				get { return Concrete.Identifier; }		
			}
	
			public string Name
			{
				get { return Concrete.Name; }		
			}
	
			public string Version
			{
				get { return Concrete.Version; }		
			}
	
			public bool IsPackaged
			{
				get { return Concrete.IsPackaged; }		
			}
	
			public int Upload
			{
				get { return Concrete.Upload; }		
			}
	
			public HP.LFT.SDK.Mobile.ISimulateAuthResult SimulateAuthentication
			{
				get { return Concrete.SimulateAuthentication; }		
			}
	
			public string DisplayName
			{
				get { return Concrete.DisplayName; }		
				set { Concrete.DisplayName = value; }
			}
	
			#endregion
		}

		#endregion
	}
}