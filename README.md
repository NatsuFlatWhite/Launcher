# Launcher

This launcher is a simple program that recreates the web-based login system that was used in the Korean service.

It sends the same login parameters expected by the client and launches the game, allowing automatic login without manually entering account information.

### Features

#### iamqa

Enables switching the client to the QA server branch.

#### iamshuruk

An activation key that enables integration with certain developer-only settings and debugging features.

### How It Works

When launching the game, the launcher passes a predefined login format to the client.

**Version 1.325 format**

```text
_|ID|_|Password|AuthHash
```

**Version 1.627 format**

```text
USN|ID|TimeStamp|Cash|TAG|NEOWIZ_PCBID|SERVICE_TYPE|Age|AUTH_TICKET?|OTT
```

These formats were used by different versions of the original launcher system. By reproducing the expected authentication parameters, the launcher can automatically log the client into the game.

### Additional Notes

#### Korean Client Authentication

Unlike overseas versions of the game, Korean clients do not provide an in-game login screen. Authentication is expected to be performed by an external launcher before the game starts.

As a result, Korean-region clients require launcher authentication in order to run, regardless of the client version. Launching the executable directly without providing the expected login parameters will prevent normal access to the game.

#### Version 1.325 and iamshuruk

For version 1.325, the `iamshuruk` feature is only available when the client is started through the launcher authentication process described above. Simply enabling the corresponding configuration entry is not sufficient; the login parameters must also be supplied by the launcher.

### TODO

* Refactor the authentication system so that `AuthHash` can be obtained from a real authentication service instead of using a hardcoded value.
