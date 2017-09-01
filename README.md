# window-focus

This C# solution demonstrates how the focus can be given to another process.

* Process Alice starts process Bob and passes Bob its window handle.
* Bob sets its _owner_ to Alice's window handle.
* Alice can now call `SetActiveWindow()` using Bob's window handle to activate Bob.
  Bob gets the keyboard focus too.

For this to work also when minimizing Bob, there is some additional logic:

* When Bob gets minimized, it resets its owner to `null`.
* When Bob gets restored, it restores its owner to Alice's window handle.
* Alice can restore Bob by using `ShowWindow()` with `SW_RESTORE`.


