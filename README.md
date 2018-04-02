# Animated transitions for iOS 

This nuget package can be used to quickly add animated transitions to your project. Currently I only tested it with MvvmCross projects but it should also work with Xamarin.iOS projects (although you might need to figure out how to implement it as explanation below will be for MvvmCross projects only).

## TODO

- Better sample app
- Rewrite documentation


## Usage

Add the nuget package "Redhotminute.Plugin.iOS.AnimatedTransitions" to your iOS project. 

Create start and a target MxvViewController, create bindings, viewmodels, etc, make sure the navigation between the ViewControllers work.

For all transitions:

- The starting ViewController should be of type IStartAnimationViewController.
- The target ViewController should be of type IEndAnimationViewController

### Start ViewController

In the start ViewController:

```
private CGRect _startingFrame;
public CGRect StartingFrame
{
	set { this._startingFrame = value; }
	get { return this._startingFrame; }
}
```

```
RevealButton.TouchUpInside += (sender, e) =>
{
	StartingFrame = RevealButton.Frame;
	((StartViewModel)ViewModel).NavigateToTargetViewCommand.Execute(null);
};
```

This can be simplified if you have only one transition on the start ViewController. Just create a binding for the navigation as you would normally do and add this to your code:

```
public CGRect StartingFrame
{
	get { return uiview.Frame }
}
```

### CustomPresenter

Make sure you have a CustomPresenter (will be added to the example project?) and make sure the CustomPresenter has something like this:

```
public override void Show(IMvxIosView view)
{
	if (view is IEndAnimationViewController)
	{
		_currentModalView = view as MvxViewController;
		_currentModalView.ModalPresentationStyle = UIModalPresentationStyle.FullScreen;
		PresentModalViewController(_currentModalView, true);
		return;
	}
	...
```

Also, make sure the closing part is using animations (code not complete!):

```
public override void CloseModalViewController()
{
	_currentModalView.DismissModalViewController(true);
```

### CenterPointRevealTransition

Add the TransitioningDelegate to the target ViewController. I have done this both in ViewDidLoad and in the constructor, both seems to work. 

```
TransitioningDelegate = new CircleButtonRevealTransitioningDelegate(.5f);
```

### CircleButtonRevealTransition

Set speed and background color of target view.

```
TransitioningDelegate = new CenterPointRevealTransitioningDelegate(.5f, UIColor.FromRGB(244, 198, 249));
```

## TODO
- Add more transitions
- Dive into interactive transitions
- Add multiple parameters (open vs close duration), open vs close alpha

## Inspiration, Docs, Links

* http://mathewsanders.com/custom-menu-transitions-in-swift/
* https://www.raywenderlich.com/86521/how-to-make-a-view-controller-transition-animation-like-in-the-ping-app
* https://www.raywenderlich.com/146692/ios-animation-tutorial-custom-view-controller-presentation-transitions-2
* https://www.raywenderlich.com/110536/custom-uiviewcontroller-transitions
* https://github.com/andreamazz/BubbleTransition
* https://github.com/onmyway133/fantastic-ios-animation/blob/master/Animation/transition.md
* https://github.com/ameizi/awesome-ios-animation
* https://github.com/recruit-mp/RMPZoomTransitionAnimator/blob/master/Pod/Classes/RMPZoomTransitionAnimator.m

## More Information
Just ask Jacob if you want more information. He seems to be the Transitioning Master for iOS at this moment :)

## License
None as of now. 