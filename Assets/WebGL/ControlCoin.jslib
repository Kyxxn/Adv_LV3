mergeInto(LibraryManager.library, {
	reactScoreUp: function(curScore){
		window.dispatchReactUnityEvent("reactScoreUp", curScore);
	}
});
